Public Class FrmNouveauFournisseur

    'Procedure pour effacer les données afficher sur le form de nouveau fournisseur 
    Sub EffacerDonner()
        TxtBoxNoCompte.Text = ""
        TxtBoxSocieté.Text = ""
        TxtBoxNomComptable.Text = ""
        TxtBoxAdresse.Text = ""
        TxtBoxAdresseBanque.Text = ""
        TxtBoxCodeBanque.Text = ""
        TxtBoxCompte.Text = ""
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
    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub
    'Ce Boutton est pour fermer le form de nouveau fournisseur 
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        EffacerDonner()
    End Sub

    'Ce Bouton est pour vider les champ remplie et pour qu'on puisse entrer les donnees d'un nouveau fournisseur 
    Private Sub BtnNouveau_Click(sender As Object, e As EventArgs) Handles BtnNouveau.Click
        EffacerDonner()
    End Sub

    Private Sub TxtBoxAdresseBanque_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxAdresseBanque.TextChanged

    End Sub

    'Procedure pour vérifier le remplisage des champs TextFields de l'Input de donnees
    Sub verifierInput()
        If TxtBoxNoCompte.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer le numero de compte du fournisseur", vbOKOnly, "Erreur")

        ElseIf TxtBoxSocieté.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer le Nom de la societe ", vbOKOnly, "Erreur")

        ElseIf TxtBoxContact.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer le contact de fournisseur", vbOKOnly, "Erreur")

        ElseIf TxtBoxAdresse.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer l'adresse du fournisseur", vbOKOnly, "Erreur")

        ElseIf TxtBoxTéléphone1.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer le téléphone du fournisseur", vbOKOnly, "Erreur")


        Else
            MsgBox("Le  fournisseur est bien enregistrer", vbOKOnly, "Nouveau fournisseur")
        End If


    End Sub
    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click
        verifierInput()
    End Sub

    Private Sub FrmNouveauFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class