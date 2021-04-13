Public Class Modifier_Contrat
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub





    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click

        If (Convert.ToInt32(TxtBoxNumCnt.Text)) = 1 Then
            MsgBox("le numéro du contrat existe!")
            LblMNC.Text = "1"
            TxtBoxNom.Text = "Touré"
            TxtBoxPrénom.Text = "Mamadou"
            TBoxMTCnt.Text = "Entreprise privée"
            TBoxMDO.Text = "01/04/2021"
            TBoxMDF.Text = "01/04/2022"
            TBoxMLocation.Text = "Internet"
            TBoxMService.Text = "Installation des équipements"
            TBoxMDMV.Text = "03/04/2021"

        ElseIf (Convert.ToInt32(TxtBoxNumCnt.Text)) = 2 Then
            MsgBox("le numéro du contrat existe!")
            LblMNC.Text = "2"
            TxtBoxNom.Text = "Rya"
            TxtBoxPrénom.Text = "Inés"
            TBoxMTCnt.Text = "Particulier"
            TBoxMDO.Text = "01/08/2021"
            TBoxMDF.Text = "01/08/2022"
            TBoxMLocation.Text = "Micro_ordinateur"
            TBoxMService.Text = "Programmation des pages Webs"
            TBoxMDMV.Text = "03/08/2021"
        Else
            MsgBox("le numéro du contrat n'existe pas!")
            SupprimerDonner()

        End If


    End Sub
    Sub SupprimerDonner()
        LblMNC.Text = ""
        TxtBoxNom.Text = ""
        TxtBoxPrénom.Text = ""
        TBoxMTCnt.Text = ""
        TBoxMDO.Text = ""
        TBoxMDF.Text = ""
        TBoxMLocation.Text = ""
        TBoxMService.Text = ""
        TBoxMDMV.Text = ""

    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        MsgBox("Le contrat a été modifié avec succés!")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Veuillez entrer le numéro du nouveau contrat s'il vous plait!")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtBoxNumCnt_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxNumCnt.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxNom.TextChanged

    End Sub

    Private Sub TxtBoxPrénom_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxPrénom.TextChanged

    End Sub

    Private Sub TBoxMDMV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxNumCnt.KeyPress, TBoxMDO.KeyPress, TBoxMDMV.KeyPress, TBoxMDF.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub
End Class