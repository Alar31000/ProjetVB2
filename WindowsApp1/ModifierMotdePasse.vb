Public Class ModifierMotdePasse
    Private Sub ModifierMotdePasse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Dim iExit As DialogResult
        iExit = MsgBox("Voulez Vous Fermer cette fenêtre ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
        End

    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        If TextBoxConfirmPass.Text = TextBoxNewPass.Text Then
            'varancmotdepasse = TextBoxNewPass.Text
            MsgBox("Changement de Mot de Passe réalisé avec succès")
            Me.Close()
        Else
            MsgBox("Les deux mot de passes ne  ne coïncident pas. Veuillez réessayer.")
        End If
    End Sub

    Private Sub TextBoxNewPass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNewPass.TextChanged

    End Sub

    Private Sub TextBoxConfirmPass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxConfirmPass.TextChanged

    End Sub
End Class