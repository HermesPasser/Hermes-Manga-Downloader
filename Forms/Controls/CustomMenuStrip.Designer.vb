<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMenuStrip
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnMainMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MangaHostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MangaFoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.DownloaderToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(234, 24)
        Me.MenuStrip1.TabIndex = 11
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
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowOptionsToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ShowOptionsToolStripMenuItem
        '
        Me.ShowOptionsToolStripMenuItem.Name = "ShowOptionsToolStripMenuItem"
        Me.ShowOptionsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.ShowOptionsToolStripMenuItem.Text = "Show Options"
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
        Me.MangaHostToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.MangaHostToolStripMenuItem.Text = "Manga Host"
        '
        'MangaFoxToolStripMenuItem
        '
        Me.MangaFoxToolStripMenuItem.Name = "MangaFoxToolStripMenuItem"
        Me.MangaFoxToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
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
        'CustomMenuStrip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.MenuStrip1)
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Name = "CustomMenuStrip"
        Me.Size = New System.Drawing.Size(234, 24)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnMainMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowOptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MangaHostToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MangaFoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
