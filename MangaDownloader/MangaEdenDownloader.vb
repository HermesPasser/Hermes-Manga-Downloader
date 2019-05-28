Imports System.Text.RegularExpressions

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

        Dim Str As String = GetHTML(GetBaseURL() + language.ToString() + "-manga/" + manga + "/" + chapter + "/1/")
        Dim stringLinks As String() = GetImageLinksInTheText(Str)

        If stringLinks IsNot Nothing Then

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

    ' Get the images url of html text
    Private Function GetImageLinksInTheText(htmlText As String) As String()
        If htmlText Is Nothing Then
            Return Nothing
        End If

        ' to avoid get any image outside of the <script> tag
        Dim pagesJsOjb = Regex.Match(htmlText, "var pages = \[{.+}\]")

        Dim imagePattern As String = "cdn\.mangaeden\.com\/mangasimg\/[a-zA-Z0-9\/]+\.jpg"
        Dim matches As MatchCollection = Regex.Matches(pagesJsOjb.Value, imagePattern)
        Dim lines((matches.Count / 2) - 1) As String

        Dim j = 0
        For i = 0 To matches.Count - 1 Step 2 ' skip one because there's two versions of each page, the original one and the resized
            lines(j) = matches(i).Value
            j += 1
        Next

        Return lines
    End Function
End Class
