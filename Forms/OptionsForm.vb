
Public Class OptionsForm
    Public MotherForm As Form
    Private threadLimit As Integer = -1
    Private dialog As FolderBrowserDialog

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dialog = New FolderBrowserDialog With {
            .SelectedPath = [Shared].downloadFolderPref
        }
        numUpDownThreadLimit.Minimum = 1
        numUpDownThreadLimit.Maximum = 1000
        threadLimit = [Shared].threadLimitPref
    End Sub

    Private Sub NumUpDownThreadLimit_ValueChanged(sender As Object, e As EventArgs) Handles numUpDownThreadLimit.ValueChanged
        If threadLimit = -1 Then
            numUpDownThreadLimit.Value = [Shared].threadLimitPref
        Else
            [Shared].threadLimitPref = numUpDownThreadLimit.Value
            threadLimit = [Shared].threadLimitPref
        End If
    End Sub

    Private Sub Options_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MotherForm.Enabled = True
        [Shared].SavePrefs()
    End Sub

    Private Sub btnPath_Click(sender As Object, e As EventArgs) Handles btnPath.Click
        If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            [Shared].downloadFolderPref = dialog.SelectedPath
        End If
    End Sub
End Class