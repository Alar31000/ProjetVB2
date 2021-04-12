Public Class FrmModiferFournisseur

    'Le groupe de variables pour l'input de l'utilisateur

    Dim ResultatInput As String ' variable qui enregistre le numero de compte du fournisseur entrer par l'utilisteur
    Dim NoCompte1 As String
    Dim NoCompte2 As String
    Dim Societe1 As String
    Dim Societe2 As String
    Dim Adresse2 As String
    Dim Adresse1 As String
    Dim Comptable1 As String
    Dim Comptable2 As String
    Dim AdresseBanque1 As String
    Dim AdresseBanque2 As String
    Dim CodeBanque1 As String
    Dim CodeBanque2 As String
    Dim Compte1 As String
    Dim Compte2 As String
    Dim Contact1 As String
    Dim Contact2 As String
    Dim Email1 As String
    Dim Email2 As String
    Dim Fax1 As String
    Dim Fax2 As String
    Dim Fonction1 As String
    Dim Fonction2 As String
    Dim NomBanque1 As String
    Dim NomBanque2 As String
    Dim Paye1 As String
    Dim Paye2 As String
    Dim Province1 As String
    Dim Province2 As String
    Dim sitWeb1 As String
    Dim sitWeb2 As String
    Dim Telephone1 As String
    Dim Telephone2 As String
    Dim Ville1 As String
    Dim Ville2 As String
    Dim VilleBanque1 As String
    Dim VilleBanque2 As String
    Dim CodePostal1 As String
    Dim CodePostal2 As String

    'Cette procedure regroupe tout les inputs de donnes que l'utilisateur va rentrer
    Sub InformationFournisseur()

        'Le cas des premieres variables
        Select Case ResultatInput
            Case 1
                TxtBoxNoCompte.Text = NoCompte1
                TxtBoxSocieté.Text = Societe1
                TxtBoxAdresse.Text = Adresse1
                TxtBoxNomComptable.Text = Comptable1
                TxtBoxAdresseBanque.Text = AdresseBanque1
                TxtBoxCodeBanque.Text = CodeBanque1

                TxtBoxContact.Text = Contact1
                TxtBoxEmail.Text = Email1
                TxtBoxFax.Text = Fax1
                TxtBoxFonction.Text = Fonction1
                TxtBoxNomBanque.Text = NomBanque1
                TxtBoxPays.Text = Paye1
                TxtBoxProvince.Text = Province1
                TxtBoxSiteWeb.Text = sitWeb1
                TxtBoxTéléphone1.Text = Telephone1
                TxtBoxTéléphone2.Text = Telephone1
                TxtBoxVille.Text = Ville1
                TxtBoxVilleBanque.Text = VilleBanque1
                TxtBoxCodePostal.Text = CodePostal1

                'Le cas des deuxiemes variables
            Case 2
                TxtBoxNoCompte.Text = NoCompte2
                TxtBoxSocieté.Text = Societe2
                TxtBoxAdresse.Text = Adresse2
                TxtBoxNomComptable.Text = Comptable2
                TxtBoxAdresseBanque.Text = AdresseBanque2
                TxtBoxCodeBanque.Text = CodeBanque2

                TxtBoxContact.Text = Contact2
                TxtBoxEmail.Text = Email2
                TxtBoxFax.Text = Fax2
                TxtBoxFonction.Text = Fonction2
                TxtBoxNomBanque.Text = NomBanque2
                TxtBoxPays.Text = Paye2
                TxtBoxProvince.Text = Province2
                TxtBoxSiteWeb.Text = sitWeb2
                TxtBoxTéléphone2.Text = Telephone2
                TxtBoxTéléphone2.Text = Telephone2
                TxtBoxVille.Text = Ville2
                TxtBoxVilleBanque.Text = VilleBanque2
                TxtBoxCodePostal.Text = CodePostal2
            Case Else
                MsgBox("le code de fournisseur entrer n'existe pas ", vbOKOnly, "Erreur")

        End Select

    End Sub

    'Une procedure pour effacer les donnees qui ont ete rentre par l'utilisateur
    Sub EffacerDonner()
        TxtBoxNoCompte.Text = ""
        TxtBoxSocieté.Text = ""
        TxtBoxNomComptable.Text = ""
        TxtBoxAdresse.Text = ""
        TxtBoxAdresseBanque.Text = ""
        TxtBoxCodeBanque.Text = ""

        TxtBoxContact.Text = ""
        TxtBoxEmail.Text = ""
        TxtBoxFax.Text = ""
        TxtBoxFonction.Text = ""
        TxtBoxNomBanque.Text = ""
        TxtBoxPays.Text = ""
        TxtBoxProvince.Text = ""
        TxtBoxSiteWeb.Text = ""
        TxtBoxTéléphone1.Text = ""
        TxtBoxTéléphone2.Text = ""
        TxtBoxVille.Text = ""
        TxtBoxVilleBanque.Text = ""
        TxtBoxCodePostal.Text = ""

    End Sub

    'Button pour checher un fournisseur
    Private Sub BtnChercher_Click(sender As Object, e As EventArgs) Handles BtnChercher.Click
        ActiveChamp()
        EffacerDonner()
        ResultatInput = InputBox("S'il vous plait, enter le numèro du fournisseur à modifier : ")
        InformationFournisseur()
    End Sub

    ' Procedure pour desactive les textbox Input
    Sub DesactiveChamp()

        TxtBoxNoCompte.Enabled = False
        TxtBoxSocieté.Enabled = False
        TxtBoxNomComptable.Enabled = False
        TxtBoxAdresse.Enabled = False
        TxtBoxAdresseBanque.Enabled = False
        TxtBoxCodeBanque.Enabled = False

        TxtBoxContact.Enabled = False
        TxtBoxEmail.Enabled = False
        TxtBoxFax.Enabled = False
        TxtBoxFonction.Enabled = False
        TxtBoxNomBanque.Enabled = False
        TxtBoxPays.Enabled = False
        TxtBoxProvince.Enabled = False
        TxtBoxSiteWeb.Enabled = False
        TxtBoxTéléphone1.Enabled = False
        TxtBoxTéléphone2.Enabled = False
        TxtBoxVille.Enabled = False
        TxtBoxVilleBanque.Enabled = False
        TxtBoxCodePostal.Enabled = False

    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub FrmModiferFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Activation des Champs de TextFields
    Sub ActiveChamp()
        TxtBoxNoCompte.Enabled = True
        TxtBoxSocieté.Enabled = True
        TxtBoxNomComptable.Enabled = True
        TxtBoxAdresse.Enabled = True
        TxtBoxAdresseBanque.Enabled = True
        TxtBoxCodeBanque.Enabled = True

        TxtBoxContact.Enabled = True
        TxtBoxEmail.Enabled = True
        TxtBoxFax.Enabled = True
        TxtBoxFonction.Enabled = True
        TxtBoxNomBanque.Enabled = True
        TxtBoxPays.Enabled = True
        TxtBoxProvince.Enabled = True
        TxtBoxSiteWeb.Enabled = True
        TxtBoxTéléphone1.Enabled = True
        TxtBoxTéléphone2.Enabled = True
        TxtBoxVille.Enabled = True
        TxtBoxVilleBanque.Enabled = True
        TxtBoxCodePostal.Enabled = True

    End Sub

    'Affichier les informations rentrees par l'employe
    Private Sub FrmModifierFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactiveChamp()
        NoCompte1 = "1"
        NoCompte2 = "2"
        Adresse1 = "351 St-joseph"
        Adresse2 = "840 Saint-Joseph"
        Societe1 = "Bios technologie"
        Societe2 = "Cisco"
        Comptable1 = "Charle dupond"
        Comptable2 = "Nicola Valtec"
        AdresseBanque1 = "752 plateau"
        AdresseBanque2 = "1045 des grives"
        CodeBanque1 = "888"
        CodeBanque2 = "525"
        Compte1 = "8184554556"
        Compte2 = "5345757454"
        Contact1 = "Omar Ahmed"
        Contact2 = "Arielle Ingabire"
        Email1 = "o.ahmed@bios.ca"
        Email2 = "ArielleI@cisco.ca"
        Fax1 = "819-777-4000"
        Fax2 = "819-778-1000"
        Fonction1 = "Directeur "
        Fonction2 = "Directeur"
        NomBanque1 = "RBC"
        NomBanque2 = "TD banque"
        Paye1 = "Canada"
        Paye2 = "Canada"
        Province1 = "Quebec"
        Province2 = "Quebec"
        sitWeb1 = "www.bios.ca"
        sitWeb2 = "www.cisco.ca"
        Telephone1 = "819-723-2542"
        Telephone2 = "819-778-4621"
        Ville1 = "Gatineau"
        Ville2 = "Gatineau"
        VilleBanque1 = "Gatineau"
        VilleBanque2 = "Gatineau"
        CodePostal1 = "j3y2y2"
        CodePostal2 = "j9a3j9"



    End Sub


    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        MsgBox("la modification est bien enregistrer")
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        InformationFournisseur()
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        EffacerDonner()
        MsgBox("le fournisseur a ete bien supprime!!")
    End Sub

    Private Sub Number_Only(sender As Object, e As KeyPressEventArgs) Handles TxtBoxTéléphone2.KeyPress, TxtBoxTéléphone1.KeyPress, TxtBoxNoCompte.KeyPress, TxtBoxCodeBanque.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub
End Class