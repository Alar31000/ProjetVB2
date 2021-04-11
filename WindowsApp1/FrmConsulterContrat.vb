Imports System.Data.SQLite
Imports System.IO

Public Class FrmConsulterContrat

    'Une variable pour la connection de la base de donnees
    Private connectionString = String.Empty
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub datagridShow()
        Dim objDs As New DataSet
        Dim objDt As New DataTable
        objDs.Tables.Add(objDt)
        'Dim objDa As New OleDbDataAdapter

        'objDt = New OleDbDataAdapter("select * from CLIENT, SOUSCRIT, CONTRAT where CLIENT.NUMCLIENT = SOUSCRIT.NUMCLIENT and CONTRAT.NUMCONTRAT = SOUSCRIT.NUMCONTRAT", objCnn)
        'objDa = New OleDbDataAdapter("Select CLIENT.*, CONTRAT.*From CONTRAT INNER Join (CLIENT INNER Join SOUSCRIT On CLIENT.NUMCLIENT = SOUSCRIT.NUMCLIENT) ON CONTRAT.NUMCONTRAT = SOUSCRIT.NUMCONTRAT", objCnn)

        'objDa.Fill(objDt)

        ' DataGridView1.DataSource = objDt.DefaultView

        ' objCnn.Close()

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



        'Dim sqlContrat As String = "SELECT * FROM Contrat"

        Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)

                cmd.CommandText = "SELECT * FROM Clients;"
                'cmd.CommandText = sqlContrat

                conn.Open()

                    Using da As New SQLiteDataAdapter(cmd)
                        'Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable


                        DataGridView1.DataSource = dt
                        da.Fill(dt)
                        ' DataGridView2.DataSource = dt
                        ' da.Fill(dt)


                    End Using
                End Using
            End Using

        'TODO: cette ligne de code charge les données dans la table 'SgariBddDataSet.CONTRAT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.CONTRATTableAdapter.Fill(Me.SgariBddDataSet.CONTRAT)
        'TODO: cette ligne de code charge les données dans la table 'SgariBddDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        ' Me.CLIENTTableAdapter.Fill(Me.SgariBddDataSet.CLIENT)

        'objDs = New DataSet
        'objTable = objDs.Tables
        'objDa = New OleDb.OleDbDataAdapter("select * from CLIENT, SOUSCRIT, CONTRAT where CLIENT.NUMCLIENT = SOUSCRIT.NUMCLIENT and CONTRAT.NUMCONTRAT = SOUSCRIT.NUMCONTRAT", objCnn)
        'objDa.Fill(objDs, "Client, contrat")
        'objCmd.CommandType = System.Data.CommandType.Text

        'objCnn.Open()
        'datagridShow()
        'objCmd.CommandText = "select * from CLIENT, SOUSCRIT, CONTRAT where CLIENT.NUMCLIENT = SOUSCRIT.NUMCLIENT and CONTRAT.NUMCONTRAT = SOUSCRIT.NUMCONTRAT"
        '"Select CLIENT.*, CONTRAT.*From CONTRAT INNER Join (CLIENT INNER Join SOUSCRIT On CLIENT.NUMCLIENT = SOUSCRIT.NUMCLIENT) ON CONTRAT.NUMCONTRAT = SOUSCRIT.NUMCONTRAT"


        'objCmd.ExecuteNonQuery()
        'Dim objView As New DataView(objTable(0))

        ' Fermeture de la base de données

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class