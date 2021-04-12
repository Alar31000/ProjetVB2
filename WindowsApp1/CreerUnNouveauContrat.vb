Public Class CreerUnNouveauContrat
    Private Sub btnLocationEquipement_Click(sender As Object, e As EventArgs) Handles btnLocationEquipement.Click
        Equipements.Show()
    End Sub

    Private Sub btnService_Click(sender As Object, e As EventArgs) Handles btnService.Click
        Services.Show()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MsgBox("Le contrat a été créé avec succés!")
    End Sub
    Private Sub btnImprimer_Click(sender As Object, e As EventArgs) Handles btnImprimer.Click
        MsgBox("Le contrat a été imprimé avec succés!")
    End Sub
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        MsgBox("Le contrat a été annulé avec succés!")
        End
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
End Class