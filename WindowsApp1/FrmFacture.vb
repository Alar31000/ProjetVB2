Public Class FrmFacture
    Private Sub BttnPayement_Click(sender As Object, e As EventArgs) Handles BttnPayement.Click
        Paiement.Show() 'Appel de la forme payement 
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerFacture.ValueChanged

    End Sub

    Private Sub LabelMOP_Click(sender As Object, e As EventArgs) Handles LblPrixMicroOrdiF.TextChanged
        'calcule prix micro ordinateur
        LblPrixMicroOrdiF.Text = String.Format("{0:c}", Val(Equipements.LabelMOrdinateurCost.Text * Equipements.TextBoxMOrdi.Text))

    End Sub

    Private Sub LabelQC_Click(sender As Object, e As EventArgs) Handles LblQteMicroOrdinateur.TextChanged
        'nombre d'ordi
        LblQteMicroOrdinateur.Text = Val(Equipements.TextBoxMOrdi.Text)

    End Sub

    Private Sub LblQCM_Click(sender As Object, e As EventArgs) Handles LblQteModem.TextChanged
        'nombre modem
        LblQteModem.Text = Val(Equipements.TextBoxModem.Text)

    End Sub

    Private Sub LblQMLI_Click(sender As Object, e As EventArgs) Handles LblQteInternet.TextChanged
        'durée ligne internet
        LblQteInternet.Text = Val(Equipements.TextBoxInternet.Text)

    End Sub



    Private Sub LabelPM_Click(sender As Object, e As EventArgs) Handles LblPrixModemF.TextChanged
        'calcule prix Modem
        LblPrixModemF.Text = String.Format("{0:c}", Val(Equipements.LabelModemCost.Text * Equipements.TextBoxModem.Text))

    End Sub

    Private Sub LabelLI_Click(sender As Object, e As EventArgs) Handles LblPrixInternetF.TextChanged
        'calcule prix ligne Internet
        LblPrixInternetF.Text = String.Format("{0:c}", Val(Equipements.LabelInternetCost.Text * Equipements.TextBoxInternet.Text))
    End Sub



    Private Sub LabelPTPS_Click(sender As Object, e As EventArgs) Handles LblTPS.TextChanged
        'calcule TPS
        LblTPS.Text = String.Format("{0:c}", (Val(LblSousTotal.Text * 5) / 100))
    End Sub

    Private Sub Lbl_Click(sender As Object, e As EventArgs) Handles LblTVQ.TextChanged
        'calule TVQ
        LblTVQ.Text = String.Format("{0:c}", (Val(LblSousTotal.Text * 9.975) / 100))
    End Sub




    Private Sub LabelST_Click_1(sender As Object, e As EventArgs) Handles LblSousTotal.TextChanged
        'calcule sous-total
        LblSousTotal.Text = String.Format("{0:c}", Val((Equipements.LabelMOrdinateurCost.Text * Equipements.TextBoxMOrdi.Text) + (Equipements.LabelModemCost.Text * Equipements.TextBoxModem.Text) + (Equipements.LabelInternetCost.Text * Equipements.TextBoxInternet.Text)))
    End Sub

    Private Sub LblPT_Click_1(sender As Object, e As EventArgs) Handles LblPrixTotalF.TextChanged
        'calcule total
        LblPrixTotalF.Text = String.Format("{0:c}", Val((Equipements.LabelMOrdinateurCost.Text * Equipements.TextBoxMOrdi.Text) + (Equipements.LabelModemCost.Text * Equipements.TextBoxModem.Text) + (Equipements.LabelInternetCost.Text * Equipements.TextBoxInternet.Text) + ((LblSousTotal.Text * 9.975) / 100) + ((LblSousTotal.Text * 5) / 100)))
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub GroupBoxFacture_Enter(sender As Object, e As EventArgs) Handles GroupBoxFacture.Enter

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub LabelAdresseL_Click(sender As Object, e As EventArgs) Handles LabelAdresseL.Click

    End Sub
End Class