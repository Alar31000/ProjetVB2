Public Class PagePrincipale
    Private Sub ToolStripStatusLabel1_Show(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.VisibleChanged
        ToolStripStatusLabel1.Visible = True
        ToolStripStatusLabel1.Text = "Bonjour," + Login.TextBoxUtilisateur.Text
    End Sub

    Private Sub PagePrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Location = New Point((Width / 2) - (PictureBox1.Width / 2), (Height / 2) - (PictureBox1.Height / 2))
    End Sub
End Class
