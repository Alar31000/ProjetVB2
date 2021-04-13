Public Class Paiement
    Private Sub CheckedListBoxModePaiement_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxNIP_TextChanged(sender As Object, e As EventArgs)

        ' LabelFacture.Visible = True
    End Sub

    Private Sub ButtonPaye_Click(sender As Object, e As EventArgs) Handles ButtonPaye.Click
        'afficher les mode de payement
        GroupBoxPayement.Visible = True
        CheckBoxPrélèvement.Visible = True
        CheckBoxCarte.Visible = True
        CheckBoxChèque.Visible = True
    End Sub

    Private Sub GroupBoxFacture_Enter(sender As Object, e As EventArgs) Handles GroupBoxFacture.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPrélèvement.CheckedChanged

        'check box prélèvement cocher
        If (CheckBoxPrélèvement.Checked = True) Then
            CheckBoxCarte.Checked = False
            CheckBoxChèque.Checked = False
        End If

        'rendre visible le groupe box de prélèvement
        If (CheckBoxPrélèvement.Checked = True) Then
            'GroupBoxPrélèvement.Visible = True
            LabelNumeroCompte.Visible = True
            TextBoxNCompte.Visible = True
            LabelNIP.Visible = True
            TextBoxNIP.Visible = True

        Else
            'GroupBoxPrélèvement.Visible = False
            LabelNumeroCompte.Visible = False
            TextBoxNCompte.Visible = False
            LabelNIP.Visible = False
            TextBoxNIP.Visible = False
        End If




    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBoxPayement.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBoxPrélèvement.Enter


    End Sub

    Private Sub LabelNumeroCompte_Click(sender As Object, e As EventArgs) Handles LabelNumeroCompte.Click

    End Sub

    Private Sub GroupBoxChèque_Enter(sender As Object, e As EventArgs) Handles GroupBoxChèque.Enter
        If (CheckBoxChèque.Checked = True) Then

        End If
    End Sub

    Private Sub GroupBoxCarte_Enter(sender As Object, e As EventArgs) Handles GroupBoxCarte.Enter
        If (CheckBoxCarte.Checked = True) Then

        End If
    End Sub

    Private Sub CheckBoxCarte_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCarte.CheckedChanged
        'check box Carte cocher
        If (CheckBoxCarte.Checked = True) Then
            CheckBoxPrélèvement.Checked = False
            CheckBoxChèque.Checked = False
        End If

        'rendre visible le groupe box de carte
        If (CheckBoxCarte.Checked = True) Then
            'GroupBoxCarte.Visible = True
            LabelNumeroCarte.Visible = True
            TextBoxNumeroCarte.Visible = True
            LabelDateEx.Visible = True
            TextBoxDateEx.Visible = True
            LabelCvv.Visible = True
            TextBoxCVV.Visible = True
        Else
            'GroupBoxCarte.Visible = False
            LabelNumeroCarte.Visible = False
            TextBoxNumeroCarte.Visible = False
            LabelDateEx.Visible = False
            TextBoxDateEx.Visible = False
            LabelCvv.Visible = False
            TextBoxCVV.Visible = False
        End If
    End Sub

    Private Sub CheckBoxChèque_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxChèque.CheckedChanged

        'check box chèque cocher
        If (CheckBoxChèque.Checked = True) Then
            CheckBoxPrélèvement.Checked = False
            CheckBoxCarte.Checked = False
        End If

        'rendre visible le groupe box de Chèque
        If (CheckBoxChèque.Checked = True) Then
            ' GroupBoxChèque.Visible = True
            LabelSuccursale.Visible = True
            TextBoxNSuccursale.Visible = True
            LabelInstitution.Visible = True
            TextBoxNInstitution.Visible = True
            LabelComptec.Visible = True
            TextBoxNComptec.Visible = True
        Else
            ' GroupBoxChèque.Visible = False
            LabelSuccursale.Visible = False
            TextBoxNSuccursale.Visible = False
            LabelInstitution.Visible = False
            TextBoxNInstitution.Visible = False
            LabelComptec.Visible = False
            TextBoxNComptec.Visible = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LabelDateEx_Click(sender As Object, e As EventArgs) Handles LabelDateEx.Click

    End Sub

    Private Sub LabelSuccursale_Click(sender As Object, e As EventArgs) Handles LabelSuccursale.Click

    End Sub

    Private Sub TextBoxNComptec_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxDateEx_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDateEx.TextChanged

    End Sub

    Private Sub TextBoxNumeroCarte_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumeroCarte.TextChanged

    End Sub

    Private Sub LabelNumeroCarte_Click(sender As Object, e As EventArgs) Handles LabelNumeroCarte.Click

    End Sub

    Private Sub Paiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBoxNIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNumeroCarte.KeyPress, TextBoxNSuccursale.KeyPress, TextBoxNIP.KeyPress, TextBoxNInstitution.KeyPress, TextBoxNComptec.KeyPress, TextBoxNCompte.KeyPress, TextBoxDateEx.KeyPress, TextBoxCVV.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("La Facture a été envoyé au client!")

    End Sub
End Class