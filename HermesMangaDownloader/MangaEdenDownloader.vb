Imports System.Net
Imports System.IO

Public Class MangaDownloadException
    Inherits Exception
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class

Public Class MangaEdenDownloader
    Const baseURL As String = "http://www.mangaeden.com/en/"

    Public Enum Language
        en
        it
    End Enum

    Public Sub Download(language As Language, manga As String, chapter As String, filename As String)
        If manga Is "" Or chapter Is "" Or filename Is "" Then
            Throw New MangaDownloadException("Empty fields, did you complete them?")
            Return
        End If

        Dim str As String = baseURL + language.ToString() + "-manga/" + manga + "/" + chapter + "/1/"
        Dim t As String() = GetTextOfImageLinks(GetHTML(str))

        If t IsNot Nothing Then
            t = GetImageLinksInTheText(t)
            DownloadImages(t, filename + manga + "_c" + chapter)
            ApplicationShared.Log = filename + manga + "_c" + chapter + " downloaded finished " + Environment.NewLine + ApplicationShared.Log
        Else
            Throw New MangaDownloadException(ApplicationShared.errorMsg)
        End If

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
            Dim f As String = filename + "_p" + page.ToString() + ".jpg"
            ApplicationShared.Log = "Downloading " + link + " as " + f + Environment.NewLine + ApplicationShared.Log
            DownloadImage(link, f)
            page += 1
        Next
    End Sub

    Private Sub DownloadImage(link As String, filename As String)
        Try
            Dim wc As WebClient = New WebClient()
            wc.DownloadFile("https://" + link, filename)
        Catch e As Exception
            Throw New MangaDownloadException("link: " + link + Environment.NewLine + "filename: " + filename + Environment.NewLine + "Error: " + e.ToString())
        End Try
    End Sub
End Class
