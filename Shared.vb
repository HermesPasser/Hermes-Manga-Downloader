Imports System.IO

Public Class [Shared]
    Public Shared appName As String = "Hermes Manga Downloader 0.3"
    Public Shared emptyFieldMsg As String = "There are empty fields, did you complete them?"
    Public Shared errorDefault As String = "This manga is not available, make sure you entered the name and chapter correctly."
    Public Shared errorMsgEden As String = "This manga is not available or is licensed in your region, make sure you entered the name, chapter and language correctly."
    Public Shared Log As String = ""

    Public Shared threadLimitPref As Integer = 5
    Public Shared downloadFolderPref As String

    Private Shared prefsFolder As String
    Private Shared prefsPath As String
    Private Shared initialized As Boolean = False

    Private Shared Sub InitPrefs()
        Dim docsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        prefsFolder = Path.Combine(docsFolder, "HermesPasser", "Hermes-Manga-Downloader")
        prefsPath = Path.Combine(prefsFolder, "prefs.xml")
        downloadFolderPref = Path.Combine(docsFolder, "mangas")
        initialized = True
    End Sub

    Public Shared Sub LoadPrefs()
        If Not initialized Then
            InitPrefs()
        End If

        If Not File.Exists(prefsPath) Then
            SavePrefs()
            Exit Sub
        End If

        Dim root As XElement = XDocument.Load(prefsPath).Root

        Dim intVal As Integer
        If root.Elements("thread-limit").Any AndAlso
                Integer.TryParse(root.Element("thread-limit").Value, intVal) Then
            threadLimitPref = intVal
        End If

        If root.Elements("download-folder").Any Then
            Dim path = root.Element("download-folder").Value

            Dim u As Uri
            If Uri.TryCreate(path, UriKind.Absolute, u) AndAlso
                    u.IsWellFormedOriginalString Then
                downloadFolderPref = path
            End If
        End If
    End Sub

    Public Shared Sub SavePrefs()
        If Not initialized Then
            InitPrefs()
        End If

        Dim prefs As New XElement("prefs",
                        New XElement("thread-limit", threadLimitPref.ToString()),
                        New XElement("download-folder", downloadFolderPref)
                    )
        Directory.CreateDirectory(prefsFolder)
        prefs.Save(prefsPath)
    End Sub
End Class
