Imports System.Text.RegularExpressions

Public Class MangaKakalotDownloader
    Inherits MangaDownloader

    Protected Overrides Function GetBaseURL() As String
        Return "http://mangakakalot.com/chapter/"
    End Function

    Public Sub Download(manga As String, chapter As String, filename As String)
        If manga Is "" Or chapter Is "" Or filename Is "" Then
            Throw New MangaDownloadException([Shared].emptyFieldMsg)
            Return
        End If

        mangaName = manga
        mangaChapter = chapter
        directoryPath = New IO.DirectoryInfo(filename) ' folder name: manganame_cn, file name: manganame_cn_pn

        Dim str As String = GetHTML(GetBaseURL() + manga + "/" + chapter + "/")
        Dim stringLinks As String() = GetImageLinksInTheText(str)

        If stringLinks IsNot Nothing Then

            Dim number As Integer = 1
            Dim pages As New List(Of MangaPage)

            For Each link In stringLinks
                Dim page As MangaPage
                page.url = link
                ' TODO: format pages number to have a 01 if the last one is 10
                page.name = GetFileName(number.ToString())
                pages.Add(page)
                number += 1
            Next
            DownloadPages(pages)

            Dim name As String = filename + manga + "_c" + chapter
            [Shared].Log = name + " downloaded finished " + Environment.NewLine + [Shared].Log
        Else
            Throw New MangaDownloadException([Shared].errorDefault)
        End If

    End Sub

    Private Function GetImageLinksInTheText(htmlText As String) As String()
        If htmlText Is Nothing Then
            Return Nothing
        End If

        Dim pattern As String = "https:\/\/\w\d+.[a-zA-Z0-9]+.com\/mangakakalot\/\w\d+\/[a-zA-Z0-9_]+\/[a-zA-Z0-9_]+\/\d+.jpg"
        Dim matches As MatchCollection = Regex.Matches(htmlText, pattern)
        Dim links(matches.Count - 1) As String

        For i = 0 To matches.Count - 1
            links(i) = matches(i).Value
        Next
        Return links
    End Function
End Class
