﻿Public Class FrmConsulterContrat
    'Dim objCnn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SgariBdd.accdb")

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
End Class