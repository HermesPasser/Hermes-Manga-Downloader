
Public Class OptionsForm
    Public MotherForm As Form
    Private threadLimit As Integer = -1

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numUpDownThreadLimit.Minimum = 1
        numUpDownThreadLimit.Maximum = 1000
        threadLimit = ApplicationShared.ThreadLimitOption
    End Sub

    Private Sub NumUpDownThreadLimit_ValueChanged(sender As Object, e As EventArgs) Handles numUpDownThreadLimit.ValueChanged

        If threadLimit = -1 Then
            numUpDownThreadLimit.Value = ApplicationShared.ThreadLimitOption
        Else
            ApplicationShared.ThreadLimitOption = numUpDownThreadLimit.Value
            threadLimit = ApplicationShared.ThreadLimitOption
        End If
    End Sub

    Private Sub Options_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MotherForm.Enabled = True
    End Sub
End Class