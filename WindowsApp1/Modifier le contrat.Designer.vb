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
        Me.BtnModifier = New System.Windows.Forms.Button()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GBoxRecherche.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBoxRecherche
        '
        Me.GBoxRecherche.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
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
        'BtnModifier
        '
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnModifier.Location = New System.Drawing.Point(291, 466)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(81, 62)
        Me.BtnModifier.TabIndex = 48
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LblMDMService)
        Me.GroupBox1.Controls.Add(Me.LblMTCnt)
        Me.GroupBox1.Controls.Add(Me.LblMService)
        Me.GroupBox1.Controls.Add(Me.LblMLocation)
        Me.GroupBox1.Controls.Add(Me.LblMDO)
        Me.GroupBox1.Controls.Add(Me.LblMDF)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(349, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 345)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'TBoxMService
        '
        Me.TBoxMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMService.Location = New System.Drawing.Point(185, 136)
        Me.TBoxMService.Name = "TBoxMService"
        Me.TBoxMService.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMService.TabIndex = 40
        '
        'LblMNC
        '
        Me.LblMNC.BackColor = System.Drawing.Color.White
        Me.LblMNC.Enabled = False
        Me.LblMNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMNC.Location = New System.Drawing.Point(52, 187)
        Me.LblMNC.Name = "LblMNC"
        Me.LblMNC.Size = New System.Drawing.Size(126, 26)
        Me.LblMNC.TabIndex = 42
        '
        'TBoxMLocation
        '
        Me.TBoxMLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMLocation.Location = New System.Drawing.Point(41, 218)
        Me.TBoxMLocation.Name = "TBoxMLocation"
        Me.TBoxMLocation.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMLocation.TabIndex = 39
        '
        'LblMDMService
        '
        Me.LblMDMService.AutoSize = True
        Me.LblMDMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDMService.Location = New System.Drawing.Point(306, 203)
        Me.LblMDMService.Name = "LblMDMService"
        Me.LblMDMService.Size = New System.Drawing.Size(174, 18)
        Me.LblMDMService.TabIndex = 29
        Me.LblMDMService.Text = "Date de mise en vigueur :"
        '
        'TBoxMDMV
        '
        Me.TBoxMDMV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDMV.Location = New System.Drawing.Point(185, 218)
        Me.TBoxMDMV.Name = "TBoxMDMV"
        Me.TBoxMDMV.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMDMV.TabIndex = 41
        '
        'TBoxMDF
        '
        Me.TBoxMDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDF.Location = New System.Drawing.Point(185, 263)
        Me.TBoxMDF.Name = "TBoxMDF"
        Me.TBoxMDF.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMDF.TabIndex = 38
        '
        'LblMTCnt
        '
        Me.LblMTCnt.AutoSize = True
        Me.LblMTCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMTCnt.Location = New System.Drawing.Point(306, 232)
        Me.LblMTCnt.Name = "LblMTCnt"
        Me.LblMTCnt.Size = New System.Drawing.Size(118, 18)
        Me.LblMTCnt.TabIndex = 24
        Me.LblMTCnt.Text = "Type de contrat :"
        '
        'LblMService
        '
        Me.LblMService.AutoSize = True
        Me.LblMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMService.Location = New System.Drawing.Point(306, 176)
        Me.LblMService.Name = "LblMService"
        Me.LblMService.Size = New System.Drawing.Size(65, 18)
        Me.LblMService.TabIndex = 28
        Me.LblMService.Text = "Service :"
        '
        'TBoxMDO
        '
        Me.TBoxMDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDO.Location = New System.Drawing.Point(12, 260)
        Me.TBoxMDO.Name = "TBoxMDO"
        Me.TBoxMDO.Size = New System.Drawing.Size(166, 24)
        Me.TBoxMDO.TabIndex = 37
        '
        'TBoxMTCnt
        '
        Me.TBoxMTCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMTCnt.Location = New System.Drawing.Point(185, 304)
        Me.TBoxMTCnt.Name = "TBoxMTCnt"
        Me.TBoxMTCnt.Size = New System.Drawing.Size(149, 24)
        Me.TBoxMTCnt.TabIndex = 36
        '
        'LblMNumCnt
        '
        Me.LblMNumCnt.AutoSize = True
        Me.LblMNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMNumCnt.Location = New System.Drawing.Point(9, 136)
        Me.LblMNumCnt.Name = "LblMNumCnt"
        Me.LblMNumCnt.Size = New System.Drawing.Size(135, 18)
        Me.LblMNumCnt.TabIndex = 23
        Me.LblMNumCnt.Text = "Numéro du Contrat"
        '
        'LblMLocation
        '
        Me.LblMLocation.AutoSize = True
        Me.LblMLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMLocation.Location = New System.Drawing.Point(248, 155)
        Me.LblMLocation.Name = "LblMLocation"
        Me.LblMLocation.Size = New System.Drawing.Size(153, 18)
        Me.LblMLocation.TabIndex = 27
        Me.LblMLocation.Text = "Location équipement :"
        '
        'LblMDO
        '
        Me.LblMDO.AutoSize = True
        Me.LblMDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDO.Location = New System.Drawing.Point(306, 262)
        Me.LblMDO.Name = "LblMDO"
        Me.LblMDO.Size = New System.Drawing.Size(124, 18)
        Me.LblMDO.TabIndex = 25
        Me.LblMDO.Text = "Date d'ouverture :"
        '
        'LblMDF
        '
        Me.LblMDF.AutoSize = True
        Me.LblMDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDF.Location = New System.Drawing.Point(290, 303)
        Me.LblMDF.Name = "LblMDF"
        Me.LblMDF.Size = New System.Drawing.Size(134, 18)
        Me.LblMDF.TabIndex = 26
        Me.LblMDF.Text = "Date de fermeture :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 489)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Résultat de la recherche"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(2, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(341, 286)
        Me.DataGridView1.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(21, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nom"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 579)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBoxMService)
        Me.Controls.Add(Me.TBoxMDF)
        Me.Controls.Add(Me.TBoxMDMV)
        Me.Controls.Add(Me.LblMNumCnt)
        Me.Controls.Add(Me.TBoxMTCnt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TBoxMLocation)
        Me.Controls.Add(Me.TBoxMDO)
        Me.Controls.Add(Me.LblMNC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBoxRecherche)
        Me.Controls.Add(Me.BtnMQuitter)
        Me.Controls.Add(Me.BtnMNSearch)
        Me.Controls.Add(Me.BtnModifier)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBoxRecherche.ResumeLayout(False)
        Me.GBoxRecherche.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBoxRecherche As GroupBox
    Friend WithEvents LblNumContratAModifier As Label
    Friend WithEvents LblMessage As Label
    Friend WithEvents TxtBoxNumCnt As TextBox
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents BtnMQuitter As Button
    Friend WithEvents BtnMNSearch As Button
    Friend WithEvents BtnModifier As Button
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
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
End Class
