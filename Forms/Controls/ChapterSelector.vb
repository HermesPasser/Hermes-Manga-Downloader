Imports System.Text.RegularExpressions

Public Class ChapterSelector
    Public TextPattern As String

    Public Property Chapters() As String()
        Get
            Dim list = From item In ChapterListBox.Items() Select (item.ToString())
            Return list.ToArray()
        End Get
        Private Set()
        End Set
    End Property

    Private Sub RemoveSelectedIndex()
        ChapterListBox.Items.Remove(ChapterListBox.SelectedItem)
    End Sub

    Private Function InputIsValid() As Boolean
        If TextPattern IsNot Nothing Then
            If Regex.IsMatch(ChapterTextBox.Text, TextPattern) Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If Not String.IsNullOrEmpty(ChapterTextBox.Text) AndAlso
                Not ChapterListBox.Items.Contains(ChapterTextBox.Text) AndAlso
                InputIsValid() Then
            ChapterListBox.Items.Add(ChapterTextBox.Text)
            ChapterTextBox.Text = ""
        Else
            Media.SystemSounds.Hand.Play()
        End If
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        RemoveSelectedIndex()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ChapterListBox.Items.Clear()
    End Sub

    Private Sub ChapterListBox_KeyDown(sender As Object, e As KeyEventArgs) Handles ChapterListBox.KeyDown
        If e.KeyData = Keys.Delete Then
            RemoveSelectedIndex()
        End If
    End Sub
End Class
