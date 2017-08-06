Imports System.Windows.Forms
Imports System.Net
Imports System.IO

Class MainWindow
    Dim filepath As String
    Dim errorMsg As String

    Private Sub Init(sender As Object, e As EventArgs)
        filepath = ""
        textManga.Text = ""
        textChapter.Text = ""
        cbLanguage.SelectedIndex = 0
        errorMsg = "This manga is not available or is licensed in your region, make sure you entered the name, chapter and language correctly."
    End Sub

#Region "Menu"
    Private Sub exit_Click(sender As Object, e As RoutedEventArgs)
        System.Windows.Application.Current.Shutdown()
    End Sub

    Private Sub mfd_Click(sender As Object, e As RoutedEventArgs)
        System.Diagnostics.Process.Start("https://hermespasser.github.io/pages/mangafoxdownloader.html")
    End Sub

    Private Sub mhd_Click(sender As Object, e As RoutedEventArgs)
        System.Diagnostics.Process.Start("https://github.com/HermesPasser/Manga-Host-Downloader")
    End Sub

    Private Sub about_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("Hermes Manga Downloader 0.1" + Environment.NewLine + "by Hermes Passer (gladiocitrico.blogspot.com / hermespasser@gmail.com)" + Environment.NewLine + "Github: HermesPasser/Hermes-Manga-Downloader")
    End Sub
#End Region

    Private Sub btnPath_Click(sender As Object, e As RoutedEventArgs)
        Dim dialog As FolderBrowserDialog = New FolderBrowserDialog()
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            filepath = dialog.SelectedPath + "\"
        End If
    End Sub

    Private Sub btn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textManga.Text = textManga.Text.Replace(" ", "-")

        If textManga.Text Is "" Or textChapter.Text Is "" Or filepath Is "" Then
            MessageBox.Show("Complete all fields.")
            Return
        End If

        btnDownload.IsEnabled = False
        btnDownload.Content = "Downloading..."
        Dim cb As String = IIf(cbLanguage.SelectedIndex = 0, "en", "it")
        Dim str As String = "http://www.mangaeden.com/en/" + cb + "-manga/" + textManga.Text + "/" + textChapter.Text + "/1/"
        Dim t As String() = GetTextOfImageLinks(GetHTML(str))

        If t IsNot Nothing Then
            t = GetImageLinksInTheText(t)
            DownloadImages(t, filepath + textManga.Text + "_c" + textChapter.Text)
            MessageBox.Show("Download Completed.")
        Else
            MessageBox.Show(errorMsg)
        End If
        btnDownload.IsEnabled = True
        btnDownload.Content = "Download"
    End Sub

    Private Function GetHTML(url As String) As String
        Dim result As String = Nothing
        Try
            Dim res As WebResponse = (WebRequest.Create(url)).GetResponse()
            Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
            result = reader.ReadToEnd()
            reader.Close()
            res.Close()
        Catch e As WebException
            '
        End Try
        Return result
    End Function

    'Get the line in the html that contains the image links
    Private Function GetTextOfImageLinks(htmlText As String) As String()
        If htmlText Is Nothing Then
            Return Nothing
        End If

        Dim htmLines As String() = htmlText.Split(Environment.NewLine.ToCharArray())

        For Each line In htmLines
            If line.Contains("var pages") Then
                Return line.Split(",")
            End If
        Next
        Return Nothing
    End Function

    'Get the line in the html that contains the image links
    Private Function GetImageLinksInTheText(text As String()) As String()
        Dim links As New ArrayList()
        For Each line In text
            If line.Contains("""fs"":") Then
                Dim link As String = line.Substring(line.IndexOf("//") + 2)
                links.Add(link.Replace("""", ""))
            End If
        Next
        Return links.ToArray(GetType(String))
    End Function

    Private Sub DownloadImages(links As String(), filename As String)
        Dim page As Integer = 1
        For Each link In links
            DownloadImage(link, filename + "_p" + page.ToString() + ".jpg")
            page += 1
        Next
    End Sub

    Private Sub DownloadImage(link As String, filename As String)
        Try
            Dim wc As WebClient = New WebClient()
            wc.DownloadFile("https://" + link, filename)
        Catch e As Exception
            MessageBox.Show("link: " + link + Environment.NewLine + "filename: " + filename + Environment.NewLine + "Error: " + e.ToString())
        End Try
    End Sub
End Class
