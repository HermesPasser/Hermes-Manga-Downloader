Imports System.Net
Imports System.IO
Imports System.Threading

Public MustInherit Class MangaDownloader
    Public threadLimit As Integer = 5
    Protected mangaName As String
    Protected mangaChapter As String
    Protected directoryPath As DirectoryInfo

    Protected MustOverride Function GetBaseURL() As String

    Protected Function GetFileName(page As String) As String
        Return mangaName + "_c" + mangaChapter + "_p" + page + ".jpg"
    End Function

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

    Protected Sub DownloadPages(pages As List(Of MangaPage))
        Dim pagesToJoin As Integer = 1
        Dim pageCount As Integer = pages.Count
        Dim threads As New List(Of Thread)

        For Each page In pages
            Dim subprocess = Sub()
                                 DownloadImage(page)
                             End Sub

            ApplicationShared.Log = "Downloading " + page.url + " as " + page.name + Environment.NewLine + ApplicationShared.Log
            threads.Add(New Thread(subprocess))
            threads.Last.Start()

            pagesToJoin += 1
            If pagesToJoin = threadLimit Or pagesToJoin >= pageCount Then ' To download x pages per time
                threads.ForEach(Sub(t As Thread) t.Join())
                threads.Clear()
                pagesToJoin = 1
            End If
        Next
    End Sub

    Protected Sub DownloadImage(page As MangaPage)
        Dim filePath As String = Path.Combine(directoryPath.FullName, page.name)
        Try
            Dim wc As WebClient = New WebClient()
            wc.DownloadFile("https://" + page.url, filePath)
        Catch e As Exception
            Throw New MangaDownloadException("link: " + page.url + Environment.NewLine + "filename: " + filePath + Environment.NewLine + "Error: " + e.ToString())
        End Try
    End Sub
End Class
