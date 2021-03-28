<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacture
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
        Me.LblNFacture = New System.Windows.Forms.Label()
        Me.LblCodeClient = New System.Windows.Forms.Label()
        Me.LblDateFacture = New System.Windows.Forms.Label()
        Me.TextBoxNFacture = New System.Windows.Forms.TextBox()
        Me.TextBoxCodeClient = New System.Windows.Forms.TextBox()
        Me.TextBoxDateFacture = New System.Windows.Forms.TextBox()
        Me.LabelAdresseF = New System.Windows.Forms.Label()
        Me.LblTéléphone = New System.Windows.Forms.Label()
        Me.LabelAdresseL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LabelRProduit = New System.Windows.Forms.Label()
        Me.LabelQuantité = New System.Windows.Forms.Label()
        Me.LabelPrix = New System.Windows.Forms.Label()
        Me.LabelMOrdi = New System.Windows.Forms.Label()
        Me.LabelModem = New System.Windows.Forms.Label()
        Me.LabelLInternet = New System.Windows.Forms.Label()
        Me.LabelQC = New System.Windows.Forms.Label()
        Me.LblQCM = New System.Windows.Forms.Label()
        Me.LblQMLI = New System.Windows.Forms.Label()
        Me.LabelMOP = New System.Windows.Forms.Label()
        Me.LabelPM = New System.Windows.Forms.Label()
        Me.LabelLI = New System.Windows.Forms.Label()
        Me.LabelSousTotal = New System.Windows.Forms.Label()
        Me.LabelTPS = New System.Windows.Forms.Label()
        Me.LabelTVQ = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelST = New System.Windows.Forms.Label()
        Me.LabelPTPS = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.LblPT = New System.Windows.Forms.Label()
        Me.BttnPayement = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNFacture
        '
        Me.LblNFacture.AutoSize = True
        Me.LblNFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNFacture.ForeColor = System.Drawing.Color.Navy
        Me.LblNFacture.Location = New System.Drawing.Point(64, 24)
        Me.LblNFacture.Name = "LblNFacture"
        Me.LblNFacture.Size = New System.Drawing.Size(122, 21)
        Me.LblNFacture.TabIndex = 15
        Me.LblNFacture.Text = "Numéro Facture"
        '
        'LblCodeClient
        '
        Me.LblCodeClient.AutoSize = True
        Me.LblCodeClient.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodeClient.ForeColor = System.Drawing.Color.Navy
        Me.LblCodeClient.Location = New System.Drawing.Point(64, 62)
        Me.LblCodeClient.Name = "LblCodeClient"
        Me.LblCodeClient.Size = New System.Drawing.Size(87, 21)
        Me.LblCodeClient.TabIndex = 16
        Me.LblCodeClient.Text = "Code client"
        '
        'LblDateFacture
        '
        Me.LblDateFacture.AutoSize = True
        Me.LblDateFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateFacture.ForeColor = System.Drawing.Color.Navy
        Me.LblDateFacture.Location = New System.Drawing.Point(64, 101)
        Me.LblDateFacture.Name = "LblDateFacture"
        Me.LblDateFacture.Size = New System.Drawing.Size(96, 21)
        Me.LblDateFacture.TabIndex = 17
        Me.LblDateFacture.Text = "Date Facture"
        '
        'TextBoxNFacture
        '
        Me.TextBoxNFacture.Location = New System.Drawing.Point(192, 27)
        Me.TextBoxNFacture.Name = "TextBoxNFacture"
        Me.TextBoxNFacture.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxNFacture.TabIndex = 18
        '
        'TextBoxCodeClient
        '
        Me.TextBoxCodeClient.Location = New System.Drawing.Point(192, 65)
        Me.TextBoxCodeClient.Name = "TextBoxCodeClient"
        Me.TextBoxCodeClient.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxCodeClient.TabIndex = 19
        '
        'TextBoxDateFacture
        '
        Me.TextBoxDateFacture.Location = New System.Drawing.Point(192, 104)
        Me.TextBoxDateFacture.Name = "TextBoxDateFacture"
        Me.TextBoxDateFacture.Size = New System.Drawing.Size(154, 20)
        Me.TextBoxDateFacture.TabIndex = 20
        '
        'LabelAdresseF
        '
        Me.LabelAdresseF.AutoSize = True
        Me.LabelAdresseF.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdresseF.ForeColor = System.Drawing.Color.Navy
        Me.LabelAdresseF.Location = New System.Drawing.Point(64, 161)
        Me.LabelAdresseF.Name = "LabelAdresseF"
        Me.LabelAdresseF.Size = New System.Drawing.Size(65, 21)
        Me.LabelAdresseF.TabIndex = 21
        Me.LabelAdresseF.Text = "Adresse"
        '
        'LblTéléphone
        '
        Me.LblTéléphone.AutoSize = True
        Me.LblTéléphone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTéléphone.ForeColor = System.Drawing.Color.Navy
        Me.LblTéléphone.Location = New System.Drawing.Point(64, 210)
        Me.LblTéléphone.Name = "LblTéléphone"
        Me.LblTéléphone.Size = New System.Drawing.Size(80, 21)
        Me.LblTéléphone.TabIndex = 22
        Me.LblTéléphone.Text = "Téléphone"
        '
        'LabelAdresseL
        '
        Me.LabelAdresseL.AutoSize = True
        Me.LabelAdresseL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdresseL.ForeColor = System.Drawing.Color.Navy
        Me.LabelAdresseL.Location = New System.Drawing.Point(439, 163)
        Me.LabelAdresseL.Name = "LabelAdresseL"
        Me.LabelAdresseL.Size = New System.Drawing.Size(65, 21)
        Me.LabelAdresseL.TabIndex = 25
        Me.LabelAdresseL.Text = "Adresse"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(439, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 21)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Téléphone"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 20)
        Me.TextBox1.TabIndex = 27
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(192, 211)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(154, 20)
        Me.TextBox2.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(520, 166)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 20)
        Me.TextBox4.TabIndex = 29
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(520, 214)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(186, 20)
        Me.TextBox5.TabIndex = 30
        '
        'LabelRProduit
        '
        Me.LabelRProduit.AutoSize = True
        Me.LabelRProduit.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRProduit.ForeColor = System.Drawing.Color.Navy
        Me.LabelRProduit.Location = New System.Drawing.Point(63, 275)
        Me.LabelRProduit.Name = "LabelRProduit"
        Me.LabelRProduit.Size = New System.Drawing.Size(93, 21)
        Me.LabelRProduit.TabIndex = 31
        Me.LabelRProduit.Text = "Réf.Produit"
        '
        'LabelQuantité
        '
        Me.LabelQuantité.AutoSize = True
        Me.LabelQuantité.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQuantité.ForeColor = System.Drawing.Color.Navy
        Me.LabelQuantité.Location = New System.Drawing.Point(438, 275)
        Me.LabelQuantité.Name = "LabelQuantité"
        Me.LabelQuantité.Size = New System.Drawing.Size(173, 21)
        Me.LabelQuantité.TabIndex = 32
        Me.LabelQuantité.Text = "Quantité Commandée"
        '
        'LabelPrix
        '
        Me.LabelPrix.AutoSize = True
        Me.LabelPrix.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrix.ForeColor = System.Drawing.Color.Navy
        Me.LabelPrix.Location = New System.Drawing.Point(276, 275)
        Me.LabelPrix.Name = "LabelPrix"
        Me.LabelPrix.Size = New System.Drawing.Size(40, 21)
        Me.LabelPrix.TabIndex = 33
        Me.LabelPrix.Text = "Prix"
        '
        'LabelMOrdi
        '
        Me.LabelMOrdi.AutoSize = True
        Me.LabelMOrdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMOrdi.ForeColor = System.Drawing.Color.Navy
        Me.LabelMOrdi.Location = New System.Drawing.Point(64, 331)
        Me.LabelMOrdi.Name = "LabelMOrdi"
        Me.LabelMOrdi.Size = New System.Drawing.Size(129, 21)
        Me.LabelMOrdi.TabIndex = 34
        Me.LabelMOrdi.Text = "Micro-ordinateur"
        '
        'LabelModem
        '
        Me.LabelModem.AutoSize = True
        Me.LabelModem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModem.ForeColor = System.Drawing.Color.Navy
        Me.LabelModem.Location = New System.Drawing.Point(63, 364)
        Me.LabelModem.Name = "LabelModem"
        Me.LabelModem.Size = New System.Drawing.Size(64, 21)
        Me.LabelModem.TabIndex = 35
        Me.LabelModem.Text = "Modem"
        '
        'LabelLInternet
        '
        Me.LabelLInternet.AutoSize = True
        Me.LabelLInternet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLInternet.ForeColor = System.Drawing.Color.Navy
        Me.LabelLInternet.Location = New System.Drawing.Point(63, 399)
        Me.LabelLInternet.Name = "LabelLInternet"
        Me.LabelLInternet.Size = New System.Drawing.Size(106, 21)
        Me.LabelLInternet.TabIndex = 36
        Me.LabelLInternet.Text = "Ligne Internet"
        '
        'LabelQC
        '
        Me.LabelQC.AutoSize = True
        Me.LabelQC.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelQC.Location = New System.Drawing.Point(446, 337)
        Me.LabelQC.Name = "LabelQC"
        Me.LabelQC.Size = New System.Drawing.Size(19, 21)
        Me.LabelQC.TabIndex = 37
        Me.LabelQC.Text = "0"
        '
        'LblQCM
        '
        Me.LblQCM.AutoSize = True
        Me.LblQCM.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQCM.Location = New System.Drawing.Point(446, 370)
        Me.LblQCM.Name = "LblQCM"
        Me.LblQCM.Size = New System.Drawing.Size(19, 21)
        Me.LblQCM.TabIndex = 38
        Me.LblQCM.Text = "0"
        '
        'LblQMLI
        '
        Me.LblQMLI.AutoSize = True
        Me.LblQMLI.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQMLI.Location = New System.Drawing.Point(446, 405)
        Me.LblQMLI.Name = "LblQMLI"
        Me.LblQMLI.Size = New System.Drawing.Size(19, 21)
        Me.LblQMLI.TabIndex = 39
        Me.LblQMLI.Text = "0"
        '
        'LabelMOP
        '
        Me.LabelMOP.AutoSize = True
        Me.LabelMOP.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMOP.Location = New System.Drawing.Point(278, 337)
        Me.LabelMOP.Name = "LabelMOP"
        Me.LabelMOP.Size = New System.Drawing.Size(41, 21)
        Me.LabelMOP.TabIndex = 40
        Me.LabelMOP.Text = "0.00"
        '
        'LabelPM
        '
        Me.LabelPM.AutoSize = True
        Me.LabelPM.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPM.Location = New System.Drawing.Point(278, 370)
        Me.LabelPM.Name = "LabelPM"
        Me.LabelPM.Size = New System.Drawing.Size(41, 21)
        Me.LabelPM.TabIndex = 41
        Me.LabelPM.Text = "0.00"
        '
        'LabelLI
        '
        Me.LabelLI.AutoSize = True
        Me.LabelLI.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLI.Location = New System.Drawing.Point(277, 399)
        Me.LabelLI.Name = "LabelLI"
        Me.LabelLI.Size = New System.Drawing.Size(41, 21)
        Me.LabelLI.TabIndex = 42
        Me.LabelLI.Text = "0.00"
        '
        'LabelSousTotal
        '
        Me.LabelSousTotal.AutoSize = True
        Me.LabelSousTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSousTotal.ForeColor = System.Drawing.Color.Navy
        Me.LabelSousTotal.Location = New System.Drawing.Point(64, 442)
        Me.LabelSousTotal.Name = "LabelSousTotal"
        Me.LabelSousTotal.Size = New System.Drawing.Size(100, 21)
        Me.LabelSousTotal.TabIndex = 43
        Me.LabelSousTotal.Text = "SOUS-TOTAL"
        '
        'LabelTPS
        '
        Me.LabelTPS.AutoSize = True
        Me.LabelTPS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTPS.ForeColor = System.Drawing.Color.Navy
        Me.LabelTPS.Location = New System.Drawing.Point(64, 474)
        Me.LabelTPS.Name = "LabelTPS"
        Me.LabelTPS.Size = New System.Drawing.Size(62, 21)
        Me.LabelTPS.TabIndex = 44
        Me.LabelTPS.Text = "TPS 5%"
        '
        'LabelTVQ
        '
        Me.LabelTVQ.AutoSize = True
        Me.LabelTVQ.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTVQ.ForeColor = System.Drawing.Color.Navy
        Me.LabelTVQ.Location = New System.Drawing.Point(64, 502)
        Me.LabelTVQ.Name = "LabelTVQ"
        Me.LabelTVQ.Size = New System.Drawing.Size(96, 21)
        Me.LabelTVQ.TabIndex = 45
        Me.LabelTVQ.Text = "TVQ 9.979%"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.Navy
        Me.LabelTotal.Location = New System.Drawing.Point(63, 533)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(53, 21)
        Me.LabelTotal.TabIndex = 46
        Me.LabelTotal.Text = "TOTAL"
        '
        'LabelST
        '
        Me.LabelST.AutoSize = True
        Me.LabelST.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelST.Location = New System.Drawing.Point(276, 442)
        Me.LabelST.Name = "LabelST"
        Me.LabelST.Size = New System.Drawing.Size(50, 21)
        Me.LabelST.TabIndex = 47
        Me.LabelST.Text = "$0.00"
        '
        'LabelPTPS
        '
        Me.LabelPTPS.AutoSize = True
        Me.LabelPTPS.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPTPS.Location = New System.Drawing.Point(276, 474)
        Me.LabelPTPS.Name = "LabelPTPS"
        Me.LabelPTPS.Size = New System.Drawing.Size(50, 21)
        Me.LabelPTPS.TabIndex = 48
        Me.LabelPTPS.Text = "$0.00"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(277, 502)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(50, 21)
        Me.Lbl.TabIndex = 49
        Me.Lbl.Text = "$0.00"
        '
        'LblPT
        '
        Me.LblPT.AutoSize = True
        Me.LblPT.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPT.Location = New System.Drawing.Point(276, 533)
        Me.LblPT.Name = "LblPT"
        Me.LblPT.Size = New System.Drawing.Size(50, 21)
        Me.LblPT.TabIndex = 50
        Me.LblPT.Text = "$0.00"
        '
        'BttnPayement
        '
        Me.BttnPayement.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnPayement.Location = New System.Drawing.Point(280, 582)
        Me.BttnPayement.Name = "BttnPayement"
        Me.BttnPayement.Size = New System.Drawing.Size(114, 33)
        Me.BttnPayement.TabIndex = 51
        Me.BttnPayement.Text = "PAYEMENT"
        Me.BttnPayement.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnnuler.Location = New System.Drawing.Point(449, 582)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(100, 33)
        Me.ButtonAnnuler.TabIndex = 52
        Me.ButtonAnnuler.Text = "ANNULER"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(3, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 635)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facture"
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(54, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(308, 120)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adresse Facture"
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(428, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 120)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Adresse de livraison"
        '
        'FrmFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 627)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.BttnPayement)
        Me.Controls.Add(Me.LblPT)
        Me.Controls.Add(Me.Lbl)
        Me.Controls.Add(Me.LabelPTPS)
        Me.Controls.Add(Me.LabelST)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelTVQ)
        Me.Controls.Add(Me.LabelTPS)
        Me.Controls.Add(Me.LabelSousTotal)
        Me.Controls.Add(Me.LabelLI)
        Me.Controls.Add(Me.LabelPM)
        Me.Controls.Add(Me.LabelMOP)
        Me.Controls.Add(Me.LblQMLI)
        Me.Controls.Add(Me.LblQCM)
        Me.Controls.Add(Me.LabelQC)
        Me.Controls.Add(Me.LabelLInternet)
        Me.Controls.Add(Me.LabelModem)
        Me.Controls.Add(Me.LabelMOrdi)
        Me.Controls.Add(Me.LabelPrix)
        Me.Controls.Add(Me.LabelQuantité)
        Me.Controls.Add(Me.LabelRProduit)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LabelAdresseL)
        Me.Controls.Add(Me.LblTéléphone)
        Me.Controls.Add(Me.LabelAdresseF)
        Me.Controls.Add(Me.TextBoxDateFacture)
        Me.Controls.Add(Me.TextBoxCodeClient)
        Me.Controls.Add(Me.TextBoxNFacture)
        Me.Controls.Add(Me.LblDateFacture)
        Me.Controls.Add(Me.LblCodeClient)
        Me.Controls.Add(Me.LblNFacture)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmFacture"
        Me.Text = "FrmFacture"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNFacture As Label
    Friend WithEvents LblCodeClient As Label
    Friend WithEvents LblDateFacture As Label
    Friend WithEvents TextBoxNFacture As TextBox
    Friend WithEvents TextBoxCodeClient As TextBox
    Friend WithEvents TextBoxDateFacture As TextBox
    Friend WithEvents LabelAdresseF As Label
    Friend WithEvents LblTéléphone As Label
    Friend WithEvents LabelAdresseL As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents LabelRProduit As Label
    Friend WithEvents LabelQuantité As Label
    Friend WithEvents LabelPrix As Label
    Friend WithEvents LabelMOrdi As Label
    Friend WithEvents LabelModem As Label
    Friend WithEvents LabelLInternet As Label
    Friend WithEvents LabelQC As Label
    Friend WithEvents LblQCM As Label
    Friend WithEvents LblQMLI As Label
    Friend WithEvents LabelMOP As Label
    Friend WithEvents LabelPM As Label
    Friend WithEvents LabelLI As Label
    Friend WithEvents LabelSousTotal As Label
    Friend WithEvents LabelTPS As Label
    Friend WithEvents LabelTVQ As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelST As Label
    Friend WithEvents LabelPTPS As Label
    Friend WithEvents Lbl As Label
    Friend WithEvents LblPT As Label
    Friend WithEvents BttnPayement As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
