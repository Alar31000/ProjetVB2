Public Class Utilisateurs
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    ' Procedure pour affichier les utilisateurs principaux de l'application SGARI
    Sub recherche()
        Dim tabutilisateur() As String = {"Administrateur", "Ines", "Sofiane", "Camille", "Yaseen", "Sulaymane"}
        Dim intCount As Integer = 0
        For intCount = 0 To tabutilisateur.Length - 1
            ListUtilisateurs.Items.Add(tabutilisateur(intCount))
        Next


    End Sub
    Private Sub UserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListUtilisateurs.SelectedIndexChanged

    End Sub

    Private Sub Utilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recherche()
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub
End Class