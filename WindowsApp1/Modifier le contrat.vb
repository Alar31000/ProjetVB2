Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub



    Private Sub GBoxRecherche_Enter(sender As Object, e As EventArgs) Handles GBoxRecherche.Enter

    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        If (Convert.ToInt32(TxtBoxNumCnt.Text)) = 1909687 Then
            MsgBox("le numéro du contrat existe!")
        Else
            MsgBox("le numéro du contrat n'existe pas!")
        End If


    End Sub


    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        End
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        MsgBox("Le contrat a été modifié avec succés!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Veuillez entrer le numéro du nouveau contrat s'il vous plait!")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class