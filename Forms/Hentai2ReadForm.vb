Imports System.Threading
Imports System.IO

Public Class Hentai2ReadForm
    Dim finished As Boolean = False
    Dim filepath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filepath = ""
        textManga.Text = ""
        textChapter.Text = ""

        Timer1.Interval = 2000
        Timer1.Start()
    End Sub

    Private Sub EnabledChapterButtons(enabled As Boolean)
        btnDownload.Enabled = enabled
        btnAddChap.Enabled = enabled
        btnClearChap.Enabled = enabled
        btnRemoveChap.Enabled = enabled
    End Sub

    Private Sub Download(manga As String, chapters As ListBox.ObjectCollection, filename As String)
        Dim md As Hentai2ReadDownloader = New Hentai2ReadDownloader()
        For Each ch As String In chapters
            Dim path = IO.Path.Combine(filename, manga + "_c" + ch)
            Directory.CreateDirectory(path)

            Try
                md.Download(manga, ch, path)
            Catch ex As MangaDownloadException
                If Not Directory.EnumerateFileSystemEntries(path).Any() Then
                    Directory.Delete(path)
                End If

                MessageBox.Show(ex.Message)
                finished = True
                Return
            End Try
        Next

        finished = True
        MessageBox.Show("Download Completed.")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If finished Then
            EnabledChapterButtons(True)
            ReturnMainMenuItem.Enabled = True
            btnDownload.Text = "Download"
            finished = False
        End If
        textLog.Text = ApplicationShared.Log
    End Sub

    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        Dim dialog As FolderBrowserDialog = New FolderBrowserDialog()
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            filepath = dialog.SelectedPath + "\"
        End If
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If listChapters.Items.Count = 0 Then
            MessageBox.Show("Add a chapter to be download.")
            Return
        End If

        Dim m As String = textManga.Text
        Dim c As ListBox.ObjectCollection = listChapters.Items
        Dim t As Thread = New Thread(Sub() Download(m, c, filepath))

        textManga.Text = textManga.Text.Replace(" ", "-")
        EnabledChapterButtons(False)
        ReturnMainMenuItem.Enabled = False
        btnDownload.Text = "Downloading..."
        t.Start()
    End Sub

    Private Sub btnAddChap_Click(sender As Object, e As EventArgs) Handles btnAddChap.Click
        If textChapter.Text IsNot "" Then
            listChapters.Items.Add(textChapter.Text)
        End If
        textChapter.Text = ""
    End Sub

    Private Sub btnChapRemove_Click(sender As Object, e As EventArgs) Handles btnRemoveChap.Click
        listChapters.Items.Remove(listChapters.SelectedItem)
    End Sub

    Private Sub btnClearChap_Click(sender As Object, e As EventArgs) Handles btnClearChap.Click
        listChapters.Items.Clear()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim a As FormAbout = New FormAbout()
        a.Show()
    End Sub

    Private Sub MangaFoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MangaFoxToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://hermespasser.github.io/pages/mangafoxdownloader.html")
    End Sub

    Private Sub MangaHostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MangaHostToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/HermesPasser/Manga-Host-Downloader")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ReturnToMainFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnMainMenuItem.Click
        MainForm.Main.Show()
        Me.Hide()
    End Sub
End Class