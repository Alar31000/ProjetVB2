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
        Me.LblDateFacture = New System.Windows.Forms.Label()
        Me.TextBoxNFacture = New System.Windows.Forms.TextBox()
        Me.LabelPrénom = New System.Windows.Forms.Label()
        Me.LblCode_postal = New System.Windows.Forms.Label()
        Me.LabelAdresseL = New System.Windows.Forms.Label()
        Me.LabelCode_postalA = New System.Windows.Forms.Label()
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
        Me.GroupBoxFacture = New System.Windows.Forms.GroupBox()
        Me.DateTimePickerFacture = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBoxFacture.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNFacture
        '
        Me.LblNFacture.AutoSize = True
        Me.LblNFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNFacture.ForeColor = System.Drawing.Color.Black
        Me.LblNFacture.Location = New System.Drawing.Point(204, 19)
        Me.LblNFacture.Name = "LblNFacture"
        Me.LblNFacture.Size = New System.Drawing.Size(122, 21)
        Me.LblNFacture.TabIndex = 15
        Me.LblNFacture.Text = "Numéro Facture"
        '
        'LblDateFacture
        '
        Me.LblDateFacture.AutoSize = True
        Me.LblDateFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDateFacture.ForeColor = System.Drawing.Color.Black
        Me.LblDateFacture.Location = New System.Drawing.Point(15, 59)
        Me.LblDateFacture.Name = "LblDateFacture"
        Me.LblDateFacture.Size = New System.Drawing.Size(96, 21)
        Me.LblDateFacture.TabIndex = 17
        Me.LblDateFacture.Text = "Date Facture"
        '
        'TextBoxNFacture
        '
        Me.TextBoxNFacture.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBoxNFacture.Location = New System.Drawing.Point(357, 13)
        Me.TextBoxNFacture.Name = "TextBoxNFacture"
        Me.TextBoxNFacture.Size = New System.Drawing.Size(154, 33)
        Me.TextBoxNFacture.TabIndex = 18
        '
        'LabelPrénom
        '
        Me.LabelPrénom.AutoSize = True
        Me.LabelPrénom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrénom.ForeColor = System.Drawing.Color.Black
        Me.LabelPrénom.Location = New System.Drawing.Point(-4, 64)
        Me.LabelPrénom.Name = "LabelPrénom"
        Me.LabelPrénom.Size = New System.Drawing.Size(65, 21)
        Me.LabelPrénom.TabIndex = 21
        Me.LabelPrénom.Text = "Prénom"
        '
        'LblCode_postal
        '
        Me.LblCode_postal.AutoSize = True
        Me.LblCode_postal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCode_postal.ForeColor = System.Drawing.Color.Black
        Me.LblCode_postal.Location = New System.Drawing.Point(-4, 138)
        Me.LblCode_postal.Name = "LblCode_postal"
        Me.LblCode_postal.Size = New System.Drawing.Size(99, 21)
        Me.LblCode_postal.TabIndex = 22
        Me.LblCode_postal.Text = "Code Postale"
        '
        'LabelAdresseL
        '
        Me.LabelAdresseL.AutoSize = True
        Me.LabelAdresseL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdresseL.ForeColor = System.Drawing.Color.Black
        Me.LabelAdresseL.Location = New System.Drawing.Point(6, 21)
        Me.LabelAdresseL.Name = "LabelAdresseL"
        Me.LabelAdresseL.Size = New System.Drawing.Size(65, 21)
        Me.LabelAdresseL.TabIndex = 25
        Me.LabelAdresseL.Text = "Adresse"
        '
        'LabelCode_postalA
        '
        Me.LabelCode_postalA.AutoSize = True
        Me.LabelCode_postalA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCode_postalA.ForeColor = System.Drawing.Color.Black
        Me.LabelCode_postalA.Location = New System.Drawing.Point(6, 48)
        Me.LabelCode_postalA.Name = "LabelCode_postalA"
        Me.LabelCode_postalA.Size = New System.Drawing.Size(99, 21)
        Me.LabelCode_postalA.TabIndex = 26
        Me.LabelCode_postalA.Text = "Code Postale"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(98, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(154, 25)
        Me.TextBox1.TabIndex = 27
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(98, 64)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(154, 25)
        Me.TextBox2.TabIndex = 28
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(111, 17)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 25)
        Me.TextBox4.TabIndex = 29
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(111, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(166, 25)
        Me.TextBox5.TabIndex = 30
        '
        'LabelRProduit
        '
        Me.LabelRProduit.AutoSize = True
        Me.LabelRProduit.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRProduit.ForeColor = System.Drawing.Color.Navy
        Me.LabelRProduit.Location = New System.Drawing.Point(18, 311)
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
        Me.LabelQuantité.Location = New System.Drawing.Point(430, 311)
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
        Me.LabelPrix.Location = New System.Drawing.Point(274, 311)
        Me.LabelPrix.Name = "LabelPrix"
        Me.LabelPrix.Size = New System.Drawing.Size(40, 21)
        Me.LabelPrix.TabIndex = 33
        Me.LabelPrix.Text = "Prix"
        '
        'LabelMOrdi
        '
        Me.LabelMOrdi.AutoSize = True
        Me.LabelMOrdi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMOrdi.ForeColor = System.Drawing.Color.Black
        Me.LabelMOrdi.Location = New System.Drawing.Point(18, 338)
        Me.LabelMOrdi.Name = "LabelMOrdi"
        Me.LabelMOrdi.Size = New System.Drawing.Size(129, 21)
        Me.LabelMOrdi.TabIndex = 34
        Me.LabelMOrdi.Text = "Micro-ordinateur"
        '
        'LabelModem
        '
        Me.LabelModem.AutoSize = True
        Me.LabelModem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModem.ForeColor = System.Drawing.Color.Black
        Me.LabelModem.Location = New System.Drawing.Point(18, 359)
        Me.LabelModem.Name = "LabelModem"
        Me.LabelModem.Size = New System.Drawing.Size(64, 21)
        Me.LabelModem.TabIndex = 35
        Me.LabelModem.Text = "Modem"
        '
        'LabelLInternet
        '
        Me.LabelLInternet.AutoSize = True
        Me.LabelLInternet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLInternet.ForeColor = System.Drawing.Color.Black
        Me.LabelLInternet.Location = New System.Drawing.Point(18, 380)
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
        Me.LblQteMicroOrdinateur.Location = New System.Drawing.Point(430, 338)
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
        Me.LblQteModem.Location = New System.Drawing.Point(430, 359)
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
        Me.LblQteInternet.Location = New System.Drawing.Point(430, 380)
        Me.LblQteInternet.Name = "LblQteInternet"
        Me.LblQteInternet.Size = New System.Drawing.Size(19, 21)
        Me.LblQteInternet.TabIndex = 39
        Me.LblQteInternet.Text = "0"
        '
        'LblPrixMicroOrdiF
        '
        Me.LblPrixMicroOrdiF.AutoSize = True
        Me.LblPrixMicroOrdiF.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixMicroOrdiF.Location = New System.Drawing.Point(274, 338)
        Me.LblPrixMicroOrdiF.Name = "LblPrixMicroOrdiF"
        Me.LblPrixMicroOrdiF.Size = New System.Drawing.Size(41, 21)
        Me.LblPrixMicroOrdiF.TabIndex = 40
        Me.LblPrixMicroOrdiF.Text = "0.00"
        '
        'LblPrixModemF
        '
        Me.LblPrixModemF.AutoSize = True
        Me.LblPrixModemF.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixModemF.Location = New System.Drawing.Point(274, 359)
        Me.LblPrixModemF.Name = "LblPrixModemF"
        Me.LblPrixModemF.Size = New System.Drawing.Size(41, 21)
        Me.LblPrixModemF.TabIndex = 41
        Me.LblPrixModemF.Text = "0.00"
        '
        'LblPrixInternetF
        '
        Me.LblPrixInternetF.AutoSize = True
        Me.LblPrixInternetF.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixInternetF.Location = New System.Drawing.Point(274, 380)
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
        Me.LabelSousTotal.Location = New System.Drawing.Point(14, 443)
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
        Me.LabelTPS.Location = New System.Drawing.Point(15, 473)
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
        Me.LabelTVQ.Location = New System.Drawing.Point(15, 503)
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
        Me.LabelTotal.Location = New System.Drawing.Point(14, 533)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(53, 21)
        Me.LabelTotal.TabIndex = 46
        Me.LabelTotal.Text = "TOTAL"
        '
        'LblSousTotal
        '
        Me.LblSousTotal.AutoSize = True
        Me.LblSousTotal.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSousTotal.Location = New System.Drawing.Point(274, 443)
        Me.LblSousTotal.Name = "LblSousTotal"
        Me.LblSousTotal.Size = New System.Drawing.Size(50, 21)
        Me.LblSousTotal.TabIndex = 47
        Me.LblSousTotal.Text = "$0.00"
        '
        'LblTPS
        '
        Me.LblTPS.AutoSize = True
        Me.LblTPS.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTPS.Location = New System.Drawing.Point(274, 473)
        Me.LblTPS.Name = "LblTPS"
        Me.LblTPS.Size = New System.Drawing.Size(50, 21)
        Me.LblTPS.TabIndex = 48
        Me.LblTPS.Text = "$0.00"
        '
        'LblTVQ
        '
        Me.LblTVQ.AutoSize = True
        Me.LblTVQ.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTVQ.Location = New System.Drawing.Point(274, 503)
        Me.LblTVQ.Name = "LblTVQ"
        Me.LblTVQ.Size = New System.Drawing.Size(50, 21)
        Me.LblTVQ.TabIndex = 49
        Me.LblTVQ.Text = "$0.00"
        '
        'LblPrixTotalF
        '
        Me.LblPrixTotalF.AutoSize = True
        Me.LblPrixTotalF.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrixTotalF.Location = New System.Drawing.Point(273, 530)
        Me.LblPrixTotalF.Name = "LblPrixTotalF"
        Me.LblPrixTotalF.Size = New System.Drawing.Size(61, 25)
        Me.LblPrixTotalF.TabIndex = 50
        Me.LblPrixTotalF.Text = "$0.00"
        '
        'BttnPayement
        '
        Me.BttnPayement.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.BttnPayement.ForeColor = System.Drawing.Color.Navy
        Me.BttnPayement.Location = New System.Drawing.Point(598, 562)
        Me.BttnPayement.Name = "BttnPayement"
        Me.BttnPayement.Size = New System.Drawing.Size(114, 33)
        Me.BttnPayement.TabIndex = 51
        Me.BttnPayement.Text = "PAYEMENT"
        Me.BttnPayement.UseVisualStyleBackColor = True
        '
        'GroupBoxFacture
        '
        Me.GroupBoxFacture.Controls.Add(Me.LabelQuantité)
        Me.GroupBoxFacture.Controls.Add(Me.LblPrixTotalF)
        Me.GroupBoxFacture.Controls.Add(Me.BttnPayement)
        Me.GroupBoxFacture.Controls.Add(Me.LblTVQ)
        Me.GroupBoxFacture.Controls.Add(Me.DateTimePickerFacture)
        Me.GroupBoxFacture.Controls.Add(Me.LblTPS)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBox3)
        Me.GroupBoxFacture.Controls.Add(Me.LblPrixInternetF)
        Me.GroupBoxFacture.Controls.Add(Me.GroupBox2)
        Me.GroupBoxFacture.Controls.Add(Me.LblPrixModemF)
        Me.GroupBoxFacture.Controls.Add(Me.LblQteModem)
        Me.GroupBoxFacture.Controls.Add(Me.LblPrixMicroOrdiF)
        Me.GroupBoxFacture.Controls.Add(Me.LblSousTotal)
        Me.GroupBoxFacture.Controls.Add(Me.LblQteMicroOrdinateur)
        Me.GroupBoxFacture.Controls.Add(Me.LabelTotal)
        Me.GroupBoxFacture.Controls.Add(Me.LabelPrix)
        Me.GroupBoxFacture.Controls.Add(Me.LblQteInternet)
        Me.GroupBoxFacture.Controls.Add(Me.LabelTVQ)
        Me.GroupBoxFacture.Controls.Add(Me.LblDateFacture)
        Me.GroupBoxFacture.Controls.Add(Me.LabelTPS)
        Me.GroupBoxFacture.Controls.Add(Me.TextBoxNFacture)
        Me.GroupBoxFacture.Controls.Add(Me.LabelSousTotal)
        Me.GroupBoxFacture.Controls.Add(Me.LblNFacture)
        Me.GroupBoxFacture.Controls.Add(Me.LabelRProduit)
        Me.GroupBoxFacture.Controls.Add(Me.LabelMOrdi)
        Me.GroupBoxFacture.Controls.Add(Me.LabelModem)
        Me.GroupBoxFacture.Controls.Add(Me.LabelLInternet)
        Me.GroupBoxFacture.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFacture.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxFacture.Location = New System.Drawing.Point(3, -1)
        Me.GroupBoxFacture.Name = "GroupBoxFacture"
        Me.GroupBoxFacture.Size = New System.Drawing.Size(759, 627)
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
        Me.DateTimePickerFacture.Location = New System.Drawing.Point(117, 59)
        Me.DateTimePickerFacture.Name = "DateTimePickerFacture"
        Me.DateTimePickerFacture.Size = New System.Drawing.Size(154, 25)
        Me.DateTimePickerFacture.TabIndex = 15
        Me.DateTimePickerFacture.Value = New Date(2021, 4, 3, 0, 0, 0, 0)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelAdresseL)
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.LabelCode_postalA)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(435, 59)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 85)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Abonnet"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.LabelAdresse)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.LabelPrénom)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.LblCode_postal)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(19, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 174)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adresse de Facturation"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(98, 138)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(154, 25)
        Me.TextBox6.TabIndex = 31
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(98, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(154, 25)
        Me.TextBox3.TabIndex = 30
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAdresse.ForeColor = System.Drawing.Color.Black
        Me.LabelAdresse.Location = New System.Drawing.Point(-4, 100)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(65, 21)
        Me.LabelAdresse.TabIndex = 29
        Me.LabelAdresse.Text = "Adresse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-4, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 21)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nom"
        '
        'FrmFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 609)
        Me.Controls.Add(Me.GroupBoxFacture)
        Me.Name = "FrmFacture"
        Me.Text = "FrmFacture"
        Me.GroupBoxFacture.ResumeLayout(False)
        Me.GroupBoxFacture.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblNFacture As Label
    Friend WithEvents LblDateFacture As Label
    Friend WithEvents TextBoxNFacture As TextBox
    Friend WithEvents LabelPrénom As Label
    Friend WithEvents LblCode_postal As Label
    Friend WithEvents LabelAdresseL As Label
    Friend WithEvents LabelCode_postalA As Label
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
    Friend WithEvents GroupBoxFacture As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePickerFacture As DateTimePicker
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents Label1 As Label
End Class
