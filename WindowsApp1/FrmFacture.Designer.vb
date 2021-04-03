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
        Me.LblQteMicroOrdinateur = New System.Windows.Forms.Label()
        Me.LblQteModem = New System.Windows.Forms.Label()
        Me.LblQteInternet = New System.Windows.Forms.Label()
        Me.LblPrixMicroOrdiF = New System.Windows.Forms.Label()
        Me.LblPrixModemF = New System.Windows.Forms.Label()
        Me.LblPrixInternetF = New System.Windows.Forms.Label()
        Me.LabelSousTotal = New System.Windows.Forms.Label()
        Me.LabelTPS = New System.Windows.Forms.Label()
        Me.LabelTVQ = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LblSousTotal = New System.Windows.Forms.Label()
        Me.LblTPS = New System.Windows.Forms.Label()
        Me.LblTVQ = New System.Windows.Forms.Label()
        Me.LblPrixTotalF = New System.Windows.Forms.Label()
        Me.BttnPayement = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerFacture = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxFacture.SuspendLayout()
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
        Me.TextBoxNFacture.BackColor = System.Drawing.SystemColors.ControlLight
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
        'LblQteMicroOrdinateur
        '
        Me.LblQteMicroOrdinateur.AutoSize = True
        Me.LblQteMicroOrdinateur.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQteMicroOrdinateur.ForeColor = System.Drawing.Color.Black
        Me.LblQteMicroOrdinateur.Location = New System.Drawing.Point(442, 338)
        Me.LblQteMicroOrdinateur.Name = "LblQteMicroOrdinateur"
        Me.LblQteMicroOrdinateur.Size = New System.Drawing.Size(19, 21)
        Me.LblQteMicroOrdinateur.TabIndex = 37
        Me.LblQteMicroOrdinateur.Text = "0"
        '
        'LblQteModem
        '
        Me.LblQteModem.AutoSize = True
        Me.LblQteModem.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQteModem.ForeColor = System.Drawing.Color.Black
        Me.LblQteModem.Location = New System.Drawing.Point(443, 370)
        Me.LblQteModem.Name = "LblQteModem"
        Me.LblQteModem.Size = New System.Drawing.Size(19, 21)
        Me.LblQteModem.TabIndex = 38
        Me.LblQteModem.Text = "0"
        '
        'LblQteInternet
        '
        Me.LblQteInternet.AutoSize = True
        Me.LblQteInternet.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQteInternet.ForeColor = System.Drawing.Color.Black
        Me.LblQteInternet.Location = New System.Drawing.Point(443, 400)
        Me.LblQteInternet.Name = "LblQteInternet"
        Me.LblQteInternet.Size = New System.Drawing.Size(19, 21)
        Me.LblQteInternet.TabIndex = 39
        Me.LblQteInternet.Text = "0"
        '
        'LblPrixMicroOrdiF
        '
        Me.LblPrixMicroOrdiF.AutoSize = True
        Me.LblPrixMicroOrdiF.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixMicroOrdiF.Location = New System.Drawing.Point(278, 337)
        Me.LblPrixMicroOrdiF.Name = "LblPrixMicroOrdiF"
        Me.LblPrixMicroOrdiF.Size = New System.Drawing.Size(41, 21)
        Me.LblPrixMicroOrdiF.TabIndex = 40
        Me.LblPrixMicroOrdiF.Text = "0.00"
        '
        'LblPrixModemF
        '
        Me.LblPrixModemF.AutoSize = True
        Me.LblPrixModemF.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixModemF.Location = New System.Drawing.Point(278, 369)
        Me.LblPrixModemF.Name = "LblPrixModemF"
        Me.LblPrixModemF.Size = New System.Drawing.Size(41, 21)
        Me.LblPrixModemF.TabIndex = 41
        Me.LblPrixModemF.Text = "0.00"
        '
        'LblPrixInternetF
        '
        Me.LblPrixInternetF.AutoSize = True
        Me.LblPrixInternetF.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixInternetF.Location = New System.Drawing.Point(277, 399)
        Me.LblPrixInternetF.Name = "LblPrixInternetF"
        Me.LblPrixInternetF.Size = New System.Drawing.Size(41, 21)
        Me.LblPrixInternetF.TabIndex = 42
        Me.LblPrixInternetF.Text = "0.00"
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
        'LblSousTotal
        '
        Me.LblSousTotal.AutoSize = True
        Me.LblSousTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSousTotal.Location = New System.Drawing.Point(276, 442)
        Me.LblSousTotal.Name = "LblSousTotal"
        Me.LblSousTotal.Size = New System.Drawing.Size(50, 21)
        Me.LblSousTotal.TabIndex = 47
        Me.LblSousTotal.Text = "$0.00"
        '
        'LblTPS
        '
        Me.LblTPS.AutoSize = True
        Me.LblTPS.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTPS.Location = New System.Drawing.Point(276, 472)
        Me.LblTPS.Name = "LblTPS"
        Me.LblTPS.Size = New System.Drawing.Size(50, 21)
        Me.LblTPS.TabIndex = 48
        Me.LblTPS.Text = "$0.00"
        '
        'LblTVQ
        '
        Me.LblTVQ.AutoSize = True
        Me.LblTVQ.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTVQ.Location = New System.Drawing.Point(277, 502)
        Me.LblTVQ.Name = "LblTVQ"
        Me.LblTVQ.Size = New System.Drawing.Size(50, 21)
        Me.LblTVQ.TabIndex = 49
        Me.LblTVQ.Text = "$0.00"
        '
        'LblPrixTotalF
        '
        Me.LblPrixTotalF.AutoSize = True
        Me.LblPrixTotalF.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixTotalF.Location = New System.Drawing.Point(276, 533)
        Me.LblPrixTotalF.Name = "LblPrixTotalF"
        Me.LblPrixTotalF.Size = New System.Drawing.Size(61, 25)
        Me.LblPrixTotalF.TabIndex = 50
        Me.LblPrixTotalF.Text = "$0.00"
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
        'GroupBoxFacture
        '
        Me.GroupBoxFacture.Controls.Add(Me.DateTimePickerFacture)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBox3)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBox2)
        Me.GroupBoxFacture.Controls.Add(Me.LblQteModem)
        Me.GroupBoxFacture.Controls.Add(Me.LblQteMicroOrdinateur)
        Me.GroupBoxFacture.Controls.Add(Me.LblQteInternet)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(3, -1)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Size = New System.Drawing.Size(752, 635)
        Me.GroupBoxFacture.TabIndex = 53
        Me.GroupBoxFacture.TabStop = False
        Me.GroupBoxFacture.Text = "Facture"
        '
        'DateTimePickerFacture
        '
        Me.DateTimePickerFacture.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFacture.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight
        Me.DateTimePickerFacture.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerFacture.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFacture.Location = New System.Drawing.Point(189, 102)
        Me.DateTimePickerFacture.Name = "DateTimePickerFacture"
        Me.DateTimePickerFacture.Size = New System.Drawing.Size(154, 25)
        Me.DateTimePickerFacture.TabIndex = 15
        Me.DateTimePickerFacture.Value = New Date(2021, 4, 3, 0, 0, 0, 0)
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
        'FrmFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 627)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.BttnPayement)
        Me.Controls.Add(Me.LblPrixTotalF)
        Me.Controls.Add(Me.LblTVQ)
        Me.Controls.Add(Me.LblTPS)
        Me.Controls.Add(Me.LblSousTotal)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelTVQ)
        Me.Controls.Add(Me.LabelTPS)
        Me.Controls.Add(Me.LabelSousTotal)
        Me.Controls.Add(Me.LblPrixInternetF)
        Me.Controls.Add(Me.LblPrixModemF)
        Me.Controls.Add(Me.LblPrixMicroOrdiF)
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
        Me.Controls.Add(Me.TextBoxCodeClient)
        Me.Controls.Add(Me.TextBoxNFacture)
        Me.Controls.Add(Me.LblDateFacture)
        Me.Controls.Add(Me.LblCodeClient)
        Me.Controls.Add(Me.LblNFacture)
        Me.Controls.Add(Me.GroupBoxFacture)
        Me.Name = "FrmFacture"
        Me.Text = "FrmFacture"
        Me.GroupBoxFacture.ResumeLayout(False)
        Me.GroupBoxFacture.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblNFacture As Label
    Friend WithEvents LblCodeClient As Label
    Friend WithEvents LblDateFacture As Label
    Friend WithEvents TextBoxNFacture As TextBox
    Friend WithEvents TextBoxCodeClient As TextBox
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
    Friend WithEvents LblQteMicroOrdinateur As Label
    Friend WithEvents LblQteModem As Label
    Friend WithEvents LblQteInternet As Label
    Friend WithEvents LblPrixMicroOrdiF As Label
    Friend WithEvents LblPrixModemF As Label
    Friend WithEvents LblPrixInternetF As Label
    Friend WithEvents LabelSousTotal As Label
    Friend WithEvents LabelTPS As Label
    Friend WithEvents LabelTVQ As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LblSousTotal As Label
    Friend WithEvents LblTPS As Label
    Friend WithEvents LblTVQ As Label
    Friend WithEvents LblPrixTotalF As Label
    Friend WithEvents BttnPayement As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePickerFacture As DateTimePicker
End Class
