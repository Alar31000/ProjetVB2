Public Class Résilier_Contrat
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    Private Sub BtnRenouveller_Click(sender As Object, e As EventArgs) Handles BtnResilier.Click

        MsgBox("Le contrat a été résilié avec succés!")



    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        If (Convert.ToInt32(TxtBoxNumCnt.Text)) = 1909687 Then
            MsgBox("le numéro du contrat existe!")
        Else
            MsgBox("le numéro du contrat n'existe pas!")
        End If


    End Sub

    Private Sub TxtBoxNumCnt_Click(sender As Object, e As EventArgs) Handles TxtBoxNumCnt.TextChanged
        'nombre d'ordi
        TxtBoxNumCnt.Text = Val(TxtBoxNumCnt.Text)


    End Sub

End Class


