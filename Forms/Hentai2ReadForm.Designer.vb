<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hentai2ReadForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hentai2ReadForm))
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textManga = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.textLog = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ChapterSelector1 = New HermesMangaDownloader.ChapterSelector()
        Me.CustomMenuStrip1 = New HermesMangaDownloader.CustomMenuStrip()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(12, 75)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(121, 23)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Manga name"
        '
        'textManga
        '
        Me.textManga.Location = New System.Drawing.Point(12, 49)
        Me.textManga.Name = "textManga"
        Me.textManga.Size = New System.Drawing.Size(121, 20)
        Me.textManga.TabIndex = 0
        '
        'Timer1
        '
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
        Me.textLog.TabIndex = 4
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'ChapterSelector1
        '
        Me.ChapterSelector1.Location = New System.Drawing.Point(140, 30)
        Me.ChapterSelector1.Name = "ChapterSelector1"
        Me.ChapterSelector1.Size = New System.Drawing.Size(155, 145)
        Me.ChapterSelector1.TabIndex = 7
        '
        'CustomMenuStrip1
        '
        Me.CustomMenuStrip1.AutoSize = True
        Me.CustomMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CustomMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CustomMenuStrip1.Name = "CustomMenuStrip1"
        Me.CustomMenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.CustomMenuStrip1.TabIndex = 8
        '
        'Hentai2ReadForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 274)
        Me.Controls.Add(Me.CustomMenuStrip1)
        Me.Controls.Add(Me.ChapterSelector1)
        Me.Controls.Add(Me.textLog)
        Me.Controls.Add(Me.textManga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDownload)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Hentai2ReadForm"
        Me.Text = "HMD - Hentai2Read Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDownload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents textManga As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents textLog As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ChapterSelector1 As ChapterSelector
    Friend WithEvents CustomMenuStrip1 As CustomMenuStrip
End Class
