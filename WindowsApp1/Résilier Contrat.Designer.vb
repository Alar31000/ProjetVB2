<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Résilier_Contrat
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
        Me.Titre = New System.Windows.Forms.Label()
        Me.BtnResilier = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxNumCnt = New System.Windows.Forms.TextBox()
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.LblNumContratAModifier = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CONTRATDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CONTRATDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.DodgerBlue
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(185, 11)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(384, 23)
        Me.Titre.TabIndex = 39
        Me.Titre.Text = "La liste des contrats"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnResilier
        '
        Me.BtnResilier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResilier.Location = New System.Drawing.Point(59, 34)
        Me.BtnResilier.Name = "BtnResilier"
        Me.BtnResilier.Size = New System.Drawing.Size(135, 37)
        Me.BtnResilier.TabIndex = 41
        Me.BtnResilier.Text = "Résilier"
        Me.BtnResilier.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(545, 34)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(120, 37)
        Me.BtnQuitter.TabIndex = 41
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.BtnQuitter)
        Me.GroupBox1.Controls.Add(Me.BtnResilier)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 359)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 94)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'TxtBoxNumCnt
        '
        Me.TxtBoxNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNumCnt.Location = New System.Drawing.Point(545, 20)
        Me.TxtBoxNumCnt.Name = "TxtBoxNumCnt"
        Me.TxtBoxNumCnt.Size = New System.Drawing.Size(191, 24)
        Me.TxtBoxNumCnt.TabIndex = 22
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.Location = New System.Drawing.Point(545, 58)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(117, 23)
        Me.BtnRechercher.TabIndex = 34
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = True
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblNumContratAModifier)
        Me.GroupBox2.Controls.Add(Me.BtnRechercher)
        Me.GroupBox2.Controls.Add(Me.TxtBoxNumCnt)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 98)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher un contrat en particulier"
        '
        'CONTRATDataGridView
        '
        Me.CONTRATDataGridView.AllowUserToAddRows = False
        Me.CONTRATDataGridView.AllowUserToDeleteRows = False
        Me.CONTRATDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONTRATDataGridView.Location = New System.Drawing.Point(7, 37)
        Me.CONTRATDataGridView.MultiSelect = False
        Me.CONTRATDataGridView.Name = "CONTRATDataGridView"
        Me.CONTRATDataGridView.ReadOnly = True
        Me.CONTRATDataGridView.RowHeadersWidth = 51
        Me.CONTRATDataGridView.ShowEditingIcon = False
        Me.CONTRATDataGridView.Size = New System.Drawing.Size(728, 185)
        Me.CONTRATDataGridView.TabIndex = 47
        '
        'Résilier_Contrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 450)
        Me.Controls.Add(Me.CONTRATDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Titre)
        Me.Name = "Résilier_Contrat"
        Me.Text = "Résilier_Contrat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CONTRATDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Titre As Label
    Friend WithEvents BtnResilier As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBoxNumCnt As TextBox
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents LblNumContratAModifier As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CONTRATDataGridView As DataGridView
End Class
