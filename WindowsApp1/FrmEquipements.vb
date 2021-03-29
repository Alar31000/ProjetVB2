

Public Class FrmEquipements
    Private Sub GroupBoxEquipement_Enter(sender As Object, e As EventArgs) Handles GroupBoxEquipement.Enter

    End Sub

    'Calcule prix total  par  rapport au prix des equipements dependamenet du son choix du client 
    Sub calculer(ByVal nbreOrdi As Decimal, nbreModem As Decimal, nobreMoisInternet As Decimal)

    Dim prixModem As Decimal
    Dim prixOrdi As Decimal
    Dim prixInternet As Decimal
    Dim total As Decimal

    'prix du nombre de ordinateur
    prixOrdi = nbreOrdi * Val(LabelMOrdinateurCost.Text)

    'prix du nombre de modem
    prixModem = nbreModem * Val(LabelModemCost.Text)

    'calcule du prix d'internet selon le nombre de mois
    prixInternet = nobreMoisInternet * Val(LabelInternetCost.Text)

    'LabelInternetCost.Text = ToString(prixInternet + "/mois")

    ' somme des prix des Articles choisir par l'utilisateur
    total = prixModem + prixOrdi + prixInternet
    LabelTotal.Text = String.Format("{0:c}", total)

End Sub
End Class