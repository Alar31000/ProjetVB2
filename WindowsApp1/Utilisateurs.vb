Imports System.IO
Imports System.Data.SQLite

Public Class Utilisateurs
    Private connectionString = String.Format("Data Source={0};Version=3;", Directory.GetCurrentDirectory() & "\" & "usersDb.db")
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    ' Procedure pour affichier les utilisateurs principaux de l'application SGARI
    Sub recherche()

        '    ListUtilisateurs.Items.Clear()
        '    If data_reader.HasRows Then
        '        Do While data_reader.Read()
        '            WorkItemNumber = data_reader.Item("work item number")
        '            Description = data_reader.Item("description")
        '            ListBox1.Items.Add(New ListItem(Description, WorkItemNumber)
        'Loop
        '    End If
        '    Dim tabutilisateur() As String = {"Administrateur", "Ines", "Sofiane", "Camille", "Yaseen", "Sulaymane"}
        '    Dim intCount As Integer = 0
        '    For intCount = 0 To tabutilisateur.Length - 1
        '        ListUtilisateurs.Items.Add(tabutilisateur(intCount))
        '    Next


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