Imports System.Net
Imports System.IO

Class MainWindow
    Private Sub btn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        textManga.Text = textManga.Text.Replace(" ", "-")
        Dim t As String() = GetTextOfImageLinks(GetURL("http://www.mangaeden.com/en/en-manga/nanatsu-no-taizai/229/1/"))
        If t IsNot Nothing Then
            t = GetImageLinksInTheText(t)
            DownloadImages(t, "C:\Users\Diogo\Desktop\med\tokimeki")
        Else
            MessageBox.Show("This manga is not available or is licensed in your region, make sure you entered the name, chapter and language correctly.")
        End If

    End Sub

    Private Function GetURL(url As String) As String
        Dim res As WebResponse = (WebRequest.Create(url)).GetResponse()
        Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
        Dim result As String = reader.ReadToEnd()
        reader.Close()
        res.Close()
        Return result
    End Function

    'Get the line in the html that contains the image links
    Private Function GetTextOfImageLinks(htmlText As String) As String()
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
