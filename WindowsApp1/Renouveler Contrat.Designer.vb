<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Renouveler_Contrat
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblNumContratAModifier = New System.Windows.Forms.Label()
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.TxtBoxNumCnt = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.BtnRenouveller = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.CONTRATDataGridView = New System.Windows.Forms.DataGridView()
        Me.Num_Contrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prénom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type_Contrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Equipements = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CONTRATDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblNumContratAModifier)
        Me.GroupBox2.Controls.Add(Me.BtnRechercher)
        Me.GroupBox2.Controls.Add(Me.TxtBoxNumCnt)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 98)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher un contrat en particulier"
        '
        'LblNumContratAModifier
        '
        Me.LblNumContratAModifier.AutoSize = True
        Me.LblNumContratAModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumContratAModifier.Location = New System.Drawing.Point(377, 26)
        Me.LblNumContratAModifier.Name = "LblNumContratAModifier"
        Me.LblNumContratAModifier.Size = New System.Drawing.Size(136, 18)
        Me.LblNumContratAModifier.TabIndex = 21
        Me.LblNumContratAModifier.Text = "Numéro du contrat "
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.Location = New System.Drawing.Point(545, 59)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(117, 23)
        Me.BtnRechercher.TabIndex = 34
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = True
        '
        'TxtBoxNumCnt
        '
        Me.TxtBoxNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNumCnt.Location = New System.Drawing.Point(545, 20)
        Me.TxtBoxNumCnt.Name = "TxtBoxNumCnt"
        Me.TxtBoxNumCnt.Size = New System.Drawing.Size(191, 24)
        Me.TxtBoxNumCnt.TabIndex = 22
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Controls.Add(Me.BtnQuitter)
        Me.GroupBox3.Controls.Add(Me.BtnRenouveller)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 339)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(742, 107)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(545, 34)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(135, 37)
        Me.BtnQuitter.TabIndex = 41
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'BtnRenouveller
        '
        Me.BtnRenouveller.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRenouveller.Location = New System.Drawing.Point(29, 34)
        Me.BtnRenouveller.Name = "BtnRenouveller"
        Me.BtnRenouveller.Size = New System.Drawing.Size(135, 37)
        Me.BtnRenouveller.TabIndex = 41
        Me.BtnRenouveller.Text = "Renouveler"
        Me.BtnRenouveller.UseVisualStyleBackColor = True
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.DodgerBlue
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(187, 4)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(384, 23)
        Me.Titre.TabIndex = 43
        Me.Titre.Text = "La liste des contrats"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CONTRATDataGridView
        '
        Me.CONTRATDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONTRATDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Num_Contrat, Me.Nom, Me.Prénom, Me.Type_Contrat, Me.Equipements, Me.Column1, Me.column2})
        Me.CONTRATDataGridView.Location = New System.Drawing.Point(7, 30)
        Me.CONTRATDataGridView.Name = "CONTRATDataGridView"
        Me.CONTRATDataGridView.Size = New System.Drawing.Size(742, 166)
        Me.CONTRATDataGridView.TabIndex = 42
        '
        'Num_Contrat
        '
        Me.Num_Contrat.HeaderText = "Num_Contrat"
        Me.Num_Contrat.Name = "Num_Contrat"
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        '
        'Prénom
        '
        Me.Prénom.HeaderText = "Prénom"
        Me.Prénom.Name = "Prénom"
        '
        'Type_Contrat
        '
        Me.Type_Contrat.HeaderText = "Type_Contrat"
        Me.Type_Contrat.Name = "Type_Contrat"
        '
        'Equipements
        '
        Me.Equipements.HeaderText = "Equipements"
        Me.Equipements.Name = "Equipements"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Service"
        Me.Column1.Name = "Column1"
        '
        'column2
        '
        Me.column2.HeaderText = "Date de mis en Service "
        Me.column2.Name = "column2"
        '
        'Renouveler_Contrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 444)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.CONTRATDataGridView)
        Me.Name = "Renouveler_Contrat"
        Me.Text = "Renouveler_Contrat"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.CONTRATDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblNumContratAModifier As Label
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents TxtBoxNumCnt As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnRenouveller As Button
    Friend WithEvents Titre As Label
    Friend WithEvents CONTRATDataGridView As DataGridView
    Friend WithEvents Num_Contrat As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Prénom As DataGridViewTextBoxColumn
    Friend WithEvents Type_Contrat As DataGridViewTextBoxColumn
    Friend WithEvents Equipements As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents column2 As DataGridViewTextBoxColumn
End Class
