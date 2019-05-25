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
            Throw New MangaDownloadException([Shared].emptyFieldMsg)
            Return
        End If

        mangaName = manga
        mangaChapter = chapter
        directoryPath = New IO.DirectoryInfo(filename) ' folder name: manganame_cn, file name: manganame_cn_pn

        Dim Str As String = GetBaseURL() + language.ToString() + "-manga/" + manga + "/" + chapter + "/1/"
        Dim stringLinks As String() = GetTextOfImageLinks(GetHTML(Str))

        If stringLinks IsNot Nothing Then
            stringLinks = GetImageLinksInTheText(stringLinks)

            Dim number As Integer = 1
            Dim pages As New List(Of MangaPage)
            For Each link In stringLinks
                Dim page As MangaPage
                page.url = link
                page.name = GetFileName(number.ToString())
                pages.Add(page)
                number += 1
            Next

            DownloadPages(pages)

            Dim name As String = filename + manga + "_c" + chapter
            [Shared].Log = name + " downloaded finished " + Environment.NewLine + [Shared].Log
        Else
            Throw New MangaDownloadException([Shared].errorMsgEden)
        End If

    End Sub

    'Get the line in the html that contains the image links
    Private Function GetTextOfImageLinks(htmlText As String) As String()
        If htmlText Is Nothing Then
            Return Nothing
        End If

        ' TODO: use regex or other fancy method to improve readability
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
        Dim links As New List(Of String)
        For Each line In text
            ' TODO: use regex or other fancy method to improve readability
            If line.Contains("""fs"":") Then
                Dim link As String = line.Substring(line.IndexOf("//") + 2)
                links.Add(link.Replace("""", ""))
            End If
        Next
        Return links.ToArray()
    End Function
End Class
