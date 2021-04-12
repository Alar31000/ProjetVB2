Public Class Services
    Private Sub lstBoxService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxService.SelectedIndexChanged

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MsgBox("La service est ajoutée")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iExit As DialogResult
        iExit = MsgBox("Voulez Vous Fermer cette fenêtre ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
        End
    End Sub
End Class