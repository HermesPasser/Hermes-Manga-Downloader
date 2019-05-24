Public Class MainForm
    Dim eden As MangaEdenForm
    Dim hentai As Hentai2ReadForm
    Public Shared Main As MainForm
    Public Shared About As FormAbout

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eden = New MangaEdenForm()
        hentai = New Hentai2ReadForm()
        About = New FormAbout()
        Main = Me
    End Sub

    Private Sub mangaEdenButton_Click(sender As Object, e As EventArgs) Handles mangaEdenButton.Click
        eden.Show()
        Me.Hide()
    End Sub

    Private Sub hentai2ReadButton_Click(sender As Object, e As EventArgs) Handles hentai2ReadButton.Click
        hentai.Show()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class