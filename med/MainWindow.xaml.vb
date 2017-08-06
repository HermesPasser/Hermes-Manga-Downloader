'Imports System.Collections
Imports System.Net
Imports System.IO

Class MainWindow
    Private Sub btn_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        ' essa linha deve dar erro se o link for invalido
        ' catar o erro e retornar null para poder enviar msg de erro ao user
        Dim t As String() = GetTextOfImageLinks(GetURL("https://www.mangaeden.com/en/it-manga/batticuore-notturno---ransie-la-strega/6/22/"))
        t = GetImageLinksInTheText(t)
        DownloadImages(t, "C:\Users\Diogo\Desktop\med\tokimeki")
        'MessageBox.Show(GetType(t(0)))
        'DownloadImage("cdn.mangaeden.com/mangasimg/61/61f08f33a34da3da63fb64725d0a9e0ba9e8b439887da5a15de2e440.jpg", "C:\Users\Diogo\Desktop\med\tokimeki")
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
