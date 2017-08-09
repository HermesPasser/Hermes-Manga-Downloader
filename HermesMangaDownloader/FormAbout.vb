Public Class FormAbout
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        windowname.Text = ApplicationShared.appName
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://gladiocitrico.blogspot.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/HermesPasser/Hermes-Manga-Downloader")
    End Sub
End Class