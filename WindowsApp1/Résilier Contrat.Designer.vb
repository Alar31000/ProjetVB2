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
        Me.Titre.Location = New System.Drawing.Point(247, 14)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(511, 28)
        Me.Titre.TabIndex = 39
        Me.Titre.Text = "La liste des contrats"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnResilier
        '
        Me.BtnResilier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResilier.Location = New System.Drawing.Point(79, 42)
        Me.BtnResilier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnResilier.Name = "BtnResilier"
        Me.BtnResilier.Size = New System.Drawing.Size(180, 46)
        Me.BtnResilier.TabIndex = 41
        Me.BtnResilier.Text = "Résilier"
        Me.BtnResilier.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(727, 42)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(160, 46)
        Me.BtnQuitter.TabIndex = 41
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.BtnQuitter)
        Me.GroupBox1.Controls.Add(Me.BtnResilier)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 442)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(989, 116)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'TxtBoxNumCnt
        '
        Me.TxtBoxNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNumCnt.Location = New System.Drawing.Point(727, 25)
        Me.TxtBoxNumCnt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxNumCnt.Name = "TxtBoxNumCnt"
        Me.TxtBoxNumCnt.Size = New System.Drawing.Size(253, 29)
        Me.TxtBoxNumCnt.TabIndex = 22
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.Location = New System.Drawing.Point(727, 71)
        Me.BtnRechercher.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(156, 28)
        Me.BtnRechercher.TabIndex = 34
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = True
        '
        'LblNumContratAModifier
        '
        Me.LblNumContratAModifier.AutoSize = True
        Me.LblNumContratAModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumContratAModifier.Location = New System.Drawing.Point(503, 32)
        Me.LblNumContratAModifier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumContratAModifier.Name = "LblNumContratAModifier"
        Me.LblNumContratAModifier.Size = New System.Drawing.Size(172, 24)
        Me.LblNumContratAModifier.TabIndex = 21
        Me.LblNumContratAModifier.Text = "Numéro du contrat "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblNumContratAModifier)
        Me.GroupBox2.Controls.Add(Me.BtnRechercher)
        Me.GroupBox2.Controls.Add(Me.TxtBoxNumCnt)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 281)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(989, 121)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher un contrat en particulier"
        '
        'CONTRATDataGridView
        '
        Me.CONTRATDataGridView.AllowUserToAddRows = False
        Me.CONTRATDataGridView.AllowUserToDeleteRows = False
        Me.CONTRATDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONTRATDataGridView.Location = New System.Drawing.Point(9, 46)
        Me.CONTRATDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CONTRATDataGridView.MultiSelect = False
        Me.CONTRATDataGridView.Name = "CONTRATDataGridView"
        Me.CONTRATDataGridView.ReadOnly = True
        Me.CONTRATDataGridView.RowHeadersWidth = 51
        Me.CONTRATDataGridView.ShowEditingIcon = False
        Me.CONTRATDataGridView.Size = New System.Drawing.Size(971, 228)
        Me.CONTRATDataGridView.TabIndex = 47
        '
        'Résilier_Contrat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 554)
        Me.Controls.Add(Me.CONTRATDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Titre)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
