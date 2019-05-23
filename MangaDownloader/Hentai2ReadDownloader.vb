Public Class Hentai2ReadDownloader
    Inherits MangaDownloader

    Protected Overrides Function GetBaseURL() As String
        Return "http://hentai2read.com/"
    End Function

    Public Sub Download(manga As String, chapter As String, filename As String)
        If manga Is "" Or chapter Is "" Or filename Is "" Then
            Throw New MangaDownloadException(ApplicationShared.emptyFieldMsg)
            Return
        End If

        mangaName = manga
        mangaChapter = chapter
        directoryPath = New IO.DirectoryInfo(filename) ' folder name: manganame_cn, file name: manganame_cn_pn

        Dim str As String = GetHTML(GetBaseURL() + manga + "/" + chapter + "/")
        Dim stringLinks As String() = GetImageLinksInTheText(str)

        If stringLinks IsNot Nothing Then

            DownloadImages(stringLinks)

            Dim name As String = filename + manga + "_c" + chapter
            ApplicationShared.Log = name + " downloaded finished " + Environment.NewLine + ApplicationShared.Log
        Else
            Throw New MangaDownloadException(ApplicationShared.errorDefault)
        End If

    End Sub

    'Get the line in the html that contains the image links
    Private Function GetImageLinksInTheText(htmlText As String) As String()
        If htmlText Is Nothing Then
            Return Nothing
        End If

        ' TODO: Use regex to clean this mess

        If Not htmlText.Contains("var gData") Then
            Return Nothing
        End If

        Dim index As Integer = htmlText.IndexOf("var gData")
        htmlText = htmlText.Substring(index, htmlText.Length - index)

        index = htmlText.IndexOf("[""")
        htmlText = htmlText.Substring(index + 1, htmlText.LastIndexOf("],") - index - 1)
        htmlText = htmlText.Replace("\", "").Replace("""", "")

        Dim links As String() = htmlText.Split(",")

        For i As Integer = 0 To links.Length - 1
            links(i) = "static.hentaicdn.com/hentai/" + links(i)
            links(i) = links(i).Replace("//", "/")
        Next
        Return links
    End Function
End Class
