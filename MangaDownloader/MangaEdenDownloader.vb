Public Class MangaEdenDownloader
    Inherits MangaDownloader

    Public Enum Language
        en
        it
    End Enum

    Protected Overrides Function GetBaseURL() As String
        Return "http://www.mangaeden.com/en/"
    End Function

    Public Sub Download(language As Language, manga As String, chapter As String, filename As String)
        If manga Is "" Or chapter Is "" Or filename Is "" Then
            Throw New MangaDownloadException(ApplicationShared.emptyFieldMsg)
            Return
        End If

        Dim str As String = GetBaseURL() + language.ToString() + "-manga/" + manga + "/" + chapter + "/1/"
        Dim t As String() = GetTextOfImageLinks(GetHTML(str))

        If t IsNot Nothing Then
            Dim name As String = filename + manga + "_c" + chapter
            t = GetImageLinksInTheText(t)
            DownloadImages(t, name)
            ApplicationShared.Log = name + " downloaded finished " + Environment.NewLine + ApplicationShared.Log
        Else
            Throw New MangaDownloadException(ApplicationShared.errorMsgEden)
        End If

    End Sub

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
End Class
