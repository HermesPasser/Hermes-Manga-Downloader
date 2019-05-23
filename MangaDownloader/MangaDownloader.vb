Imports System.Net
Imports System.IO
Imports System.Threading

Public MustInherit Class MangaDownloader
    Dim threadLimit = 5
    Protected mangaName As String
    Protected mangaChapter As String
    Protected directoryPath As DirectoryInfo

    Protected MustOverride Function GetBaseURL() As String

    Private Function GetFileName(page As String) As String
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

    Protected Sub DownloadImages(links As String())
        Dim currentPage As Integer = 1
        Dim pagesToJoin As Integer = 1
        Dim pageCount As Integer = links.Count
        Dim threads As New List(Of Thread)

        For Each link In links
            Dim subprocess = Sub()
                                 DownloadImage(link, currentPage.ToString())
                                 'currentPage += 1 ' if this is here, the pages in mangaeden will be normal stating as 1,
                                 'but all the hentai2read will be labeled as 1 And the program will crash
                                 'pagesToJoin += 1
                             End Sub

            ApplicationShared.Log = "Downloading " + link + " as " + GetFileName(currentPage.ToString()) + Environment.NewLine + ApplicationShared.Log
            threads.Add(New Thread(subprocess))
            threads.Last.Start()

            ' if this is here, the pages in mangaeden will be labeled starting as 2, 3... but all the hentai2read will work fine
            currentPage += 1
            pagesToJoin += 1
            If pagesToJoin = threadLimit Or pagesToJoin >= pageCount Then ' To download x pages per time
                threads.ForEach(Sub(t As Thread) t.Join())
                threads.Clear()
                pagesToJoin = 1
            End If
        Next
    End Sub

    Protected Sub DownloadImage(link As String, pageName As String)
        Dim filePath As String = Path.Combine(directoryPath.FullName, GetFileName(pageName))
        Try
            Dim wc As WebClient = New WebClient()
            wc.DownloadFile("https://" + link, filePath)
        Catch e As Exception
            Throw New MangaDownloadException("link: " + link + Environment.NewLine + "filename: " + filePath + Environment.NewLine + "Error: " + e.ToString())
        End Try
    End Sub
End Class
