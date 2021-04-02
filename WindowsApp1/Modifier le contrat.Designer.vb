<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBoxRecherche = New System.Windows.Forms.GroupBox()
        Me.LblNumContratAModifier = New System.Windows.Forms.Label()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.TxtBoxNumCnt = New System.Windows.Forms.TextBox()
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.BtnMQuitter = New System.Windows.Forms.Button()
        Me.BtnMNSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBoxMService = New System.Windows.Forms.TextBox()
        Me.LblMNC = New System.Windows.Forms.Label()
        Me.TBoxMLocation = New System.Windows.Forms.TextBox()
        Me.LblMDMService = New System.Windows.Forms.Label()
        Me.TBoxMDMV = New System.Windows.Forms.TextBox()
        Me.TBoxMDF = New System.Windows.Forms.TextBox()
        Me.LblMTCnt = New System.Windows.Forms.Label()
        Me.LblMService = New System.Windows.Forms.Label()
        Me.TBoxMDO = New System.Windows.Forms.TextBox()
        Me.TBoxMTCnt = New System.Windows.Forms.TextBox()
        Me.LblMNumCnt = New System.Windows.Forms.Label()
        Me.LblMLocation = New System.Windows.Forms.Label()
        Me.LblMDO = New System.Windows.Forms.Label()
        Me.LblMDF = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GBoxRecherche.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBoxRecherche
        '
        Me.GBoxRecherche.BackColor = System.Drawing.Color.LightGray
        Me.GBoxRecherche.Controls.Add(Me.LblNumContratAModifier)
        Me.GBoxRecherche.Controls.Add(Me.LblMessage)
        Me.GBoxRecherche.Controls.Add(Me.TxtBoxNumCnt)
        Me.GBoxRecherche.Controls.Add(Me.BtnRechercher)
        Me.GBoxRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxRecherche.Location = New System.Drawing.Point(2, -27)
        Me.GBoxRecherche.Name = "GBoxRecherche"
        Me.GBoxRecherche.Size = New System.Drawing.Size(796, 103)
        Me.GBoxRecherche.TabIndex = 51
        Me.GBoxRecherche.TabStop = False
        Me.GBoxRecherche.Text = "Recherche du contrat"
        '
        'LblNumContratAModifier
        '
        Me.LblNumContratAModifier.AutoSize = True
        Me.LblNumContratAModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumContratAModifier.Location = New System.Drawing.Point(405, 43)
        Me.LblNumContratAModifier.Name = "LblNumContratAModifier"
        Me.LblNumContratAModifier.Size = New System.Drawing.Size(136, 18)
        Me.LblNumContratAModifier.TabIndex = 21
        Me.LblNumContratAModifier.Text = "Numéro du contrat "
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.Location = New System.Drawing.Point(303, 101)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(0, 13)
        Me.LblMessage.TabIndex = 44
        '
        'TxtBoxNumCnt
        '
        Me.TxtBoxNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNumCnt.Location = New System.Drawing.Point(605, 37)
        Me.TxtBoxNumCnt.Name = "TxtBoxNumCnt"
        Me.TxtBoxNumCnt.Size = New System.Drawing.Size(191, 24)
        Me.TxtBoxNumCnt.TabIndex = 22
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.Location = New System.Drawing.Point(605, 78)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(117, 23)
        Me.BtnRechercher.TabIndex = 34
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = True
        '
        'BtnMQuitter
        '
        Me.BtnMQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMQuitter.Location = New System.Drawing.Point(552, 668)
        Me.BtnMQuitter.Name = "BtnMQuitter"
        Me.BtnMQuitter.Size = New System.Drawing.Size(81, 51)
        Me.BtnMQuitter.TabIndex = 50
        Me.BtnMQuitter.Text = "Quitter"
        Me.BtnMQuitter.UseVisualStyleBackColor = True
        '
        'BtnMNSearch
        '
        Me.BtnMNSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMNSearch.Location = New System.Drawing.Point(552, 522)
        Me.BtnMNSearch.Name = "BtnMNSearch"
        Me.BtnMNSearch.Size = New System.Drawing.Size(81, 58)
        Me.BtnMNSearch.TabIndex = 49
        Me.BtnMNSearch.Text = "Nouvelle Recherche"
        Me.BtnMNSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBoxMService)
        Me.GroupBox1.Controls.Add(Me.LblMNC)
        Me.GroupBox1.Controls.Add(Me.TBoxMLocation)
        Me.GroupBox1.Controls.Add(Me.LblMDMService)
        Me.GroupBox1.Controls.Add(Me.TBoxMDMV)
        Me.GroupBox1.Controls.Add(Me.TBoxMDF)
        Me.GroupBox1.Controls.Add(Me.LblMTCnt)
        Me.GroupBox1.Controls.Add(Me.LblMService)
        Me.GroupBox1.Controls.Add(Me.TBoxMDO)
        Me.GroupBox1.Controls.Add(Me.TBoxMTCnt)
        Me.GroupBox1.Controls.Add(Me.LblMNumCnt)
        Me.GroupBox1.Controls.Add(Me.LblMLocation)
        Me.GroupBox1.Controls.Add(Me.LblMDO)
        Me.GroupBox1.Controls.Add(Me.LblMDF)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(2, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 297)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Résultat de la recherche et Mise à jour"
        '
        'TBoxMService
        '
        Me.TBoxMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMService.Location = New System.Drawing.Point(530, 203)
        Me.TBoxMService.Name = "TBoxMService"
        Me.TBoxMService.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMService.TabIndex = 40
        '
        'LblMNC
        '
        Me.LblMNC.BackColor = System.Drawing.Color.White
        Me.LblMNC.Enabled = False
        Me.LblMNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMNC.Location = New System.Drawing.Point(405, 41)
        Me.LblMNC.Name = "LblMNC"
        Me.LblMNC.Size = New System.Drawing.Size(126, 26)
        Me.LblMNC.TabIndex = 42
        '
        'TBoxMLocation
        '
        Me.TBoxMLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMLocation.Location = New System.Drawing.Point(530, 150)
        Me.TBoxMLocation.Name = "TBoxMLocation"
        Me.TBoxMLocation.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMLocation.TabIndex = 39
        '
        'LblMDMService
        '
        Me.LblMDMService.AutoSize = True
        Me.LblMDMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDMService.Location = New System.Drawing.Point(350, 252)
        Me.LblMDMService.Name = "LblMDMService"
        Me.LblMDMService.Size = New System.Drawing.Size(170, 18)
        Me.LblMDMService.TabIndex = 29
        Me.LblMDMService.Text = "Date de mise en vigueur "
        '
        'TBoxMDMV
        '
        Me.TBoxMDMV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDMV.Location = New System.Drawing.Point(530, 252)
        Me.TBoxMDMV.Name = "TBoxMDMV"
        Me.TBoxMDMV.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMDMV.TabIndex = 41
        '
        'TBoxMDF
        '
        Me.TBoxMDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDF.Location = New System.Drawing.Point(160, 249)
        Me.TBoxMDF.Name = "TBoxMDF"
        Me.TBoxMDF.Size = New System.Drawing.Size(166, 24)
        Me.TBoxMDF.TabIndex = 38
        '
        'LblMTCnt
        '
        Me.LblMTCnt.AutoSize = True
        Me.LblMTCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMTCnt.Location = New System.Drawing.Point(7, 156)
        Me.LblMTCnt.Name = "LblMTCnt"
        Me.LblMTCnt.Size = New System.Drawing.Size(114, 18)
        Me.LblMTCnt.TabIndex = 24
        Me.LblMTCnt.Text = "Type de contrat "
        '
        'LblMService
        '
        Me.LblMService.AutoSize = True
        Me.LblMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMService.Location = New System.Drawing.Point(350, 206)
        Me.LblMService.Name = "LblMService"
        Me.LblMService.Size = New System.Drawing.Size(61, 18)
        Me.LblMService.TabIndex = 28
        Me.LblMService.Text = "Service "
        '
        'TBoxMDO
        '
        Me.TBoxMDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDO.Location = New System.Drawing.Point(160, 203)
        Me.TBoxMDO.Name = "TBoxMDO"
        Me.TBoxMDO.Size = New System.Drawing.Size(166, 24)
        Me.TBoxMDO.TabIndex = 37
        '
        'TBoxMTCnt
        '
        Me.TBoxMTCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMTCnt.Location = New System.Drawing.Point(160, 156)
        Me.TBoxMTCnt.Name = "TBoxMTCnt"
        Me.TBoxMTCnt.Size = New System.Drawing.Size(166, 24)
        Me.TBoxMTCnt.TabIndex = 36
        '
        'LblMNumCnt
        '
        Me.LblMNumCnt.AutoSize = True
        Me.LblMNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMNumCnt.Location = New System.Drawing.Point(248, 49)
        Me.LblMNumCnt.Name = "LblMNumCnt"
        Me.LblMNumCnt.Size = New System.Drawing.Size(135, 18)
        Me.LblMNumCnt.TabIndex = 23
        Me.LblMNumCnt.Text = "Numéro du Contrat"
        '
        'LblMLocation
        '
        Me.LblMLocation.AutoSize = True
        Me.LblMLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMLocation.Location = New System.Drawing.Point(350, 156)
        Me.LblMLocation.Name = "LblMLocation"
        Me.LblMLocation.Size = New System.Drawing.Size(149, 18)
        Me.LblMLocation.TabIndex = 27
        Me.LblMLocation.Text = "Location équipement "
        '
        'LblMDO
        '
        Me.LblMDO.AutoSize = True
        Me.LblMDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDO.Location = New System.Drawing.Point(7, 206)
        Me.LblMDO.Name = "LblMDO"
        Me.LblMDO.Size = New System.Drawing.Size(120, 18)
        Me.LblMDO.TabIndex = 25
        Me.LblMDO.Text = "Date d'ouverture "
        '
        'LblMDF
        '
        Me.LblMDF.AutoSize = True
        Me.LblMDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDF.Location = New System.Drawing.Point(6, 252)
        Me.LblMDF.Name = "LblMDF"
        Me.LblMDF.Size = New System.Drawing.Size(130, 18)
        Me.LblMDF.TabIndex = 26
        Me.LblMDF.Text = "Date de fermeture "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnModifier)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 417)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(796, 88)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        '
        'BtnModifier
        '
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.Location = New System.Drawing.Point(353, 19)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(81, 54)
        Me.BtnModifier.TabIndex = 32
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(50, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 50)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Nouvelle Recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(679, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(81, 54)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Quitter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 18)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Prénom "
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(160, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 24)
        Me.TextBox1.TabIndex = 45
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(530, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 24)
        Me.TextBox2.TabIndex = 46
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 579)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBoxRecherche)
        Me.Controls.Add(Me.BtnMQuitter)
        Me.Controls.Add(Me.BtnMNSearch)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBoxRecherche.ResumeLayout(False)
        Me.GBoxRecherche.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBoxRecherche As GroupBox
    Friend WithEvents LblNumContratAModifier As Label
    Friend WithEvents LblMessage As Label
    Friend WithEvents TxtBoxNumCnt As TextBox
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents BtnMQuitter As Button
    Friend WithEvents BtnMNSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBoxMService As TextBox
    Friend WithEvents LblMNC As Label
    Friend WithEvents TBoxMLocation As TextBox
    Friend WithEvents LblMDMService As Label
    Friend WithEvents TBoxMDMV As TextBox
    Friend WithEvents TBoxMDF As TextBox
    Friend WithEvents LblMTCnt As Label
    Friend WithEvents LblMService As Label
    Friend WithEvents TBoxMDO As TextBox
    Friend WithEvents TBoxMTCnt As TextBox
    Friend WithEvents LblMNumCnt As Label
    Friend WithEvents LblMLocation As Label
    Friend WithEvents LblMDO As Label
    Friend WithEvents LblMDF As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
