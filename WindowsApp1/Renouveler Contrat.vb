Public Class Renouveler_Contrat

    Private Sub BtnRenouveller_Click(sender As Object, e As EventArgs) Handles BtnRenouveller.Click

        MsgBox("Le contrat est bien renouveller")



    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub


    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

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

