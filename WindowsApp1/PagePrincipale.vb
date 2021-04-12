
Imports System.IO
Public Class PagePrincipale
    Private Sub ToolStripStatusLabel1_Show(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.VisibleChanged
        ToolStripStatusLabel1.Visible = True
        ToolStripStatusLabel1.Text = "Bonjour," + Login.TextBoxUtilisateur.Text
    End Sub

    Private Sub PagePrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Location = New Point((Width / 2) - (PictureBox1.Width / 2), (Height / 2) - (PictureBox1.Height / 2))
    End Sub

    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem.Click
        MsgBox("Pour Toute Information concernant La Formation ou Le Support Technique, contactez Mr. Mohamed TALEB au :" & Environment.NewLine & " +1 819-873-4466", MsgBoxStyle.OkOnly + vbInformation, "Information")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContentsToolStripMenuItem.Click
        Whoarewe.Show()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        CreerUnNouveauContrat.Show()

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        FrmConsulterContrat.Show()

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Renouveler_Contrat.Show()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Modifier_Contrat.Show()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Résilier_Contrat.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Login.Show()

    End Sub

    Private Sub ÉquipementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉquipementsToolStripMenuItem.Click
        Equipements.Show()

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Services.Show()

    End Sub

    Private Sub FactureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FactureToolStripMenuItem.Click
        FrmFacture.Show()

    End Sub

    Private Sub PaiementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaiementToolStripMenuItem.Click
        Paiement.Show()

    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        FrmNouveauFournisseur.Show()

    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        FrmModiferFournisseur.Show()

    End Sub

    Private Sub ToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem.Click
        Utilisateurs.Show()

    End Sub

    Private Sub FournisseursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FournisseursToolStripMenuItem.Click

    End Sub

    Private Sub AchévementDesContratsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AchévementDesContratsToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub ÉquipementsÀCommanderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉquipementsÀCommanderToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub ÉquipementsÀRetournerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉquipementsÀRetournerToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub ContratsOuvertsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratsOuvertsToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub ContratsRésiliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratsRésiliersToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub ClientsContentieuxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsContentieuxToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub PaimentParCarteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaimentParCarteToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub PaiementParRetraitDirectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaiementParRetraitDirectToolStripMenuItem.Click
        MsgBox("Les documents sont envoyés a l'imprimante avec succés")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
