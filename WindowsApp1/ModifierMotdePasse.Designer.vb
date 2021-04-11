<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierMotdePasse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUtilisateur = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmPass = New System.Windows.Forms.TextBox()
        Me.TextBoxNewPass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonOk = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom D'Utilisateur :"
        '
        'TextBoxUtilisateur
        '
        Me.TextBoxUtilisateur.Location = New System.Drawing.Point(234, 113)
        Me.TextBoxUtilisateur.Name = "TextBoxUtilisateur"
        Me.TextBoxUtilisateur.ReadOnly = True
        Me.TextBoxUtilisateur.Size = New System.Drawing.Size(287, 22)
        Me.TextBoxUtilisateur.TabIndex = 1
        '
        'TextBoxConfirmPass
        '
        Me.TextBoxConfirmPass.Location = New System.Drawing.Point(234, 201)
        Me.TextBoxConfirmPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxConfirmPass.Name = "TextBoxConfirmPass"
        Me.TextBoxConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirmPass.Size = New System.Drawing.Size(287, 22)
        Me.TextBoxConfirmPass.TabIndex = 11
        '
        'TextBoxNewPass
        '
        Me.TextBoxNewPass.Location = New System.Drawing.Point(234, 158)
        Me.TextBoxNewPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNewPass.Name = "TextBoxNewPass"
        Me.TextBoxNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNewPass.Size = New System.Drawing.Size(287, 22)
        Me.TextBoxNewPass.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label4.Location = New System.Drawing.Point(56, 204)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Confirmer Mot de Passe : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Label3.Location = New System.Drawing.Point(56, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nouveau Mot de Passe :"
        '
        'ButtonOk
        '
        Me.ButtonOk.Location = New System.Drawing.Point(346, 260)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(75, 25)
        Me.ButtonOk.TabIndex = 12
        Me.ButtonOk.Text = "Ok"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(446, 260)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(75, 25)
        Me.ButtonAnnuler.TabIndex = 13
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Changement de Mot de Passe"
        '
        'ModifierMotdePasse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 329)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.TextBoxConfirmPass)
        Me.Controls.Add(Me.TextBoxNewPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxUtilisateur)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModifierMotdePasse"
        Me.Text = "Modifier Le Mot de Passe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUtilisateur As TextBox
    Friend WithEvents TextBoxConfirmPass As TextBox
    Friend WithEvents TextBoxNewPass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonOk As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents Label2 As Label
End Class
