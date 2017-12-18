<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MangaEdenForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MangaEdenForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLanguage = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.listChapters = New System.Windows.Forms.ListBox()
        Me.btnAddChap = New System.Windows.Forms.Button()
        Me.btnClearChap = New System.Windows.Forms.Button()
        Me.textChapter = New System.Windows.Forms.TextBox()
        Me.btnRemoveChap = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textManga = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnMainMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MangaHostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MangaFoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.textLog = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Language"
        '
        'cbLanguage
        '
        Me.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLanguage.FormattingEnabled = True
        Me.cbLanguage.Items.AddRange(New Object() {"English", "Italian"})
        Me.cbLanguage.Location = New System.Drawing.Point(13, 47)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cbLanguage.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.listChapters)
        Me.GroupBox1.Controls.Add(Me.btnAddChap)
        Me.GroupBox1.Controls.Add(Me.btnClearChap)
        Me.GroupBox1.Controls.Add(Me.textChapter)
        Me.GroupBox1.Controls.Add(Me.btnRemoveChap)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 139)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Chapter"
        '
        'listChapters
        '
        Me.listChapters.FormattingEnabled = True
        Me.listChapters.Location = New System.Drawing.Point(88, 17)
        Me.listChapters.Name = "listChapters"
        Me.listChapters.Size = New System.Drawing.Size(57, 108)
        Me.listChapters.TabIndex = 7
        '
        'btnAddChap
        '
        Me.btnAddChap.Location = New System.Drawing.Point(6, 45)
        Me.btnAddChap.Name = "btnAddChap"
        Me.btnAddChap.Size = New System.Drawing.Size(75, 23)
        Me.btnAddChap.TabIndex = 6
        Me.btnAddChap.Text = "Add"
        Me.btnAddChap.UseVisualStyleBackColor = True
        '
        'btnClearChap
        '
        Me.btnClearChap.Location = New System.Drawing.Point(6, 103)
        Me.btnClearChap.Name = "btnClearChap"
        Me.btnClearChap.Size = New System.Drawing.Size(75, 23)
        Me.btnClearChap.TabIndex = 4
        Me.btnClearChap.Text = "Clear"
        Me.btnClearChap.UseVisualStyleBackColor = True
        '
        'textChapter
        '
        Me.textChapter.Location = New System.Drawing.Point(6, 19)
        Me.textChapter.Name = "textChapter"
        Me.textChapter.Size = New System.Drawing.Size(75, 20)
        Me.textChapter.TabIndex = 0
        '
        'btnRemoveChap
        '
        Me.btnRemoveChap.Location = New System.Drawing.Point(6, 74)
        Me.btnRemoveChap.Name = "btnRemoveChap"
        Me.btnRemoveChap.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveChap.TabIndex = 3
        Me.btnRemoveChap.Text = "Remove"
        Me.btnRemoveChap.UseVisualStyleBackColor = True
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(13, 146)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(121, 23)
        Me.btnDownload.TabIndex = 5
        Me.btnDownload.Text = "Download"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Manga name"
        '
        'textManga
        '
        Me.textManga.Location = New System.Drawing.Point(13, 91)
        Me.textManga.Name = "textManga"
        Me.textManga.Size = New System.Drawing.Size(121, 20)
        Me.textManga.TabIndex = 8
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(13, 117)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(121, 23)
        Me.btnPath.TabIndex = 9
        Me.btnPath.Text = "Set Path"
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DownloaderToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnMainMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReturnMainMenuItem
        '
        Me.ReturnMainMenuItem.Name = "ReturnMainMenuItem"
        Me.ReturnMainMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ReturnMainMenuItem.Text = "Return to main form"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DownloaderToolStripMenuItem
        '
        Me.DownloaderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MangaHostToolStripMenuItem, Me.MangaFoxToolStripMenuItem})
        Me.DownloaderToolStripMenuItem.Name = "DownloaderToolStripMenuItem"
        Me.DownloaderToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.DownloaderToolStripMenuItem.Text = "Downloader"
        '
        'MangaHostToolStripMenuItem
        '
        Me.MangaHostToolStripMenuItem.Name = "MangaHostToolStripMenuItem"
        Me.MangaHostToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MangaHostToolStripMenuItem.Text = "Manga Host"
        '
        'MangaFoxToolStripMenuItem
        '
        Me.MangaFoxToolStripMenuItem.Name = "MangaFoxToolStripMenuItem"
        Me.MangaFoxToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MangaFoxToolStripMenuItem.Text = "MangaFox"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
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
        Me.textLog.TabIndex = 8
        '
        'MangaEdenForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 274)
        Me.Controls.Add(Me.textLog)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.textManga)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbLanguage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MangaEdenForm"
        Me.Text = "HMD - MangaEden Downloader"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbLanguage As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents listChapters As ListBox
    Friend WithEvents btnAddChap As Button
    Friend WithEvents btnClearChap As Button
    Friend WithEvents textChapter As TextBox
    Friend WithEvents btnRemoveChap As Button
    Friend WithEvents btnDownload As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents textManga As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MangaHostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MangaFoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents textLog As TextBox
    Friend WithEvents ReturnMainMenuItem As ToolStripMenuItem
End Class
