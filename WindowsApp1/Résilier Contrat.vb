Imports System.Data.SQLite
Imports System.IO

Public Class Résilier_Contrat

    'Une variable pour la connection de la base de donnees
    Private connectionString = String.Empty
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub



    Private Sub BtnRenouveller_Click(sender As Object, e As EventArgs) Handles BtnResilier.Click

        MsgBox("Le contrat a été résilié avec succés!")



    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click

        connectionString = String.Format("Data Source={0};Version=3;",
                                         Directory.GetCurrentDirectory() & "\" & "usersDb.db")
        Using conn As New SQLiteConnection(connectionString.ToString)
            Using cmd As New SQLiteCommand(conn)
                'La commande pour recupere la table contrat pour l'affichage de la table
                cmd.CommandText = "SELECT * FROM Contrat"


                conn.Open()

                Using da As New SQLiteDataAdapter(cmd)

                    'Using da As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable


                    CONTRATDataGridView.DataSource = dt

                    da.Fill(dt)
                End Using
            End Using
        End Using
        If (Convert.ToInt32(TxtBoxNumCnt.Text)) = 1 Then
            MsgBox("le numéro du contrat existe!")
        ElseIf (Convert.ToInt32(TxtBoxNumCnt.Text)) = 2 Then
            MsgBox("le numéro du contrat existe!")
        Else
            MsgBox("le numéro du contrat n'existe pas!")
        End If



    End Sub

    Private Sub TxtBoxNumCnt_Click(sender As Object, e As EventArgs) Handles TxtBoxNumCnt.TextChanged
        'nombre d'ordi
        TxtBoxNumCnt.Text = Val(TxtBoxNumCnt.Text)


    End Sub

    Private Sub Résilier_Contrat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'La connection de la base de donnees
        connectionString = String.Format("Data Source={0};Version=3;",
                                         Directory.GetCurrentDirectory() & "\" & "usersDb.db")

        ' Pour affichier la table Client dans le premier DataGrid
        Using conn As New SQLiteConnection(connectionString.ToString)
            Using cmd As New SQLiteCommand(conn)

                'La commande pour recupere la table contrat pour l'affichage de la table
                cmd.CommandText = "SELECT * FROM Contrat"


                conn.Open()

                Using da As New SQLiteDataAdapter(cmd)

                    'Using da As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable


                    CONTRATDataGridView.DataSource = dt

                    da.Fill(dt)
                End Using
            End Using
        End Using
    End Sub

    Private Sub CONTRATDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CONTRATDataGridView.CellContentClick

    End Sub
End Class


