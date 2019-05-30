<Docking(DockStyle.Top)>
Public Class CustomMenuStrip

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
        Me.ParentForm.Hide()
    End Sub

    Private Sub ShowOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowOptionsToolStripMenuItem.Click
        Dim t As New OptionsForm With {.MotherForm = Me.ParentForm}
        t.Show()
        Me.ParentForm.Enabled = False
    End Sub
End Class
