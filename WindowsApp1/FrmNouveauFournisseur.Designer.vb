<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNouveauFournisseur
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
        Me.Quitter = New System.Windows.Forms.Button()
        Me.BtnNouveau = New System.Windows.Forms.Button()
        Me.GroupBoxBanque = New System.Windows.Forms.GroupBox()
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
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnValider = New System.Windows.Forms.Button()
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
        Me.GroupBoxBanque.SuspendLayout()
        Me.BoxContactFournisseur.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 28)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Nouveau fournisseur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Quitter
        '
        Me.Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Quitter.Location = New System.Drawing.Point(911, 505)
        Me.Quitter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(180, 46)
        Me.Quitter.TabIndex = 47
        Me.Quitter.Text = "Quitter"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'BtnNouveau
        '
        Me.BtnNouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.BtnNouveau.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNouveau.Location = New System.Drawing.Point(911, 126)
        Me.BtnNouveau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNouveau.Name = "BtnNouveau"
        Me.BtnNouveau.Size = New System.Drawing.Size(180, 40)
        Me.BtnNouveau.TabIndex = 45
        Me.BtnNouveau.Text = "Nouveau"
        Me.BtnNouveau.UseVisualStyleBackColor = True
        '
        'GroupBoxBanque
        '
        Me.GroupBoxBanque.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBoxBanque.Controls.Add(Me.TxtBoxCompte)
        Me.GroupBoxBanque.Controls.Add(Me.TxtBoxCodeBanque)
        Me.GroupBoxBanque.Controls.Add(Me.TxtBoxVilleBanque)
        Me.GroupBoxBanque.Controls.Add(Me.TxtBoxAdresseBanque)
        Me.GroupBoxBanque.Controls.Add(Me.TxtBoxNomBanque)
        Me.GroupBoxBanque.Controls.Add(Me.TxtBoxNomComptable)
        Me.GroupBoxBanque.Controls.Add(Me.LabelCompte)
        Me.GroupBoxBanque.Controls.Add(Me.LabelCodeBanque)
        Me.GroupBoxBanque.Controls.Add(Me.labelVillebanque)
        Me.GroupBoxBanque.Controls.Add(Me.LabelAdresseBanque)
        Me.GroupBoxBanque.Controls.Add(Me.LabelNomBanque)
        Me.GroupBoxBanque.Controls.Add(Me.LabelNomComptable)
        Me.GroupBoxBanque.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBoxBanque.Location = New System.Drawing.Point(16, 433)
        Me.GroupBoxBanque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxBanque.Name = "GroupBoxBanque"
        Me.GroupBoxBanque.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxBanque.Size = New System.Drawing.Size(875, 156)
        Me.GroupBoxBanque.TabIndex = 44
        Me.GroupBoxBanque.TabStop = False
        Me.GroupBoxBanque.Text = "Information du compte"
        '
        'TxtBoxCompte
        '
        Me.TxtBoxCompte.Location = New System.Drawing.Point(629, 114)
        Me.TxtBoxCompte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxCompte.Name = "TxtBoxCompte"
        Me.TxtBoxCompte.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxCompte.TabIndex = 35
        '
        'TxtBoxCodeBanque
        '
        Me.TxtBoxCodeBanque.Location = New System.Drawing.Point(629, 73)
        Me.TxtBoxCodeBanque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxCodeBanque.Name = "TxtBoxCodeBanque"
        Me.TxtBoxCodeBanque.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxCodeBanque.TabIndex = 34
        '
        'TxtBoxVilleBanque
        '
        Me.TxtBoxVilleBanque.Location = New System.Drawing.Point(629, 26)
        Me.TxtBoxVilleBanque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxVilleBanque.Name = "TxtBoxVilleBanque"
        Me.TxtBoxVilleBanque.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxVilleBanque.TabIndex = 33
        '
        'TxtBoxAdresseBanque
        '
        Me.TxtBoxAdresseBanque.Location = New System.Drawing.Point(196, 119)
        Me.TxtBoxAdresseBanque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxAdresseBanque.Name = "TxtBoxAdresseBanque"
        Me.TxtBoxAdresseBanque.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxAdresseBanque.TabIndex = 32
        '
        'TxtBoxNomBanque
        '
        Me.TxtBoxNomBanque.Location = New System.Drawing.Point(196, 68)
        Me.TxtBoxNomBanque.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxNomBanque.Name = "TxtBoxNomBanque"
        Me.TxtBoxNomBanque.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxNomBanque.TabIndex = 31
        '
        'TxtBoxNomComptable
        '
        Me.TxtBoxNomComptable.Location = New System.Drawing.Point(196, 21)
        Me.TxtBoxNomComptable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxNomComptable.Name = "TxtBoxNomComptable"
        Me.TxtBoxNomComptable.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxNomComptable.TabIndex = 30
        '
        'LabelCompte
        '
        Me.LabelCompte.AutoSize = True
        Me.LabelCompte.Location = New System.Drawing.Point(476, 123)
        Me.LabelCompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCompte.Name = "LabelCompte"
        Me.LabelCompte.Size = New System.Drawing.Size(138, 17)
        Me.LabelCompte.TabIndex = 5
        Me.LabelCompte.Text = "Numero du Compte :"
        '
        'LabelCodeBanque
        '
        Me.LabelCodeBanque.AutoSize = True
        Me.LabelCodeBanque.Location = New System.Drawing.Point(480, 76)
        Me.LabelCodeBanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCodeBanque.Name = "LabelCodeBanque"
        Me.LabelCodeBanque.Size = New System.Drawing.Size(102, 17)
        Me.LabelCodeBanque.TabIndex = 4
        Me.LabelCodeBanque.Text = "Code Banque :"
        '
        'labelVillebanque
        '
        Me.labelVillebanque.AutoSize = True
        Me.labelVillebanque.Location = New System.Drawing.Point(480, 30)
        Me.labelVillebanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelVillebanque.Name = "labelVillebanque"
        Me.labelVillebanque.Size = New System.Drawing.Size(42, 17)
        Me.labelVillebanque.TabIndex = 29
        Me.labelVillebanque.Text = "Ville :"
        '
        'LabelAdresseBanque
        '
        Me.LabelAdresseBanque.AutoSize = True
        Me.LabelAdresseBanque.Location = New System.Drawing.Point(27, 123)
        Me.LabelAdresseBanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAdresseBanque.Name = "LabelAdresseBanque"
        Me.LabelAdresseBanque.Size = New System.Drawing.Size(68, 17)
        Me.LabelAdresseBanque.TabIndex = 28
        Me.LabelAdresseBanque.Text = "Adresse :"
        '
        'LabelNomBanque
        '
        Me.LabelNomBanque.AutoSize = True
        Me.LabelNomBanque.Location = New System.Drawing.Point(28, 76)
        Me.LabelNomBanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomBanque.Name = "LabelNomBanque"
        Me.LabelNomBanque.Size = New System.Drawing.Size(132, 17)
        Me.LabelNomBanque.TabIndex = 27
        Me.LabelNomBanque.Text = "Nom de la banque :"
        '
        'LabelNomComptable
        '
        Me.LabelNomComptable.AutoSize = True
        Me.LabelNomComptable.Location = New System.Drawing.Point(28, 30)
        Me.LabelNomComptable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomComptable.Name = "LabelNomComptable"
        Me.LabelNomComptable.Size = New System.Drawing.Size(134, 17)
        Me.LabelNomComptable.TabIndex = 26
        Me.LabelNomComptable.Text = "Nom du comptable :"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.BtnAnnuler.Location = New System.Drawing.Point(911, 359)
        Me.BtnAnnuler.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(180, 46)
        Me.BtnAnnuler.TabIndex = 42
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnValider
        '
        Me.BtnValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.BtnValider.Location = New System.Drawing.Point(911, 261)
        Me.BtnValider.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(180, 46)
        Me.BtnValider.TabIndex = 41
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BoxContactFournisseur
        '
        Me.BoxContactFournisseur.BackColor = System.Drawing.Color.Lavender
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
        Me.BoxContactFournisseur.Location = New System.Drawing.Point(16, 73)
        Me.BoxContactFournisseur.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BoxContactFournisseur.Name = "BoxContactFournisseur"
        Me.BoxContactFournisseur.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BoxContactFournisseur.Size = New System.Drawing.Size(875, 338)
        Me.BoxContactFournisseur.TabIndex = 43
        Me.BoxContactFournisseur.TabStop = False
        Me.BoxContactFournisseur.Text = "Nouveau Fournisseur"
        '
        'TxtBoxAdresse
        '
        Me.TxtBoxAdresse.Location = New System.Drawing.Point(196, 260)
        Me.TxtBoxAdresse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxAdresse.Name = "TxtBoxAdresse"
        Me.TxtBoxAdresse.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxAdresse.TabIndex = 17
        '
        'TxtBoxVille
        '
        Me.TxtBoxVille.Location = New System.Drawing.Point(196, 300)
        Me.TxtBoxVille.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxVille.Name = "TxtBoxVille"
        Me.TxtBoxVille.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxVille.TabIndex = 18
        '
        'TxtBoxProvince
        '
        Me.TxtBoxProvince.Location = New System.Drawing.Point(627, 23)
        Me.TxtBoxProvince.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxProvince.Name = "TxtBoxProvince"
        Me.TxtBoxProvince.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxProvince.TabIndex = 19
        '
        'TxtBoxCodePostal
        '
        Me.TxtBoxCodePostal.Location = New System.Drawing.Point(627, 71)
        Me.TxtBoxCodePostal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxCodePostal.Name = "TxtBoxCodePostal"
        Me.TxtBoxCodePostal.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxCodePostal.TabIndex = 20
        '
        'TxtBoxPays
        '
        Me.TxtBoxPays.Location = New System.Drawing.Point(627, 121)
        Me.TxtBoxPays.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxPays.Name = "TxtBoxPays"
        Me.TxtBoxPays.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxPays.TabIndex = 21
        '
        'TxtBoxTéléphone1
        '
        Me.TxtBoxTéléphone1.Location = New System.Drawing.Point(627, 169)
        Me.TxtBoxTéléphone1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxTéléphone1.Name = "TxtBoxTéléphone1"
        Me.TxtBoxTéléphone1.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxTéléphone1.TabIndex = 22
        '
        'TxtBoxTéléphone2
        '
        Me.TxtBoxTéléphone2.Location = New System.Drawing.Point(627, 213)
        Me.TxtBoxTéléphone2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxTéléphone2.Name = "TxtBoxTéléphone2"
        Me.TxtBoxTéléphone2.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxTéléphone2.TabIndex = 23
        '
        'TxtBoxFax
        '
        Me.TxtBoxFax.Location = New System.Drawing.Point(627, 260)
        Me.TxtBoxFax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxFax.Name = "TxtBoxFax"
        Me.TxtBoxFax.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxFax.TabIndex = 24
        '
        'TxtBoxSiteWeb
        '
        Me.TxtBoxSiteWeb.Location = New System.Drawing.Point(627, 305)
        Me.TxtBoxSiteWeb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxSiteWeb.Name = "TxtBoxSiteWeb"
        Me.TxtBoxSiteWeb.Size = New System.Drawing.Size(233, 22)
        Me.TxtBoxSiteWeb.TabIndex = 25
        '
        'LabelSiteWeb
        '
        Me.LabelSiteWeb.AutoSize = True
        Me.LabelSiteWeb.Location = New System.Drawing.Point(477, 309)
        Me.LabelSiteWeb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSiteWeb.Name = "LabelSiteWeb"
        Me.LabelSiteWeb.Size = New System.Drawing.Size(74, 17)
        Me.LabelSiteWeb.TabIndex = 22
        Me.LabelSiteWeb.Text = "Site-Web :"
        '
        'LabelFax
        '
        Me.LabelFax.AutoSize = True
        Me.LabelFax.Location = New System.Drawing.Point(477, 268)
        Me.LabelFax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFax.Name = "LabelFax"
        Me.LabelFax.Size = New System.Drawing.Size(38, 17)
        Me.LabelFax.TabIndex = 21
        Me.LabelFax.Text = "Fax :"
        '
        'LabelTel2
        '
        Me.LabelTel2.AutoSize = True
        Me.LabelTel2.Location = New System.Drawing.Point(477, 226)
        Me.LabelTel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTel2.Name = "LabelTel2"
        Me.LabelTel2.Size = New System.Drawing.Size(96, 17)
        Me.LabelTel2.TabIndex = 20
        Me.LabelTel2.Text = "Téléphone 2 :"
        '
        'LabelTel1
        '
        Me.LabelTel1.AutoSize = True
        Me.LabelTel1.Location = New System.Drawing.Point(477, 181)
        Me.LabelTel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTel1.Name = "LabelTel1"
        Me.LabelTel1.Size = New System.Drawing.Size(96, 17)
        Me.LabelTel1.TabIndex = 19
        Me.LabelTel1.Text = "Téléphone 1 :"
        '
        'LabelPays
        '
        Me.LabelPays.AutoSize = True
        Me.LabelPays.Location = New System.Drawing.Point(477, 129)
        Me.LabelPays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPays.Name = "LabelPays"
        Me.LabelPays.Size = New System.Drawing.Size(47, 17)
        Me.LabelPays.TabIndex = 18
        Me.LabelPays.Text = "Pays :"
        '
        'LabelCodePostal
        '
        Me.LabelCodePostal.AutoSize = True
        Me.LabelCodePostal.Location = New System.Drawing.Point(477, 80)
        Me.LabelCodePostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCodePostal.Name = "LabelCodePostal"
        Me.LabelCodePostal.Size = New System.Drawing.Size(91, 17)
        Me.LabelCodePostal.TabIndex = 17
        Me.LabelCodePostal.Text = "Code postal :"
        '
        'LabelProvince
        '
        Me.LabelProvince.AutoSize = True
        Me.LabelProvince.Location = New System.Drawing.Point(477, 37)
        Me.LabelProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProvince.Name = "LabelProvince"
        Me.LabelProvince.Size = New System.Drawing.Size(71, 17)
        Me.LabelProvince.TabIndex = 16
        Me.LabelProvince.Text = "Province :"
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(196, 213)
        Me.TxtBoxEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxEmail.TabIndex = 4
        '
        'LabelNoCompte
        '
        Me.LabelNoCompte.AutoSize = True
        Me.LabelNoCompte.ForeColor = System.Drawing.Color.Black
        Me.LabelNoCompte.Location = New System.Drawing.Point(28, 37)
        Me.LabelNoCompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNoCompte.Name = "LabelNoCompte"
        Me.LabelNoCompte.Size = New System.Drawing.Size(106, 17)
        Me.LabelNoCompte.TabIndex = 0
        Me.LabelNoCompte.Text = "No de Compte :"
        '
        'TxtBoxFonction
        '
        Me.TxtBoxFonction.Location = New System.Drawing.Point(196, 164)
        Me.TxtBoxFonction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxFonction.Name = "TxtBoxFonction"
        Me.TxtBoxFonction.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxFonction.TabIndex = 3
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Location = New System.Drawing.Point(28, 309)
        Me.LabelVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(42, 17)
        Me.LabelVille.TabIndex = 6
        Me.LabelVille.Text = "Ville: "
        '
        'LabelSocieté
        '
        Me.LabelSocieté.AutoSize = True
        Me.LabelSocieté.ForeColor = System.Drawing.Color.Black
        Me.LabelSocieté.Location = New System.Drawing.Point(28, 80)
        Me.LabelSocieté.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSocieté.Name = "LabelSocieté"
        Me.LabelSocieté.Size = New System.Drawing.Size(63, 17)
        Me.LabelSocieté.TabIndex = 1
        Me.LabelSocieté.Text = "Societé :"
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Location = New System.Drawing.Point(27, 268)
        Me.LabelAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(72, 17)
        Me.LabelAdresse.TabIndex = 5
        Me.LabelAdresse.Text = "Adresse : "
        '
        'TxtBoxContact
        '
        Me.TxtBoxContact.Location = New System.Drawing.Point(196, 121)
        Me.TxtBoxContact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxContact.Name = "TxtBoxContact"
        Me.TxtBoxContact.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxContact.TabIndex = 2
        '
        'LabelContact
        '
        Me.LabelContact.AutoSize = True
        Me.LabelContact.ForeColor = System.Drawing.Color.Black
        Me.LabelContact.Location = New System.Drawing.Point(27, 129)
        Me.LabelContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContact.Name = "LabelContact"
        Me.LabelContact.Size = New System.Drawing.Size(64, 17)
        Me.LabelContact.TabIndex = 2
        Me.LabelContact.Text = "Contact :"
        '
        'TxtBoxSocieté
        '
        Me.TxtBoxSocieté.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxSocieté.Location = New System.Drawing.Point(196, 71)
        Me.TxtBoxSocieté.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxSocieté.Name = "TxtBoxSocieté"
        Me.TxtBoxSocieté.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxSocieté.TabIndex = 1
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(28, 222)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(55, 17)
        Me.LabelEmail.TabIndex = 4
        Me.LabelEmail.Text = "E-mail :"
        '
        'LabelFonction
        '
        Me.LabelFonction.AutoSize = True
        Me.LabelFonction.Location = New System.Drawing.Point(27, 172)
        Me.LabelFonction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFonction.Name = "LabelFonction"
        Me.LabelFonction.Size = New System.Drawing.Size(70, 17)
        Me.LabelFonction.TabIndex = 3
        Me.LabelFonction.Text = "Fonction :"
        '
        'TxtBoxNoCompte
        '
        Me.TxtBoxNoCompte.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.TxtBoxNoCompte.Location = New System.Drawing.Point(196, 28)
        Me.TxtBoxNoCompte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxNoCompte.Name = "TxtBoxNoCompte"
        Me.TxtBoxNoCompte.Size = New System.Drawing.Size(259, 22)
        Me.TxtBoxNoCompte.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(899, 76)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(217, 516)
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'FrmNouveauFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 608)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.BtnNouveau)
        Me.Controls.Add(Me.GroupBoxBanque)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.BoxContactFournisseur)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmNouveauFournisseur"
        Me.Text = "Creer un Nouveau Fournisseur"
        Me.GroupBoxBanque.ResumeLayout(False)
        Me.GroupBoxBanque.PerformLayout()
        Me.BoxContactFournisseur.ResumeLayout(False)
        Me.BoxContactFournisseur.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Quitter As Button
    Friend WithEvents BtnNouveau As Button
    Friend WithEvents GroupBoxBanque As GroupBox
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
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnValider As Button
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
