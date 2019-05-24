<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsForm))
        Me.UpDownThreadLimit = New System.Windows.Forms.Label()
        Me.numUpDownThreadLimit = New System.Windows.Forms.NumericUpDown()
        CType(Me.numUpDownThreadLimit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpDownThreadLimit
        '
        Me.UpDownThreadLimit.AutoSize = True
        Me.UpDownThreadLimit.Location = New System.Drawing.Point(12, 11)
        Me.UpDownThreadLimit.Name = "UpDownThreadLimit"
        Me.UpDownThreadLimit.Size = New System.Drawing.Size(61, 13)
        Me.UpDownThreadLimit.TabIndex = 1
        Me.UpDownThreadLimit.Text = "Thread limit"
        '
        'numUpDownThreadLimit
        '
        Me.numUpDownThreadLimit.Location = New System.Drawing.Point(79, 9)
        Me.numUpDownThreadLimit.Name = "numUpDownThreadLimit"
        Me.numUpDownThreadLimit.Size = New System.Drawing.Size(120, 20)
        Me.numUpDownThreadLimit.TabIndex = 2
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 39)
        Me.Controls.Add(Me.numUpDownThreadLimit)
        Me.Controls.Add(Me.UpDownThreadLimit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsForm"
        Me.Text = "Options"
        CType(Me.numUpDownThreadLimit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpDownThreadLimit As Label
    Friend WithEvents numUpDownThreadLimit As NumericUpDown
End Class
