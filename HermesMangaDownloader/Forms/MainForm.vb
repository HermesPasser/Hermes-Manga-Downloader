Public Class MainForm
    Dim eden As MangaEdenForm
    Dim hentai As Hentai2ReadForm
    Public Shared Main As MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eden = New MangaEdenForm()
        hentai = New Hentai2ReadForm()
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

    Private Sub aboutButton_Click(sender As Object, e As EventArgs) Handles aboutButton.Click
        Dim a As FormAbout = New FormAbout()
        a.Show()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub
End Class