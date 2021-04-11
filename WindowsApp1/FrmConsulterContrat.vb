Imports System.Data.SQLite
Imports System.IO

Public Class FrmConsulterContrat

    'Une variable pour la connection de la base de donnees
    Private connectionString = String.Empty
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub Titre_Click(sender As Object, e As EventArgs) Handles Titre.Click

    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub

    Private Sub FrmConsulterContrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'La connection de la base de donnees
        connectionString = String.Format("Data Source={0};Version=3;",
                                         Directory.GetCurrentDirectory() & "\" & "usersDb.db")

        ' Pour affichier la table Client dans le premier DataGrid
        Using conn As New SQLiteConnection(connectionString.ToString)
            Using cmd As New SQLiteCommand(conn)

                cmd.CommandText = "SELECT * FROM Clients"


                conn.Open()

                Using da As New SQLiteDataAdapter(cmd)
                    'Using da As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable


                    DataGridView1.DataSource = dt

                    da.Fill(dt)
                End Using
            End Using
        End Using

        ' Pour affichier la table Contrat dans la deuxieme DataGrid
        Using conn As New SQLiteConnection(connectionString.ToString)
            Using cmd2 As New SQLiteCommand(conn)


                cmd2.CommandText = "SELECT * FROM Contrat"

                conn.Open()

                Using da As New SQLiteDataAdapter(cmd2)
                    'Using da As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable
                    DataGridView2.DataSource = dt
                    da.Fill(dt)


                End Using
            End Using
        End Using

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class