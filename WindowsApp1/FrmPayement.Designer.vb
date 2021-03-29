<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayement
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
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelFacture = New System.Windows.Forms.Label()
        Me.ButtonPaye = New System.Windows.Forms.Button()
        Me.LabelNIP = New System.Windows.Forms.Label()
        Me.GroupBoxPrélèvement = New System.Windows.Forms.GroupBox()
        Me.TextBoxNCompte = New System.Windows.Forms.TextBox()
        Me.LabelNumeroCompte = New System.Windows.Forms.Label()
        Me.TextBoxNIP = New System.Windows.Forms.TextBox()
        Me.GroupBoxChèque = New System.Windows.Forms.GroupBox()
        Me.LabelInstitution = New System.Windows.Forms.Label()
        Me.TextBoxNComptec = New System.Windows.Forms.TextBox()
        Me.LabelSuccursale = New System.Windows.Forms.Label()
        Me.LabelComptec = New System.Windows.Forms.Label()
        Me.TextBoxNInstitution = New System.Windows.Forms.TextBox()
        Me.TextBoxNSuccursale = New System.Windows.Forms.TextBox()
        Me.GroupBoxCarte = New System.Windows.Forms.GroupBox()
        Me.TextBoxNumeroCarte = New System.Windows.Forms.TextBox()
        Me.TextBoxDateEx = New System.Windows.Forms.TextBox()
        Me.TextBoxCVV = New System.Windows.Forms.TextBox()
        Me.LabelCvv = New System.Windows.Forms.Label()
        Me.LabelDateEx = New System.Windows.Forms.Label()
        Me.LabelNumeroCarte = New System.Windows.Forms.Label()
        Me.GroupBoxPayement = New System.Windows.Forms.GroupBox()
        Me.CheckBoxPrélèvement = New System.Windows.Forms.CheckBox()
        Me.CheckBoxCarte = New System.Windows.Forms.CheckBox()
        Me.CheckBoxChèque = New System.Windows.Forms.CheckBox()
        Me.GroupBoxFacture.SuspendLayout()
        Me.GroupBoxPrélèvement.SuspendLayout()
        Me.GroupBoxChèque.SuspendLayout()
        Me.GroupBoxCarte.SuspendLayout()
        Me.GroupBoxPayement.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxFacture
        '
        Me.GroupBoxFacture.AutoSize = True
        Me.GroupBoxFacture.Controls.Add(Me.Button1)
        Me.GroupBoxFacture.Controls.Add(Me.LabelFacture)
        Me.GroupBoxFacture.Controls.Add(Me.ButtonPaye)
        Me.GroupBoxFacture.Controls.Add(Me.LabelNIP)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPrélèvement)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxChèque)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxCarte)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBoxPayement)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(12, 9)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Size = New System.Drawing.Size(811, 460)
        Me.GroupBoxFacture.TabIndex = 13
        Me.GroupBoxFacture.TabStop = False
        Me.GroupBoxFacture.Text = "Payment de la Facture"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 34)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelFacture
        '
        Me.LabelFacture.AutoSize = True
        Me.LabelFacture.ForeColor = System.Drawing.Color.Red
        Me.LabelFacture.Location = New System.Drawing.Point(0, 63)
        Me.LabelFacture.Name = "LabelFacture"
        Me.LabelFacture.Size = New System.Drawing.Size(805, 30)
        Me.LabelFacture.TabIndex = 17
        Me.LabelFacture.Text = "Nous sommes désolé, cette option sera développée dans la prochaine version."
        '
        'ButtonPaye
        '
        Me.ButtonPaye.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ButtonPaye.Location = New System.Drawing.Point(6, 167)
        Me.ButtonPaye.Name = "ButtonPaye"
        Me.ButtonPaye.Size = New System.Drawing.Size(133, 27)
        Me.ButtonPaye.TabIndex = 0
        Me.ButtonPaye.Text = "Payer Maintenant"
        Me.ButtonPaye.UseVisualStyleBackColor = True
        '
        'LabelNIP
        '
        Me.LabelNIP.AutoSize = True
        Me.LabelNIP.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNIP.Location = New System.Drawing.Point(471, 205)
        Me.LabelNIP.Name = "LabelNIP"
        Me.LabelNIP.Size = New System.Drawing.Size(35, 21)
        Me.LabelNIP.TabIndex = 7
        Me.LabelNIP.Text = "NIP"
        Me.LabelNIP.Visible = False
        '
        'GroupBoxPrélèvement
        '
        Me.GroupBoxPrélèvement.Controls.Add(Me.TextBoxNCompte)
        Me.GroupBoxPrélèvement.Controls.Add(Me.LabelNumeroCompte)
        Me.GroupBoxPrélèvement.Controls.Add(Me.TextBoxNIP)
        Me.GroupBoxPrélèvement.Location = New System.Drawing.Point(423, 132)
        Me.GroupBoxPrélèvement.Name = "GroupBoxPrélèvement"
        Me.GroupBoxPrélèvement.Size = New System.Drawing.Size(361, 108)
        Me.GroupBoxPrélèvement.TabIndex = 18
        Me.GroupBoxPrélèvement.TabStop = False
        Me.GroupBoxPrélèvement.Visible = False
        '
        'TextBoxNCompte
        '
        Me.TextBoxNCompte.Location = New System.Drawing.Point(225, 25)
        Me.TextBoxNCompte.Name = "TextBoxNCompte"
        Me.TextBoxNCompte.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxNCompte.TabIndex = 14
        Me.TextBoxNCompte.Visible = False
        Me.TextBoxNCompte.WordWrap = False
        '
        'LabelNumeroCompte
        '
        Me.LabelNumeroCompte.AutoSize = True
        Me.LabelNumeroCompte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNumeroCompte.Location = New System.Drawing.Point(6, 35)
        Me.LabelNumeroCompte.Name = "LabelNumeroCompte"
        Me.LabelNumeroCompte.Size = New System.Drawing.Size(145, 21)
        Me.LabelNumeroCompte.TabIndex = 8
        Me.LabelNumeroCompte.Text = "Numéro de compte"
        Me.LabelNumeroCompte.Visible = False
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(225, 63)
        Me.TextBoxNIP.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxNIP.TabIndex = 12
        Me.TextBoxNIP.Visible = False
        '
        'GroupBoxChèque
        '
        Me.GroupBoxChèque.Controls.Add(Me.LabelInstitution)
        Me.GroupBoxChèque.Controls.Add(Me.TextBoxNComptec)
        Me.GroupBoxChèque.Controls.Add(Me.LabelSuccursale)
        Me.GroupBoxChèque.Controls.Add(Me.LabelComptec)
        Me.GroupBoxChèque.Controls.Add(Me.TextBoxNInstitution)
        Me.GroupBoxChèque.Controls.Add(Me.TextBoxNSuccursale)
        Me.GroupBoxChèque.Location = New System.Drawing.Point(414, 248)
        Me.GroupBoxChèque.Name = "GroupBoxChèque"
        Me.GroupBoxChèque.Size = New System.Drawing.Size(356, 178)
        Me.GroupBoxChèque.TabIndex = 19
        Me.GroupBoxChèque.TabStop = False
        Me.GroupBoxChèque.Visible = False
        '
        'LabelInstitution
        '
        Me.LabelInstitution.AutoSize = True
        Me.LabelInstitution.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelInstitution.ForeColor = System.Drawing.Color.Navy
        Me.LabelInstitution.Location = New System.Drawing.Point(12, 85)
        Me.LabelInstitution.Name = "LabelInstitution"
        Me.LabelInstitution.Size = New System.Drawing.Size(155, 21)
        Me.LabelInstitution.TabIndex = 1
        Me.LabelInstitution.Text = "Numéro d'institution"
        Me.LabelInstitution.Visible = False
        '
        'TextBoxNComptec
        '
        Me.TextBoxNComptec.Location = New System.Drawing.Point(234, 126)
        Me.TextBoxNComptec.Name = "TextBoxNComptec"
        Me.TextBoxNComptec.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxNComptec.TabIndex = 26
        Me.TextBoxNComptec.Visible = False
        '
        'LabelSuccursale
        '
        Me.LabelSuccursale.AutoSize = True
        Me.LabelSuccursale.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelSuccursale.ForeColor = System.Drawing.Color.Navy
        Me.LabelSuccursale.Location = New System.Drawing.Point(12, 42)
        Me.LabelSuccursale.Name = "LabelSuccursale"
        Me.LabelSuccursale.Size = New System.Drawing.Size(165, 21)
        Me.LabelSuccursale.TabIndex = 2
        Me.LabelSuccursale.Text = "Numéro de succursale"
        Me.LabelSuccursale.Visible = False
        '
        'LabelComptec
        '
        Me.LabelComptec.AutoSize = True
        Me.LabelComptec.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelComptec.ForeColor = System.Drawing.Color.Navy
        Me.LabelComptec.Location = New System.Drawing.Point(12, 132)
        Me.LabelComptec.Name = "LabelComptec"
        Me.LabelComptec.Size = New System.Drawing.Size(145, 21)
        Me.LabelComptec.TabIndex = 0
        Me.LabelComptec.Text = "Numéro de compte"
        Me.LabelComptec.Visible = False
        '
        'TextBoxNInstitution
        '
        Me.TextBoxNInstitution.Location = New System.Drawing.Point(234, 75)
        Me.TextBoxNInstitution.Name = "TextBoxNInstitution"
        Me.TextBoxNInstitution.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxNInstitution.TabIndex = 15
        Me.TextBoxNInstitution.Visible = False
        '
        'TextBoxNSuccursale
        '
        Me.TextBoxNSuccursale.Location = New System.Drawing.Point(234, 30)
        Me.TextBoxNSuccursale.Name = "TextBoxNSuccursale"
        Me.TextBoxNSuccursale.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxNSuccursale.TabIndex = 15
        Me.TextBoxNSuccursale.Visible = False
        '
        'GroupBoxCarte
        '
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxNumeroCarte)
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxDateEx)
        Me.GroupBoxCarte.Controls.Add(Me.TextBoxCVV)
        Me.GroupBoxCarte.Controls.Add(Me.LabelCvv)
        Me.GroupBoxCarte.Controls.Add(Me.LabelDateEx)
        Me.GroupBoxCarte.Controls.Add(Me.LabelNumeroCarte)
        Me.GroupBoxCarte.Location = New System.Drawing.Point(167, 250)
        Me.GroupBoxCarte.Name = "GroupBoxCarte"
        Me.GroupBoxCarte.Size = New System.Drawing.Size(246, 176)
        Me.GroupBoxCarte.TabIndex = 20
        Me.GroupBoxCarte.TabStop = False
        Me.GroupBoxCarte.Visible = False
        '
        'TextBoxNumeroCarte
        '
        Me.TextBoxNumeroCarte.Location = New System.Drawing.Point(147, 26)
        Me.TextBoxNumeroCarte.Name = "TextBoxNumeroCarte"
        Me.TextBoxNumeroCarte.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxNumeroCarte.TabIndex = 2
        Me.TextBoxNumeroCarte.Visible = False
        '
        'TextBoxDateEx
        '
        Me.TextBoxDateEx.Location = New System.Drawing.Point(147, 71)
        Me.TextBoxDateEx.Name = "TextBoxDateEx"
        Me.TextBoxDateEx.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxDateEx.TabIndex = 3
        Me.TextBoxDateEx.Visible = False
        '
        'TextBoxCVV
        '
        Me.TextBoxCVV.Location = New System.Drawing.Point(147, 122)
        Me.TextBoxCVV.Name = "TextBoxCVV"
        Me.TextBoxCVV.Size = New System.Drawing.Size(86, 35)
        Me.TextBoxCVV.TabIndex = 10
        Me.TextBoxCVV.Visible = False
        '
        'LabelCvv
        '
        Me.LabelCvv.AutoSize = True
        Me.LabelCvv.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelCvv.Location = New System.Drawing.Point(12, 134)
        Me.LabelCvv.Name = "LabelCvv"
        Me.LabelCvv.Size = New System.Drawing.Size(40, 21)
        Me.LabelCvv.TabIndex = 11
        Me.LabelCvv.Text = "CVV"
        Me.LabelCvv.Visible = False
        '
        'LabelDateEx
        '
        Me.LabelDateEx.AutoSize = True
        Me.LabelDateEx.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelDateEx.Location = New System.Drawing.Point(7, 85)
        Me.LabelDateEx.Name = "LabelDateEx"
        Me.LabelDateEx.Size = New System.Drawing.Size(128, 21)
        Me.LabelDateEx.TabIndex = 6
        Me.LabelDateEx.Text = "Date d'expiration"
        Me.LabelDateEx.Visible = False
        '
        'LabelNumeroCarte
        '
        Me.LabelNumeroCarte.AutoSize = True
        Me.LabelNumeroCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelNumeroCarte.Location = New System.Drawing.Point(7, 40)
        Me.LabelNumeroCarte.Name = "LabelNumeroCarte"
        Me.LabelNumeroCarte.Size = New System.Drawing.Size(127, 21)
        Me.LabelNumeroCarte.TabIndex = 5
        Me.LabelNumeroCarte.Text = "Numéro de carte"
        Me.LabelNumeroCarte.Visible = False
        '
        'GroupBoxPayement
        '
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxPrélèvement)
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxCarte)
        Me.GroupBoxPayement.Controls.Add(Me.CheckBoxChèque)
        Me.GroupBoxPayement.Location = New System.Drawing.Point(177, 146)
        Me.GroupBoxPayement.Name = "GroupBoxPayement"
        Me.GroupBoxPayement.Size = New System.Drawing.Size(236, 96)
        Me.GroupBoxPayement.TabIndex = 24
        Me.GroupBoxPayement.TabStop = False
        Me.GroupBoxPayement.Visible = False
        '
        'CheckBoxPrélèvement
        '
        Me.CheckBoxPrélèvement.AutoSize = True
        Me.CheckBoxPrélèvement.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxPrélèvement.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxPrélèvement.Location = New System.Drawing.Point(6, 20)
        Me.CheckBoxPrélèvement.Name = "CheckBoxPrélèvement"
        Me.CheckBoxPrélèvement.Size = New System.Drawing.Size(208, 25)
        Me.CheckBoxPrélèvement.TabIndex = 21
        Me.CheckBoxPrélèvement.Text = "Prélèvement automatique"
        Me.CheckBoxPrélèvement.UseVisualStyleBackColor = True
        Me.CheckBoxPrélèvement.Visible = False
        '
        'CheckBoxCarte
        '
        Me.CheckBoxCarte.AutoSize = True
        Me.CheckBoxCarte.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxCarte.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxCarte.Location = New System.Drawing.Point(6, 40)
        Me.CheckBoxCarte.Name = "CheckBoxCarte"
        Me.CheckBoxCarte.Size = New System.Drawing.Size(109, 25)
        Me.CheckBoxCarte.TabIndex = 22
        Me.CheckBoxCarte.Text = "Carte credit"
        Me.CheckBoxCarte.UseVisualStyleBackColor = True
        Me.CheckBoxCarte.Visible = False
        '
        'CheckBoxChèque
        '
        Me.CheckBoxChèque.AutoSize = True
        Me.CheckBoxChèque.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.CheckBoxChèque.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxChèque.Location = New System.Drawing.Point(6, 65)
        Me.CheckBoxChèque.Name = "CheckBoxChèque"
        Me.CheckBoxChèque.Size = New System.Drawing.Size(145, 25)
        Me.CheckBoxChèque.TabIndex = 23
        Me.CheckBoxChèque.Text = "Chèque bancaire"
        Me.CheckBoxChèque.UseVisualStyleBackColor = True
        Me.CheckBoxChèque.Visible = False
        '
        'FrmPayement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 474)
        Me.Controls.Add(Me.GroupBoxFacture)
        Me.Name = "FrmPayement"
        Me.Text = "FrmPayement"
        Me.GroupBoxFacture.ResumeLayout(False)
        Me.GroupBoxFacture.PerformLayout()
        Me.GroupBoxPrélèvement.ResumeLayout(False)
        Me.GroupBoxPrélèvement.PerformLayout()
        Me.GroupBoxChèque.ResumeLayout(False)
        Me.GroupBoxChèque.PerformLayout()
        Me.GroupBoxCarte.ResumeLayout(False)
        Me.GroupBoxCarte.PerformLayout()
        Me.GroupBoxPayement.ResumeLayout(False)
        Me.GroupBoxPayement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelFacture As Label
    Friend WithEvents ButtonPaye As Button
    Friend WithEvents LabelNIP As Label
    Friend WithEvents GroupBoxPrélèvement As GroupBox
    Friend WithEvents TextBoxNCompte As TextBox
    Friend WithEvents LabelNumeroCompte As Label
    Friend WithEvents TextBoxNIP As TextBox
    Friend WithEvents GroupBoxChèque As GroupBox
    Friend WithEvents LabelInstitution As Label
    Friend WithEvents TextBoxNComptec As TextBox
    Friend WithEvents LabelSuccursale As Label
    Friend WithEvents LabelComptec As Label
    Friend WithEvents TextBoxNInstitution As TextBox
    Friend WithEvents TextBoxNSuccursale As TextBox
    Friend WithEvents GroupBoxCarte As GroupBox
    Friend WithEvents TextBoxNumeroCarte As TextBox
    Friend WithEvents TextBoxDateEx As TextBox
    Friend WithEvents TextBoxCVV As TextBox
    Friend WithEvents LabelCvv As Label
    Friend WithEvents LabelDateEx As Label
    Friend WithEvents LabelNumeroCarte As Label
    Friend WithEvents GroupBoxPayement As GroupBox
    Friend WithEvents CheckBoxPrélèvement As CheckBox
    Friend WithEvents CheckBoxCarte As CheckBox
    Friend WithEvents CheckBoxChèque As CheckBox
End Class
