<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModiferFournisseur
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
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnChercher = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxCompte = New System.Windows.Forms.TextBox()
        Me.TxtBoxCodeBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxVilleBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxAdresseBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxNomBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxNomComptable = New System.Windows.Forms.TextBox()
        Me.LabelCompte = New System.Windows.Forms.Label()
        Me.LabelCodeBanque = New System.Windows.Forms.Label()
        Me.labelVillebanque = New System.Windows.Forms.Label()
        Me.LabelAdresseBanque = New System.Windows.Forms.Label()
        Me.LabelNomBanque = New System.Windows.Forms.Label()
        Me.LabelNomComptable = New System.Windows.Forms.Label()
        Me.BoxContactFournisseur = New System.Windows.Forms.GroupBox()
        Me.TxtBoxAdresse = New System.Windows.Forms.TextBox()
        Me.TxtBoxVille = New System.Windows.Forms.TextBox()
        Me.TxtBoxProvince = New System.Windows.Forms.TextBox()
        Me.TxtBoxCodePostal = New System.Windows.Forms.TextBox()
        Me.TxtBoxPays = New System.Windows.Forms.TextBox()
        Me.TxtBoxTéléphone1 = New System.Windows.Forms.TextBox()
        Me.TxtBoxTéléphone2 = New System.Windows.Forms.TextBox()
        Me.TxtBoxFax = New System.Windows.Forms.TextBox()
        Me.TxtBoxSiteWeb = New System.Windows.Forms.TextBox()
        Me.LabelSiteWeb = New System.Windows.Forms.Label()
        Me.LabelFax = New System.Windows.Forms.Label()
        Me.LabelTel2 = New System.Windows.Forms.Label()
        Me.LabelTel1 = New System.Windows.Forms.Label()
        Me.LabelPays = New System.Windows.Forms.Label()
        Me.LabelCodePostal = New System.Windows.Forms.Label()
        Me.LabelProvince = New System.Windows.Forms.Label()
        Me.TxtBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelNoCompte = New System.Windows.Forms.Label()
        Me.TxtBoxFonction = New System.Windows.Forms.TextBox()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.LabelSocieté = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.TxtBoxContact = New System.Windows.Forms.TextBox()
        Me.LabelContact = New System.Windows.Forms.Label()
        Me.TxtBoxSocieté = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelFonction = New System.Windows.Forms.Label()
        Me.TxtBoxNoCompte = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.BoxContactFournisseur.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(755, 219)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(167, 37)
        Me.BtnSupprimer.TabIndex = 51
        Me.BtnSupprimer.Text = "Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Fuchsia
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(254, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 23)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Modifier / Supprimer fournisseur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(755, 399)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(167, 37)
        Me.BtnQuitter.TabIndex = 48
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.Location = New System.Drawing.Point(755, 290)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(167, 37)
        Me.BtnAnnuler.TabIndex = 47
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.Location = New System.Drawing.Point(755, 145)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(167, 37)
        Me.BtnModifier.TabIndex = 46
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnChercher
        '
        Me.BtnChercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChercher.Location = New System.Drawing.Point(755, 66)
        Me.BtnChercher.Name = "BtnChercher"
        Me.BtnChercher.Size = New System.Drawing.Size(167, 37)
        Me.BtnChercher.TabIndex = 45
        Me.BtnChercher.Text = "Chercher"
        Me.BtnChercher.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Controls.Add(Me.TxtBoxCompte)
        Me.GroupBox1.Controls.Add(Me.TxtBoxCodeBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxVilleBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxAdresseBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNomBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNomComptable)
        Me.GroupBox1.Controls.Add(Me.LabelCompte)
        Me.GroupBox1.Controls.Add(Me.LabelCodeBanque)
        Me.GroupBox1.Controls.Add(Me.labelVillebanque)
        Me.GroupBox1.Controls.Add(Me.LabelAdresseBanque)
        Me.GroupBox1.Controls.Add(Me.LabelNomBanque)
        Me.GroupBox1.Controls.Add(Me.LabelNomComptable)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 129)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information du compte"
        '
        'TxtBoxCompte
        '
        Me.TxtBoxCompte.Location = New System.Drawing.Point(507, 93)
        Me.TxtBoxCompte.Name = "TxtBoxCompte"
        Me.TxtBoxCompte.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxCompte.TabIndex = 35
        '
        'TxtBoxCodeBanque
        '
        Me.TxtBoxCodeBanque.Location = New System.Drawing.Point(507, 59)
        Me.TxtBoxCodeBanque.Name = "TxtBoxCodeBanque"
        Me.TxtBoxCodeBanque.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxCodeBanque.TabIndex = 34
        '
        'TxtBoxVilleBanque
        '
        Me.TxtBoxVilleBanque.Location = New System.Drawing.Point(507, 24)
        Me.TxtBoxVilleBanque.Name = "TxtBoxVilleBanque"
        Me.TxtBoxVilleBanque.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxVilleBanque.TabIndex = 33
        '
        'TxtBoxAdresseBanque
        '
        Me.TxtBoxAdresseBanque.Location = New System.Drawing.Point(177, 97)
        Me.TxtBoxAdresseBanque.Name = "TxtBoxAdresseBanque"
        Me.TxtBoxAdresseBanque.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxAdresseBanque.TabIndex = 32
        '
        'TxtBoxNomBanque
        '
        Me.TxtBoxNomBanque.Location = New System.Drawing.Point(177, 55)
        Me.TxtBoxNomBanque.Name = "TxtBoxNomBanque"
        Me.TxtBoxNomBanque.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxNomBanque.TabIndex = 31
        '
        'TxtBoxNomComptable
        '
        Me.TxtBoxNomComptable.Location = New System.Drawing.Point(177, 17)
        Me.TxtBoxNomComptable.Name = "TxtBoxNomComptable"
        Me.TxtBoxNomComptable.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxNomComptable.TabIndex = 30
        '
        'LabelCompte
        '
        Me.LabelCompte.AutoSize = True
        Me.LabelCompte.Location = New System.Drawing.Point(395, 100)
        Me.LabelCompte.Name = "LabelCompte"
        Me.LabelCompte.Size = New System.Drawing.Size(104, 13)
        Me.LabelCompte.TabIndex = 5
        Me.LabelCompte.Text = "Numero du Compte :"
        '
        'LabelCodeBanque
        '
        Me.LabelCodeBanque.AutoSize = True
        Me.LabelCodeBanque.Location = New System.Drawing.Point(395, 66)
        Me.LabelCodeBanque.Name = "LabelCodeBanque"
        Me.LabelCodeBanque.Size = New System.Drawing.Size(78, 13)
        Me.LabelCodeBanque.TabIndex = 4
        Me.LabelCodeBanque.Text = "Code Banque :"
        '
        'labelVillebanque
        '
        Me.labelVillebanque.AutoSize = True
        Me.labelVillebanque.Location = New System.Drawing.Point(399, 24)
        Me.labelVillebanque.Name = "labelVillebanque"
        Me.labelVillebanque.Size = New System.Drawing.Size(32, 13)
        Me.labelVillebanque.TabIndex = 29
        Me.labelVillebanque.Text = "Ville :"
        '
        'LabelAdresseBanque
        '
        Me.LabelAdresseBanque.AutoSize = True
        Me.LabelAdresseBanque.Location = New System.Drawing.Point(20, 100)
        Me.LabelAdresseBanque.Name = "LabelAdresseBanque"
        Me.LabelAdresseBanque.Size = New System.Drawing.Size(51, 13)
        Me.LabelAdresseBanque.TabIndex = 28
        Me.LabelAdresseBanque.Text = "Adresse :"
        '
        'LabelNomBanque
        '
        Me.LabelNomBanque.AutoSize = True
        Me.LabelNomBanque.Location = New System.Drawing.Point(21, 62)
        Me.LabelNomBanque.Name = "LabelNomBanque"
        Me.LabelNomBanque.Size = New System.Drawing.Size(100, 13)
        Me.LabelNomBanque.TabIndex = 27
        Me.LabelNomBanque.Text = "Nom de la banque :"
        '
        'LabelNomComptable
        '
        Me.LabelNomComptable.AutoSize = True
        Me.LabelNomComptable.Location = New System.Drawing.Point(21, 24)
        Me.LabelNomComptable.Name = "LabelNomComptable"
        Me.LabelNomComptable.Size = New System.Drawing.Size(102, 13)
        Me.LabelNomComptable.TabIndex = 26
        Me.LabelNomComptable.Text = "Nom du comptable :"
        '
        'BoxContactFournisseur
        '
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxAdresse)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxVille)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxProvince)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxCodePostal)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxPays)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxTéléphone1)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxTéléphone2)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxFax)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxSiteWeb)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelSiteWeb)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelFax)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelTel2)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelTel1)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelPays)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelCodePostal)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelProvince)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxEmail)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelNoCompte)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxFonction)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelVille)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelSocieté)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelAdresse)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxContact)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelContact)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxSocieté)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelEmail)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelFonction)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxNoCompte)
        Me.BoxContactFournisseur.ForeColor = System.Drawing.Color.Black
        Me.BoxContactFournisseur.Location = New System.Drawing.Point(12, 30)
        Me.BoxContactFournisseur.Name = "BoxContactFournisseur"
        Me.BoxContactFournisseur.Size = New System.Drawing.Size(709, 281)
        Me.BoxContactFournisseur.TabIndex = 43
        Me.BoxContactFournisseur.TabStop = False
        Me.BoxContactFournisseur.Text = "Information  Fournisseur"
        '
        'TxtBoxAdresse
        '
        Me.TxtBoxAdresse.Location = New System.Drawing.Point(177, 211)
        Me.TxtBoxAdresse.Name = "TxtBoxAdresse"
        Me.TxtBoxAdresse.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxAdresse.TabIndex = 17
        '
        'TxtBoxVille
        '
        Me.TxtBoxVille.Location = New System.Drawing.Point(177, 244)
        Me.TxtBoxVille.Name = "TxtBoxVille"
        Me.TxtBoxVille.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxVille.TabIndex = 18
        '
        'TxtBoxProvince
        '
        Me.TxtBoxProvince.Location = New System.Drawing.Point(507, 15)
        Me.TxtBoxProvince.Name = "TxtBoxProvince"
        Me.TxtBoxProvince.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxProvince.TabIndex = 19
        '
        'TxtBoxCodePostal
        '
        Me.TxtBoxCodePostal.Location = New System.Drawing.Point(507, 54)
        Me.TxtBoxCodePostal.Name = "TxtBoxCodePostal"
        Me.TxtBoxCodePostal.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxCodePostal.TabIndex = 20
        '
        'TxtBoxPays
        '
        Me.TxtBoxPays.Location = New System.Drawing.Point(507, 94)
        Me.TxtBoxPays.Name = "TxtBoxPays"
        Me.TxtBoxPays.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxPays.TabIndex = 21
        '
        'TxtBoxTéléphone1
        '
        Me.TxtBoxTéléphone1.Location = New System.Drawing.Point(507, 133)
        Me.TxtBoxTéléphone1.Name = "TxtBoxTéléphone1"
        Me.TxtBoxTéléphone1.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxTéléphone1.TabIndex = 22
        '
        'TxtBoxTéléphone2
        '
        Me.TxtBoxTéléphone2.Location = New System.Drawing.Point(507, 169)
        Me.TxtBoxTéléphone2.Name = "TxtBoxTéléphone2"
        Me.TxtBoxTéléphone2.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxTéléphone2.TabIndex = 23
        '
        'TxtBoxFax
        '
        Me.TxtBoxFax.Location = New System.Drawing.Point(507, 207)
        Me.TxtBoxFax.Name = "TxtBoxFax"
        Me.TxtBoxFax.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxFax.TabIndex = 24
        '
        'TxtBoxSiteWeb
        '
        Me.TxtBoxSiteWeb.Location = New System.Drawing.Point(507, 244)
        Me.TxtBoxSiteWeb.Name = "TxtBoxSiteWeb"
        Me.TxtBoxSiteWeb.Size = New System.Drawing.Size(176, 20)
        Me.TxtBoxSiteWeb.TabIndex = 25
        '
        'LabelSiteWeb
        '
        Me.LabelSiteWeb.AutoSize = True
        Me.LabelSiteWeb.Location = New System.Drawing.Point(395, 247)
        Me.LabelSiteWeb.Name = "LabelSiteWeb"
        Me.LabelSiteWeb.Size = New System.Drawing.Size(57, 13)
        Me.LabelSiteWeb.TabIndex = 22
        Me.LabelSiteWeb.Text = "Site-Web :"
        '
        'LabelFax
        '
        Me.LabelFax.AutoSize = True
        Me.LabelFax.Location = New System.Drawing.Point(395, 214)
        Me.LabelFax.Name = "LabelFax"
        Me.LabelFax.Size = New System.Drawing.Size(30, 13)
        Me.LabelFax.TabIndex = 21
        Me.LabelFax.Text = "Fax :"
        '
        'LabelTel2
        '
        Me.LabelTel2.AutoSize = True
        Me.LabelTel2.Location = New System.Drawing.Point(395, 180)
        Me.LabelTel2.Name = "LabelTel2"
        Me.LabelTel2.Size = New System.Drawing.Size(73, 13)
        Me.LabelTel2.TabIndex = 20
        Me.LabelTel2.Text = "Téléphone 2 :"
        '
        'LabelTel1
        '
        Me.LabelTel1.AutoSize = True
        Me.LabelTel1.Location = New System.Drawing.Point(395, 143)
        Me.LabelTel1.Name = "LabelTel1"
        Me.LabelTel1.Size = New System.Drawing.Size(73, 13)
        Me.LabelTel1.TabIndex = 19
        Me.LabelTel1.Text = "Téléphone 1 :"
        '
        'LabelPays
        '
        Me.LabelPays.AutoSize = True
        Me.LabelPays.Location = New System.Drawing.Point(395, 101)
        Me.LabelPays.Name = "LabelPays"
        Me.LabelPays.Size = New System.Drawing.Size(36, 13)
        Me.LabelPays.TabIndex = 18
        Me.LabelPays.Text = "Pays :"
        '
        'LabelCodePostal
        '
        Me.LabelCodePostal.AutoSize = True
        Me.LabelCodePostal.Location = New System.Drawing.Point(395, 61)
        Me.LabelCodePostal.Name = "LabelCodePostal"
        Me.LabelCodePostal.Size = New System.Drawing.Size(69, 13)
        Me.LabelCodePostal.TabIndex = 17
        Me.LabelCodePostal.Text = "Code postal :"
        '
        'LabelProvince
        '
        Me.LabelProvince.AutoSize = True
        Me.LabelProvince.Location = New System.Drawing.Point(395, 26)
        Me.LabelProvince.Name = "LabelProvince"
        Me.LabelProvince.Size = New System.Drawing.Size(55, 13)
        Me.LabelProvince.TabIndex = 16
        Me.LabelProvince.Text = "Province :"
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(177, 173)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxEmail.TabIndex = 4
        '
        'LabelNoCompte
        '
        Me.LabelNoCompte.AutoSize = True
        Me.LabelNoCompte.Location = New System.Drawing.Point(21, 30)
        Me.LabelNoCompte.Name = "LabelNoCompte"
        Me.LabelNoCompte.Size = New System.Drawing.Size(81, 13)
        Me.LabelNoCompte.TabIndex = 0
        Me.LabelNoCompte.Text = "No de Compte :"
        '
        'TxtBoxFonction
        '
        Me.TxtBoxFonction.Location = New System.Drawing.Point(177, 133)
        Me.TxtBoxFonction.Name = "TxtBoxFonction"
        Me.TxtBoxFonction.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxFonction.TabIndex = 3
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Location = New System.Drawing.Point(21, 251)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(32, 13)
        Me.LabelVille.TabIndex = 6
        Me.LabelVille.Text = "Ville: "
        '
        'LabelSocieté
        '
        Me.LabelSocieté.AutoSize = True
        Me.LabelSocieté.Location = New System.Drawing.Point(21, 65)
        Me.LabelSocieté.Name = "LabelSocieté"
        Me.LabelSocieté.Size = New System.Drawing.Size(49, 13)
        Me.LabelSocieté.TabIndex = 1
        Me.LabelSocieté.Text = "Societé :"
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Location = New System.Drawing.Point(20, 218)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(54, 13)
        Me.LabelAdresse.TabIndex = 5
        Me.LabelAdresse.Text = "Adresse : "
        '
        'TxtBoxContact
        '
        Me.TxtBoxContact.Location = New System.Drawing.Point(177, 98)
        Me.TxtBoxContact.Name = "TxtBoxContact"
        Me.TxtBoxContact.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxContact.TabIndex = 2
        '
        'LabelContact
        '
        Me.LabelContact.AutoSize = True
        Me.LabelContact.Location = New System.Drawing.Point(20, 105)
        Me.LabelContact.Name = "LabelContact"
        Me.LabelContact.Size = New System.Drawing.Size(50, 13)
        Me.LabelContact.TabIndex = 2
        Me.LabelContact.Text = "Contact :"
        '
        'TxtBoxSocieté
        '
        Me.TxtBoxSocieté.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxSocieté.Location = New System.Drawing.Point(177, 58)
        Me.TxtBoxSocieté.Name = "TxtBoxSocieté"
        Me.TxtBoxSocieté.Size = New System.Drawing.Size(201, 20)
        Me.TxtBoxSocieté.TabIndex = 1
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(21, 180)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(41, 13)
        Me.LabelEmail.TabIndex = 4
        Me.LabelEmail.Text = "E-mail :"
        '
        'LabelFonction
        '
        Me.LabelFonction.AutoSize = True
        Me.LabelFonction.Location = New System.Drawing.Point(20, 140)
        Me.LabelFonction.Name = "LabelFonction"
        Me.LabelFonction.Size = New System.Drawing.Size(54, 13)
        Me.LabelFonction.TabIndex = 3
        Me.LabelFonction.Text = "Fonction :"
        '
        'TxtBoxNoCompte
        '
        Me.TxtBoxNoCompte.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.TxtBoxNoCompte.Location = New System.Drawing.Point(177, 23)
        Me.TxtBoxNoCompte.Name = "TxtBoxNoCompte"
        Me.TxtBoxNoCompte.Size = New System.Drawing.Size(195, 20)
        Me.TxtBoxNoCompte.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(740, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(193, 428)
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'FrmModiferFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 479)
        Me.Controls.Add(Me.BtnSupprimer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnChercher)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BoxContactFournisseur)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "FrmModiferFournisseur"
        Me.Text = "FrmModiferFournisseur"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BoxContactFournisseur.ResumeLayout(False)
        Me.BoxContactFournisseur.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnChercher As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBoxCompte As TextBox
    Friend WithEvents TxtBoxCodeBanque As TextBox
    Friend WithEvents TxtBoxVilleBanque As TextBox
    Friend WithEvents TxtBoxAdresseBanque As TextBox
    Friend WithEvents TxtBoxNomBanque As TextBox
    Friend WithEvents TxtBoxNomComptable As TextBox
    Friend WithEvents LabelCompte As Label
    Friend WithEvents LabelCodeBanque As Label
    Friend WithEvents labelVillebanque As Label
    Friend WithEvents LabelAdresseBanque As Label
    Friend WithEvents LabelNomBanque As Label
    Friend WithEvents LabelNomComptable As Label
    Friend WithEvents BoxContactFournisseur As GroupBox
    Friend WithEvents TxtBoxAdresse As TextBox
    Friend WithEvents TxtBoxVille As TextBox
    Friend WithEvents TxtBoxProvince As TextBox
    Friend WithEvents TxtBoxCodePostal As TextBox
    Friend WithEvents TxtBoxPays As TextBox
    Friend WithEvents TxtBoxTéléphone1 As TextBox
    Friend WithEvents TxtBoxTéléphone2 As TextBox
    Friend WithEvents TxtBoxFax As TextBox
    Friend WithEvents TxtBoxSiteWeb As TextBox
    Friend WithEvents LabelSiteWeb As Label
    Friend WithEvents LabelFax As Label
    Friend WithEvents LabelTel2 As Label
    Friend WithEvents LabelTel1 As Label
    Friend WithEvents LabelPays As Label
    Friend WithEvents LabelCodePostal As Label
    Friend WithEvents LabelProvince As Label
    Friend WithEvents TxtBoxEmail As TextBox
    Friend WithEvents LabelNoCompte As Label
    Friend WithEvents TxtBoxFonction As TextBox
    Friend WithEvents LabelVille As Label
    Friend WithEvents LabelSocieté As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents TxtBoxContact As TextBox
    Friend WithEvents LabelContact As Label
    Friend WithEvents TxtBoxSocieté As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelFonction As Label
    Friend WithEvents TxtBoxNoCompte As TextBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
