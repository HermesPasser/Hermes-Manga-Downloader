Public Class MangaDownloadException
    Inherits Exception
    Public page As MangaPage
    Public Sub New(ByVal message As String, Optional ByVal page As MangaPage = Nothing)
        MyBase.New(message)
        Me.page = page
    End Sub
End Class
