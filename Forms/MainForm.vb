Public Class MainForm
    Dim eden As MangaEdenForm
    Dim hentai As Hentai2ReadForm
    Dim kaka As MangaKakalotForm
    Public Shared Main As MainForm
    Public Shared About As FormAbout

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eden = New MangaEdenForm()
        hentai = New Hentai2ReadForm()
        kaka = New MangaKakalotForm()
        About = New FormAbout()
        Main = Me
        [Shared].LoadPrefs()
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

    Private Sub kakalotButton_Click(sender As Object, e As EventArgs) Handles kakalotButton.Click
        kaka.Show()
        Me.Hide()
    End Sub
End Class