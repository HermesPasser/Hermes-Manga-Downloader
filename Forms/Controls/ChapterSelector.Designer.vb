<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChapterSelector
    Inherits System.Windows.Forms.UserControl

    'O UserControl substitui o descarte para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChapterListBox = New System.Windows.Forms.ListBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ChapterTextBox = New System.Windows.Forms.TextBox()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChapterListBox)
        Me.GroupBox1.Controls.Add(Me.AddButton)
        Me.GroupBox1.Controls.Add(Me.ClearButton)
        Me.GroupBox1.Controls.Add(Me.ChapterTextBox)
        Me.GroupBox1.Controls.Add(Me.RemoveButton)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 139)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chapter"
        '
        'ChapterListBox
        '
        Me.ChapterListBox.FormattingEnabled = True
        Me.ChapterListBox.Location = New System.Drawing.Point(88, 17)
        Me.ChapterListBox.Name = "ChapterListBox"
        Me.ChapterListBox.Size = New System.Drawing.Size(57, 108)
        Me.ChapterListBox.TabIndex = 4
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(6, 45)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(6, 103)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ChapterTextBox
        '
        Me.ChapterTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ChapterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChapterTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ChapterTextBox.Location = New System.Drawing.Point(6, 19)
        Me.ChapterTextBox.Name = "ChapterTextBox"
        Me.ChapterTextBox.Size = New System.Drawing.Size(75, 20)
        Me.ChapterTextBox.TabIndex = 0
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(6, 74)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(75, 23)
        Me.RemoveButton.TabIndex = 2
        Me.RemoveButton.Text = "Remove"
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ChapterSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ChapterSelector"
        Me.Size = New System.Drawing.Size(153, 139)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChapterListBox As ListBox
    Friend WithEvents AddButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ChapterTextBox As TextBox
    Friend WithEvents RemoveButton As Button
End Class
