<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paiement
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonPaye = New System.Windows.Forms.Button()
        Me.TextBoxNumeroCarte = New System.Windows.Forms.TextBox()
        Me.TextBoxDateEx = New System.Windows.Forms.TextBox()
        Me.LabelNumeroCarte = New System.Windows.Forms.Label()
        Me.LabelDateEx = New System.Windows.Forms.Label()
        Me.TextBoxCVV = New System.Windows.Forms.TextBox()
        Me.LabelCvv = New System.Windows.Forms.Label()
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.LabelNumeroCompte = New System.Windows.Forms.Label()
        Me.TextBoxNCompte = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelFacture = New System.Windows.Forms.Label()
        Me.TextBoxNIP = New System.Windows.Forms.TextBox()
        Me.LabelNIP = New System.Windows.Forms.Label()
        Me.GroupBoxPrélèvement = New System.Windows.Forms.GroupBox()
        Me.GroupBoxChèque = New System.Windows.Forms.GroupBox()
        Me.TextBoxNComptec = New System.Windows.Forms.TextBox()
        Me.TextBoxNSuccursale = New System.Windows.Forms.TextBox()
        Me.LabelComptec = New System.Windows.Forms.Label()
        Me.LabelSuccursale = New System.Windows.Forms.Label()
        Me.LabelInstitution = New System.Windows.Forms.Label()
        Me.TextBoxNInstitution = New System.Windows.Forms.TextBox()
        Me.GroupBoxPayement = New System.Windows.Forms.GroupBox()
        Me.CheckBoxPrélèvement = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCarte = New System.Windows.Forms.CheckBox()
        Me.CheckBoxChèque = New System.Windows.Forms.CheckBox()
        Me.GroupBoxCarte = New System.Windows.Forms.GroupBox()
        Me.GroupBoxFacture.SuspendLayout()
        Me.GroupBoxChèque.SuspendLayout()
        Me.GroupBoxPayement.SuspendLayout()
        Me.GroupBoxCarte.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonPaye
        '
        Me.ButtonPaye.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.ButtonPaye.Location = New System.Drawing.Point(44, 212)
        Me.ButtonPaye.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonPaye.Name = "ButtonPaye"
        Me.ButtonPaye.Size = New System.Drawing.Size(177, 42)
        Me.ButtonPaye.TabIndex = 0
        Me.ButtonPaye.Text = "Payer Maintenant"
        Me.ButtonPaye.UseVisualStyleBackColor = True
        '
        'TextBoxNumeroCarte
        '
        Me.TextBoxNumeroCarte.Location = New System.Drawing.Point(215, 36)
        Me.TextBoxNumeroCarte.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNumeroCarte.Name = "TextBoxNumeroCarte"
        Me.TextBoxNumeroCarte.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNumeroCarte.TabIndex = 2
        Me.TextBoxNumeroCarte.Visible = False
        '
        'TextBoxDateEx
        '
        Me.TextBoxDateEx.Location = New System.Drawing.Point(215, 92)
        Me.TextBoxDateEx.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDateEx.Name = "TextBoxDateEx"
        Me.TextBoxDateEx.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxDateEx.TabIndex = 3
        Me.TextBoxDateEx.Visible = False
        '
        'LabelNumeroCarte
        '
        Me.LabelNumeroCarte.AutoSize = True
        Me.LabelNumeroCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNumeroCarte.Location = New System.Drawing.Point(18, 42)
        Me.LabelNumeroCarte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNumeroCarte.Name = "LabelNumeroCarte"
        Me.LabelNumeroCarte.Size = New System.Drawing.Size(159, 28)
        Me.LabelNumeroCarte.TabIndex = 5
        Me.LabelNumeroCarte.Text = "Numéro de carte"
        Me.LabelNumeroCarte.Visible = False
        '
        'LabelDateEx
        '
        Me.LabelDateEx.AutoSize = True
        Me.LabelDateEx.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelDateEx.Location = New System.Drawing.Point(14, 101)
        Me.LabelDateEx.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDateEx.Name = "LabelDateEx"
        Me.LabelDateEx.Size = New System.Drawing.Size(163, 28)
        Me.LabelDateEx.TabIndex = 6
        Me.LabelDateEx.Text = "Date d'expiration"
        Me.LabelDateEx.Visible = False
        '
        'TextBoxCVV
        '
        Me.TextBoxCVV.Location = New System.Drawing.Point(215, 151)
        Me.TextBoxCVV.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCVV.Name = "TextBoxCVV"
        Me.TextBoxCVV.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxCVV.TabIndex = 10
        Me.TextBoxCVV.Visible = False
        '
        'LabelCvv
        '
        Me.LabelCvv.AutoSize = True
        Me.LabelCvv.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelCvv.Location = New System.Drawing.Point(14, 160)
        Me.LabelCvv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCvv.Name = "LabelCvv"
        Me.LabelCvv.Size = New System.Drawing.Size(48, 28)
        Me.LabelCvv.TabIndex = 11
        Me.LabelCvv.Text = "CVV"
        Me.LabelCvv.Visible = False
        '
        'GroupBoxFacture
        '
        Me.GroupBoxFacture.AutoSize = True
        Me.GroupBoxFacture.Controls.Add(Me.LabelNumeroCompte)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNCompte)
        Me.GroupBoxFacture.Controls.Add(Me.Button1)
        Me.GroupBoxFacture.Controls.Add(Me.LabelFacture)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNIP)
        Me.GroupBoxFacture.Controls.Add(Me.ButtonPaye)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNIP)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPrélèvement)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxChèque)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPayement)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxCarte)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(1, 1)
        Me.GroupBoxFacture.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxFacture.Size = New System.Drawing.Size(1081, 586)
        Me.GroupBoxFacture.TabIndex = 12
        Me.GroupBoxFacture.TabStop = False
        Me.GroupBoxFacture.Text = "Paiement de la Facture"
        '
        'LabelNumeroCompte
        '
        Me.LabelNumeroCompte.AutoSize = True
        Me.LabelNumeroCompte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNumeroCompte.Location = New System.Drawing.Point(628, 212)
        Me.LabelNumeroCompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNumeroCompte.Name = "LabelNumeroCompte"
        Me.LabelNumeroCompte.Size = New System.Drawing.Size(183, 28)
        Me.LabelNumeroCompte.TabIndex = 8
        Me.LabelNumeroCompte.Text = "Numéro de compte"
        Me.LabelNumeroCompte.Visible = False
        '
        'TextBoxNCompte
        '
        Me.TextBoxNCompte.Location = New System.Drawing.Point(864, 252)
        Me.TextBoxNCompte.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNCompte.Name = "TextBoxNCompte"
        Me.TextBoxNCompte.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNCompte.TabIndex = 14
        Me.TextBoxNCompte.Visible = False
        Me.TextBoxNCompte.WordWrap = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Button1.Location = New System.Drawing.Point(44, 413)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 42)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelFacture
        '
        Me.LabelFacture.AutoSize = True
        Me.LabelFacture.ForeColor = System.Drawing.Color.Red
        Me.LabelFacture.Location = New System.Drawing.Point(143, 91)
        Me.LabelFacture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFacture.Name = "LabelFacture"
        Me.LabelFacture.Size = New System.Drawing.Size(759, 37)
        Me.LabelFacture.TabIndex = 17
        Me.LabelFacture.Text = "Cette option sera développée dans la prochaine version."
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(864, 199)
        Me.TextBoxNIP.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNIP.TabIndex = 12
        Me.TextBoxNIP.Visible = False
        '
        'LabelNIP
        '
        Me.LabelNIP.AutoSize = True
        Me.LabelNIP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNIP.Location = New System.Drawing.Point(628, 252)
        Me.LabelNIP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNIP.Name = "LabelNIP"
        Me.LabelNIP.Size = New System.Drawing.Size(43, 28)
        Me.LabelNIP.TabIndex = 7
        Me.LabelNIP.Text = "NIP"
        Me.LabelNIP.Visible = False
        '
        'GroupBoxPrélèvement
        '
        Me.GroupBoxPrélèvement.Location = New System.Drawing.Point(575, 172)
        Me.GroupBoxPrélèvement.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxPrélèvement.Name = "GroupBoxPrélèvement"
        Me.GroupBoxPrélèvement.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxPrélèvement.Size = New System.Drawing.Size(475, 144)
        Me.GroupBoxPrélèvement.TabIndex = 18
        Me.GroupBoxPrélèvement.TabStop = False
        Me.GroupBoxPrélèvement.Visible = False
        '
        'GroupBoxChèque
        '
        Me.GroupBoxChèque.Controls.Add(Me.TextBoxNComptec)
        Me.GroupBoxChèque.Controls.Add(Me.TextBoxNSuccursale)
        Me.GroupBoxChèque.Controls.Add(Me.LabelComptec)
        Me.GroupBoxChèque.Controls.Add(Me.LabelSuccursale)
        Me.GroupBoxChèque.Controls.Add(Me.LabelInstitution)
        Me.GroupBoxChèque.Controls.Add(Me.TextBoxNInstitution)
        Me.GroupBoxChèque.Location = New System.Drawing.Point(575, 324)
        Me.GroupBoxChèque.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxChèque.Name = "GroupBoxChèque"
        Me.GroupBoxChèque.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxChèque.Size = New System.Drawing.Size(475, 218)
        Me.GroupBoxChèque.TabIndex = 19
        Me.GroupBoxChèque.TabStop = False
        Me.GroupBoxChèque.Visible = False
        '
        'TextBoxNComptec
        '
        Me.TextBoxNComptec.Location = New System.Drawing.Point(289, 151)
        Me.TextBoxNComptec.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNComptec.Name = "TextBoxNComptec"
        Me.TextBoxNComptec.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNComptec.TabIndex = 26
        Me.TextBoxNComptec.Visible = False
        '
        'TextBoxNSuccursale
        '
        Me.TextBoxNSuccursale.Location = New System.Drawing.Point(289, 33)
        Me.TextBoxNSuccursale.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNSuccursale.Name = "TextBoxNSuccursale"
        Me.TextBoxNSuccursale.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNSuccursale.TabIndex = 15
        Me.TextBoxNSuccursale.Visible = False
        '
        'LabelComptec
        '
        Me.LabelComptec.AutoSize = True
        Me.LabelComptec.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelComptec.ForeColor = System.Drawing.Color.Navy
        Me.LabelComptec.Location = New System.Drawing.Point(44, 160)
        Me.LabelComptec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelComptec.Name = "LabelComptec"
        Me.LabelComptec.Size = New System.Drawing.Size(183, 28)
        Me.LabelComptec.TabIndex = 0
        Me.LabelComptec.Text = "Numéro de compte"
        Me.LabelComptec.Visible = False
        '
        'LabelSuccursale
        '
        Me.LabelSuccursale.AutoSize = True
        Me.LabelSuccursale.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelSuccursale.ForeColor = System.Drawing.Color.Navy
        Me.LabelSuccursale.Location = New System.Drawing.Point(44, 42)
        Me.LabelSuccursale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSuccursale.Name = "LabelSuccursale"
        Me.LabelSuccursale.Size = New System.Drawing.Size(204, 28)
        Me.LabelSuccursale.TabIndex = 2
        Me.LabelSuccursale.Text = "Numéro de succursale"
        Me.LabelSuccursale.Visible = False
        '
        'LabelInstitution
        '
        Me.LabelInstitution.AutoSize = True
        Me.LabelInstitution.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelInstitution.ForeColor = System.Drawing.Color.Navy
        Me.LabelInstitution.Location = New System.Drawing.Point(41, 98)
        Me.LabelInstitution.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelInstitution.Name = "LabelInstitution"
        Me.LabelInstitution.Size = New System.Drawing.Size(195, 28)
        Me.LabelInstitution.TabIndex = 1
        Me.LabelInstitution.Text = "Numéro d'institution"
        Me.LabelInstitution.Visible = False
        '
        'TextBoxNInstitution
        '
        Me.TextBoxNInstitution.Location = New System.Drawing.Point(289, 89)
        Me.TextBoxNInstitution.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxNInstitution.Name = "TextBoxNInstitution"
        Me.TextBoxNInstitution.Size = New System.Drawing.Size(113, 43)
        Me.TextBoxNInstitution.TabIndex = 15
        Me.TextBoxNInstitution.Visible = False
        '
        'GroupBoxPayement
        '
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxPrélèvement)
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxCarte)
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxChèque)
        Me.GroupBoxPayement.Location = New System.Drawing.Point(236, 170)
        Me.GroupBoxPayement.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxPayement.Name = "GroupBoxPayement"
        Me.GroupBoxPayement.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxPayement.Size = New System.Drawing.Size(331, 144)
        Me.GroupBoxPayement.TabIndex = 24
        Me.GroupBoxPayement.TabStop = False
        Me.GroupBoxPayement.Visible = False
        '
        'CheckBoxPrélèvement
        '
        Me.CheckBoxPrélèvement.AutoSize = True
        Me.CheckBoxPrélèvement.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxPrélèvement.ForeColor = System.Drawing.Color.Navy
        Me.CheckBoxPrélèvement.Location = New System.Drawing.Point(8, 29)
        Me.CheckBoxPrélèvement.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxPrélèvement.Name = "CheckBoxPrélèvement"
        Me.CheckBoxPrélèvement.Size = New System.Drawing.Size(259, 32)
        Me.CheckBoxPrélèvement.TabIndex = 21
        Me.CheckBoxPrélèvement.Text = "Prélèvement automatique"
        Me.CheckBoxPrélèvement.UseVisualStyleBackColor = True
        Me.CheckBoxPrélèvement.Visible = False
        '
        'CheckBoxCarte
        '
        Me.CheckBoxCarte.AutoSize = True
        Me.CheckBoxCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxCarte.ForeColor = System.Drawing.Color.Navy
        Me.CheckBoxCarte.Location = New System.Drawing.Point(8, 64)
        Me.CheckBoxCarte.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxCarte.Name = "CheckBoxCarte"
        Me.CheckBoxCarte.Size = New System.Drawing.Size(135, 32)
        Me.CheckBoxCarte.TabIndex = 22
        Me.CheckBoxCarte.Text = "Carte credit"
        Me.CheckBoxCarte.UseVisualStyleBackColor = True
        Me.CheckBoxCarte.Visible = False
        '
        'CheckBoxChèque
        '
        Me.CheckBoxChèque.AutoSize = True
        Me.CheckBoxChèque.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxChèque.ForeColor = System.Drawing.Color.Navy
        Me.CheckBoxChèque.Location = New System.Drawing.Point(8, 98)
        Me.CheckBoxChèque.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBoxChèque.Name = "CheckBoxChèque"
        Me.CheckBoxChèque.Size = New System.Drawing.Size(179, 32)
        Me.CheckBoxChèque.TabIndex = 23
        Me.CheckBoxChèque.Text = "Chèque bancaire"
        Me.CheckBoxChèque.UseVisualStyleBackColor = True
        Me.CheckBoxChèque.Visible = False
        '
        'GroupBoxCarte
        '
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxNumeroCarte)
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxDateEx)
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxCVV)
        Me.GroupBoxCarte.Controls.Add(Me.LabelCvv)
        Me.GroupBoxCarte.Controls.Add(Me.LabelNumeroCarte)
        Me.GroupBoxCarte.Controls.Add(Me.LabelDateEx)
        Me.GroupBoxCarte.Location = New System.Drawing.Point(225, 324)
        Me.GroupBoxCarte.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxCarte.Name = "GroupBoxCarte"
        Me.GroupBoxCarte.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxCarte.Size = New System.Drawing.Size(342, 217)
        Me.GroupBoxCarte.TabIndex = 20
        Me.GroupBoxCarte.TabStop = False
        Me.GroupBoxCarte.Visible = False
        '
        'Paiement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 570)
        Me.Controls.Add(Me.GroupBoxFacture)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Paiement"
        Me.Text = "Paiement"
        Me.GroupBoxFacture.ResumeLayout(False)
        Me.GroupBoxFacture.PerformLayout()
        Me.GroupBoxChèque.ResumeLayout(False)
        Me.GroupBoxChèque.PerformLayout()
        Me.GroupBoxPayement.ResumeLayout(False)
        Me.GroupBoxPayement.PerformLayout()
        Me.GroupBoxCarte.ResumeLayout(False)
        Me.GroupBoxCarte.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonPaye As Button
    Friend WithEvents TextBoxNumeroCarte As TextBox
    Friend WithEvents TextBoxDateEx As TextBox
    Friend WithEvents LabelNumeroCarte As Label
    Friend WithEvents LabelDateEx As Label
    Friend WithEvents TextBoxCVV As TextBox
    Friend WithEvents LabelCvv As Label
    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents LabelFacture As Label
    Friend WithEvents TextBoxNSuccursale As TextBox
    Friend WithEvents TextBoxNInstitution As TextBox
    Friend WithEvents TextBoxNCompte As TextBox
    Friend WithEvents TextBoxNIP As TextBox
    Friend WithEvents LabelSuccursale As Label
    Friend WithEvents LabelNIP As Label
    Friend WithEvents LabelInstitution As Label
    Friend WithEvents LabelComptec As Label
    Friend WithEvents LabelNumeroCompte As Label
    Friend WithEvents GroupBoxPrélèvement As GroupBox
    Friend WithEvents GroupBoxChèque As GroupBox
    Friend WithEvents GroupBoxCarte As GroupBox
    Friend WithEvents CheckBoxChèque As CheckBox
    Friend WithEvents CheckBoxCarte As CheckBox
    Friend WithEvents CheckBoxPrélèvement As CheckBox
    Friend WithEvents GroupBoxPayement As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxNComptec As TextBox
End Class
