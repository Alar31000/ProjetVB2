Public Class CreerUnNouveauContrat
    Private Sub btnLocationEquipement_Click(sender As Object, e As EventArgs) Handles btnLocationEquipement.Click
        Equipements.Show()
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Services.Show()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If TextBox5.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox13.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires ", vbOKOnly, "Erreur")

        ElseIf GroupBox1.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf GroupBox2.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf Nom.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")


        ElseIf Prenom.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf Addresse.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox8.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox9.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox14.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox11.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox12.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf txtBoxFraisMensuel.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox4.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")

        ElseIf TextBox6.Text = "" Then
            MsgBox("S'il vous plait, Veuillez Entrer les information nécessaires", vbOKOnly, "Erreur")
        Else
            MsgBox("Le contrat a été créé avec succés!", vbOKOnly, "Nouveau Contrat")
        End If


    End Sub
    Private Sub btnImprimer_Click(sender As Object, e As EventArgs) Handles btnImprimer.Click
        MsgBox("Le contrat a été imprimé avec succés!")
    End Sub

    'Une procedure pour effacer les donnees qui ont ete rentre par l'utilisateur
    Sub EffacerDonner()
        TextBox5.Text = ""
        TextBox13.Text = ""
        GroupBox1.Text = ""
        GroupBox2.Text = ""
        Nom.Text = ""
        Prenom.Text = ""
        Addresse.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox14.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        txtBoxFraisMensuel.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""


    End Sub
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        EffacerDonner()
    End Sub
    Private Sub btnAide_Click(sender As Object, e As EventArgs) Handles btnAide.Click
        MsgBox("Veuillez vous contacter la service de la foramation Personnelle pour plus de details...!")
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CreerUnNouveauContrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Nom.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Prenom.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles Addresse.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub txtBoxFraisMensuel_TextChanged(sender As Object, e As EventArgs) Handles txtBoxFraisMensuel.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class