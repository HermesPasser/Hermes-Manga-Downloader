<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.mangaEdenButton = New System.Windows.Forms.Button()
        Me.hentai2ReadButton = New System.Windows.Forms.Button()
        Me.aboutButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mangaEdenButton
        '
        Me.mangaEdenButton.Location = New System.Drawing.Point(12, 12)
        Me.mangaEdenButton.Name = "mangaEdenButton"
        Me.mangaEdenButton.Size = New System.Drawing.Size(155, 35)
        Me.mangaEdenButton.TabIndex = 0
        Me.mangaEdenButton.Text = "MangaEden" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(last update: 05-2019)"
        Me.mangaEdenButton.UseVisualStyleBackColor = True
        '
        'hentai2ReadButton
        '
        Me.hentai2ReadButton.Location = New System.Drawing.Point(171, 12)
        Me.hentai2ReadButton.Name = "hentai2ReadButton"
        Me.hentai2ReadButton.Size = New System.Drawing.Size(155, 35)
        Me.hentai2ReadButton.TabIndex = 1
        Me.hentai2ReadButton.Text = "Hentai2Read" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(last update: 05-2019)"
        Me.hentai2ReadButton.UseVisualStyleBackColor = True
        '
        'aboutButton
        '
        Me.aboutButton.Location = New System.Drawing.Point(12, 53)
        Me.aboutButton.Name = "aboutButton"
        Me.aboutButton.Size = New System.Drawing.Size(314, 23)
        Me.aboutButton.TabIndex = 2
        Me.aboutButton.Text = "About"
        Me.aboutButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(12, 82)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(314, 23)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fields such as name, chapter and volume must be filled in the same way as the pag" &
    "e link."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(13, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(301, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "e.g. mangareader.com/manga_name/volume00number/c1Num/"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 164)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.aboutButton)
        Me.Controls.Add(Me.hentai2ReadButton)
        Me.Controls.Add(Me.mangaEdenButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Hermes Manga Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mangaEdenButton As Button
    Friend WithEvents hentai2ReadButton As Button
    Friend WithEvents aboutButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
