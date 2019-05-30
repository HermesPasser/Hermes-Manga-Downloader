<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MangaKakalotForm
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.textLog = New System.Windows.Forms.TextBox()
        Me.textManga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CustomMenuStrip1 = New HermesMangaDownloader.CustomMenuStrip()
        Me.ChapterSelector1 = New HermesMangaDownloader.ChapterSelector()
        Me.SuspendLayout()
        '
        'textLog
        '
        Me.textLog.BackColor = System.Drawing.SystemColors.ControlLight
        Me.textLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textLog.Location = New System.Drawing.Point(12, 175)
        Me.textLog.Multiline = True
        Me.textLog.Name = "textLog"
        Me.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textLog.Size = New System.Drawing.Size(280, 86)
        Me.textLog.TabIndex = 5
        '
        'textManga
        '
        Me.textManga.Location = New System.Drawing.Point(12, 51)
        Me.textManga.Name = "textManga"
        Me.textManga.Size = New System.Drawing.Size(121, 20)
        Me.textManga.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Manga name"
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(12, 77)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(121, 23)
        Me.btnDownload.TabIndex = 8
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        '
        'CustomMenuStrip1
        '
        Me.CustomMenuStrip1.AutoSize = True
        Me.CustomMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CustomMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CustomMenuStrip1.Name = "CustomMenuStrip1"
        Me.CustomMenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.CustomMenuStrip1.TabIndex = 10
        '
        'ChapterSelector1
        '
        Me.ChapterSelector1.Location = New System.Drawing.Point(140, 30)
        Me.ChapterSelector1.Name = "ChapterSelector1"
        Me.ChapterSelector1.Size = New System.Drawing.Size(158, 143)
        Me.ChapterSelector1.TabIndex = 0
        '
        'MangaKakalotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 274)
        Me.Controls.Add(Me.CustomMenuStrip1)
        Me.Controls.Add(Me.textManga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.textLog)
        Me.Controls.Add(Me.ChapterSelector1)
        Me.Name = "MangaKakalotForm"
        Me.Text = "MangaKakalotForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChapterSelector1 As ChapterSelector
    Friend WithEvents textLog As TextBox
    Friend WithEvents textManga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CustomMenuStrip1 As CustomMenuStrip
End Class
