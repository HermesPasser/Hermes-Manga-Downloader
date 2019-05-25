Imports System.Threading
Imports System.IO

Public Class MangaEdenForm
    Private finished As Boolean = False
    Private downloading As Boolean = False ' maybe it don't need two bools

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textManga.Text = ""
        textChapter.Text = ""
        cbLanguage.SelectedIndex = 0

        Timer1.Interval = 2000
        Timer1.Start()
    End Sub

    Private Sub EnabledChapterButtons(enabled As Boolean)
        btnDownload.Enabled = enabled
        btnAddChap.Enabled = enabled
        btnClearChap.Enabled = enabled
        btnRemoveChap.Enabled = enabled
    End Sub

    Private Sub Download(language As MangaEdenDownloader.Language, manga As String, chapters As ListBox.ObjectCollection, filename As String)
        Dim md As MangaEdenDownloader = New MangaEdenDownloader()
        md.threadLimit = [Shared].threadLimitPref
        For Each ch As String In chapters
            Dim path = IO.Path.Combine(filename, manga, manga + "_c" + ch)
            Directory.CreateDirectory(path)

            Try
                md.Download(language, manga, ch, path)
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
        ' TODO: supress the download completed message when a error was thown
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.ShowBalloonTip(1000, "HMD", "Download Completed.", ToolTipIcon.Info)
        Else
            MessageBox.Show("Download Completed.")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If finished Then
            EnabledChapterButtons(True)
            ReturnMainMenuItem.Enabled = True
            btnDownload.Text = "Download"
            finished = False
            downloading = False
        End If
        textLog.Text = [Shared].Log
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If listChapters.Items.Count = 0 Then
            MessageBox.Show("Add a chapter to be download.") ' TODO: remove text hardcoded
            Return
        End If

        Dim l As Integer = cbLanguage.SelectedIndex
        Dim m As String = textManga.Text
        Dim c As ListBox.ObjectCollection = listChapters.Items
        Dim t As Thread = New Thread(Sub() Download(l, m, c, [Shared].downloadFolderPref))

        downloading = True
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
        MainForm.About.Show()
    End Sub

    Private Sub MangaFoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MangaFoxToolStripMenuItem.Click
        Process.Start("https://hermespasser.github.io/pages/mangafoxdownloader.html")
    End Sub

    Private Sub MangaHostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MangaHostToolStripMenuItem.Click
        Process.Start("https://github.com/HermesPasser/Manga-Host-Downloader")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ReturnToMainFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnMainMenuItem.Click
        MainForm.Main.Show()
        Me.Hide()
    End Sub

    Private Sub MangaEdenForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub ShowOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowOptionsToolStripMenuItem.Click
        Dim t As New OptionsForm With {.MotherForm = Me}
        t.Show()
        Me.Enabled = False
    End Sub

    Private Sub MangaEdenForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized AndAlso downloading Then
            Me.Hide()
            NotifyIcon1.Visible = True
            NotifyIcon1.ShowBalloonTip(1000, "HMD", "Downloading...", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
End Class
