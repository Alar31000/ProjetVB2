﻿Public Class PagePrincipale
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
End Class
