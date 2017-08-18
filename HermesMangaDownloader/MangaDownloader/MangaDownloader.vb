Imports System.Net
Imports System.IO

Public MustInherit Class MangaDownloader

    Protected MustOverride Function GetBaseURL() As String

    Protected Function GetHTML(url As String) As String
        Dim result As String = Nothing
        Try
            Dim res As WebResponse = (WebRequest.Create(url)).GetResponse()
            Dim reader As StreamReader = New StreamReader(res.GetResponseStream())
            result = reader.ReadToEnd()
            reader.Close()
            res.Close()
        Catch e As WebException
            ' Do nothing
        End Try
        Return result
    End Function

    Protected Sub DownloadImages(links As String(), filename As String)
        Dim page As Integer = 1
        For Each link In links
            Dim f As String = filename + "_p" + page.ToString() + ".jpg"
            ApplicationShared.Log = "Downloading " + link + " as " + f + Environment.NewLine + ApplicationShared.Log
            DownloadImage(link, f)
            page += 1
        Next
    End Sub

    Protected Sub DownloadImage(link As String, filename As String)
        Try
            Dim wc As WebClient = New WebClient()
            wc.DownloadFile("https://" + link, filename)
        Catch e As Exception
            Throw New MangaDownloadException("link: " + link + Environment.NewLine + "filename: " + filename + Environment.NewLine + "Error: " + e.ToString())
        End Try
    End Sub
End Class
