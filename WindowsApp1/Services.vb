Public Class Services
    Private Sub lstBoxService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxService.SelectedIndexChanged

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MsgBox("La service est ajoutée")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class