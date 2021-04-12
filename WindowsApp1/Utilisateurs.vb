Imports System.IO
Imports System.Data.SQLite


Public Class Utilisateurs
    Private connectionString = String.Format("Data Source ={0};Version=3;", Directory.GetCurrentDirectory() & "\" & "usersDb.db")

    Dim fullname As String

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
    ' Procedure pour affichier les utilisateurs principaux de l'application SGARI
    Sub recherche()


        Using conn As New SQLiteConnection(connectionString.ToString)

            conn.Open()

            Dim sqlCmd As New SQLiteCommand

            sqlCmd.Connection = conn
            sqlCmd.CommandText = "Select user_fullname from users"
            Dim sqlRead As SQLiteDataReader = sqlCmd.ExecuteReader
            Dim sqlDTable As New DataTable

            ListUtilisateurs.Items.Clear()
            If sqlRead.HasRows Then
                Do While sqlRead.Read()
                    fullname = sqlRead.Item("user_fullname")

                    ListUtilisateurs.Items.Add(fullname)
                Loop
            End If
            sqlRead.Close()
            conn.Close()

            Dim DataGridView = FrmConsulterContrat.DataGridView2
            DataGridView.DataSource = sqlDTable
        End Using
    End Sub
    Private Sub UserList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListUtilisateurs.SelectedIndexChanged

    End Sub

    Private Sub Utilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recherche()
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Dim iExit As DialogResult
        iExit = MsgBox("Voulez Vous Fermer cette fenêtre ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = DialogResult.Yes Then
            Me.Close()
                        ()
        End If
        End
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        'Using conn As New SQLiteConnection(connectionString.ToString)

        '    conn.Open()

        '    Dim sqlCmd As New SQLiteCommand

        '    sqlCmd.Connection = conn
        '    sqlCmd.CommandText = "Select user_fullname from users"
        '    Dim sqlRead As SQLiteDataReader = sqlCmd.ExecuteReader
        '    Dim sqlDTable As New DataTable


        'End Using
    End Sub
End Class
