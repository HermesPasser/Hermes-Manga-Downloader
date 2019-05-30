Imports System.Threading
Imports System.IO

Public Class MangaKakalotForm
    Protected finished As Boolean = False
    Protected downloading As Boolean = False

    Private Sub MangaKakalotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start()

        ChapterSelector1.TextPattern = "chapter_\d+(_\d+|\.\d+|)"
        AddHandler ChapterSelector1.ChapterTextBox.TextChanged, AddressOf ChapterTextbox_TextChanged
    End Sub

    Private Sub Download(manga As String, chapters As String(), filename As String)
        Dim mk As MangaKakalotDownloader = New MangaKakalotDownloader()
        mk.threadLimit = [Shared].threadLimitPref
        For Each ch As String In chapters
            Dim path = IO.Path.Combine(filename, manga, manga + "_" + ch)
            Directory.CreateDirectory(path)

            Try
                mk.Download(manga, ch, path)
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

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If ChapterSelector1.Chapters.Count = 0 Then
            MessageBox.Show("Add a chapter to be download.")
            Return
        End If

        Dim m As String = textManga.Text
        ' TODO: make starts with chapter_
        Dim c As String() = ChapterSelector1.Chapters
        Dim t As Thread = New Thread(Sub() Download(m, c, [Shared].downloadFolderPref))

        downloading = True
        ChapterSelector1.Enabled = False
        btnDownload.Enabled = False
        CustomMenuStrip1.ReturnMainMenuItem.Enabled = False
        btnDownload.Text = "Downloading..."
        t.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If finished Then
            ChapterSelector1.Enabled = True
            btnDownload.Enabled = True

            CustomMenuStrip1.ReturnMainMenuItem.Enabled = True
            btnDownload.Text = "Download"
            finished = False
            downloading = False
        End If
        textLog.Text = [Shared].Log
    End Sub

    Private Sub MangaKakalotForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub MangaKakalotForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
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

    Private Sub ChapterTextbox_TextChanged(sender As Object, e As EventArgs)
        'TODO: use some regex here (|chapter_)\d+(_\d+|\.\d+|)

        Dim textBox As TextBox = sender
        textBox.Text = textBox.Text.ToLower()
        If Not textBox.Text.StartsWith("chapter_") Then
            Dim s As Integer = textBox.SelectionStart
            textBox.Text = "chapter_" + textBox.Text
            textBox.SelectionStart = s + 8
        End If
    End Sub

    Private Sub textManga_TextChanged(sender As Object, e As EventArgs) Handles textManga.TextChanged
        Dim s = textManga.SelectionStart
        textManga.Text = textManga.Text.Replace(" ", "_")
        textManga.SelectionStart = s
    End Sub
End Class