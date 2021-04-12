Public Class CreerUnNouveauContrat
    Private Sub btnLocationEquipement_Click(sender As Object, e As EventArgs) Handles btnLocationEquipement.Click
        Equipements.Show()
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Services.Show()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If TxtBoxDateOuverture.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxCodePostal.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires ", vbOKOnly, "Erreur")

        ElseIf GroupBox1.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf GroupBox2.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxNom.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")


        ElseIf TxtBoxPrenom.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxAddresse.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxVille.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxTéléphone.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxFax.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxNEmployé.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxCompanie.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf txtBoxFraisMensuel.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxFermeture.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")

        ElseIf TxtBoxDateVigueur.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les informations nécessaires", vbOKOnly, "Erreur")
        Else
            MsgBox("Le contrat a été créé avec succés!", vbOKOnly, "Nouveau Contrat")
        End If


    End Sub
    Private Sub btnImprimer_Click(sender As Object, e As EventArgs) Handles btnImprimer.Click
        MsgBox("Le contrat a été imprimé avec succés!")
    End Sub

    'Une procedure pour effacer les donnees qui ont ete rentre par l'utilisateur
    Sub EffacerDonner()
        TxtBoxDateOuverture.Text = ""
        TxtBoxCodePostal.Text = ""
        GroupBox1.Text = ""
        GroupBox2.Text = ""
        TxtBoxNom.Text = ""
        TxtBoxPrenom.Text = ""
        TxtBoxAddresse.Text = ""
        TxtBoxVille.Text = ""
        TxtBoxTéléphone.Text = ""
        TxtBoxFax.Text = ""
        TxtBoxEmail.Text = ""
        TxtBoxNEmployé.Text = ""
        TxtBoxCompanie.Text = ""
        txtBoxFraisMensuel.Text = ""
        TxtBoxFermeture.Text = ""
        TxtBoxDateVigueur.Text = ""


    End Sub
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        EffacerDonner()
    End Sub
    Private Sub btnAide_Click(sender As Object, e As EventArgs) Handles btnAide.Click
        MsgBox("Veuillez vous contacter la service de la foramation Personnelle pour plus de details...!")
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxDateOuverture.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxCodePostal.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CreerUnNouveauContrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxNom.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxPrenom.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxAddresse.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxVille.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxTéléphone.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxFax.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxEmail.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxNEmployé.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxCompanie.TextChanged

    End Sub

    Private Sub txtBoxFraisMensuel_TextChanged(sender As Object, e As EventArgs) Handles txtBoxFraisMensuel.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxFermeture.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxDateVigueur.TextChanged

    End Sub

    Private Sub CmbBoxFraisRacondement_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxFraisRacondement.SelectedIndexChanged

    End Sub
End Class