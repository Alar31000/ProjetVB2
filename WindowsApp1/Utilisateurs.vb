Imports System.IO
Imports System.Data.SQLite

Public Class Utilisateurs
    Private connectionString = String.Format("Data Source={0};Version=3;", Directory.GetCurrentDirectory() & "\" & "usersDb.db")
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    ' Procedure pour affichier les utilisateurs principaux de l'application SGARI
    Sub recherche()
        Dim userfullname As String
        Dim sql As String = "SELECT * FROM users;"
        ListUtilisateurs.Items.Clear()
        Dim conn As New SQLiteConnection(connectionString.ToString)
        conn.Open()
        Dim cmd As New SQLiteCommand
        cmd.Connection = conn
        cmd.CommandText = sql
        Dim sqlRead As SQLiteDataReader
        sqlRead = cmd.ExecuteReader
        If sqlRead.HasRows Then
            Do While sqlRead.Read()
                userfullname = sqlRead.Item("user_fullname")
                ListUtilisateurs.Items.Add(userfullname)
            Loop
        End If

        sqlRead.Close()
        conn.Close()


        'Dim tabutilisateur() As String = {"Administrateur", "Ines", "Sofiane", "Camille", "Yaseen", "Sulaymane"}
        'Dim intCount As Integer = 0
        'For intCount = 0 To tabutilisateur.Length - 1
        '    ListUtilisateurs.Items.Add(tabutilisateur(intCount))
        'Next


    End Sub
    Private Sub UserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListUtilisateurs.SelectedIndexChanged

    End Sub

    Private Sub Utilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recherche()
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ModifierMotdePasse.Show()

    End Sub
End Class