Imports System.IO
Imports System.Data.SQLite

Public Class Login

    'Une variable pour la connection de la base de donnees
    Private connectionString = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Location = New Point((Width / 2), (Height / 2))
        'La connection de la base de donnees
        connectionString = String.Format("Data Source={0};Version=3;",
                                         Directory.GetCurrentDirectory() & "\" & "usersDb.db")


    End Sub

    Private Sub grid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUtilisateur.TextChanged

    End Sub

    Private Sub Authenticate()

        'Valider si le nom de l'utilisateur et le mot de passe est correct ou non
        If IsUserValid(TextBoxUtilisateur.Text.Trim, TextBoxMotDePasse.Text.Trim) = True Then
            MsgBox("Bienvenue.", MsgBoxStyle.OkOnly + vbInformation, "Succès !")


            'Si le mot de passe est correct, on ouvrira la page principale
            Me.Hide()
            Dim frmMainForm As New PagePrincipale
            frmMainForm.Show()

        Else
            MsgBox("Accès refusé, Veuillez Verifier Votre Nom d'Utilisatuer ou Votre Mot de Passe.")
        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonOk.Click

        Authenticate()

    End Sub

    Private Function IsUserValid(username As String, password As String) As Boolean
        Dim IsValidUser As Boolean = False
        Dim userInfo As DataRow = Nothing
        Dim sql As String = "SELECT * FROM users WHERE user_name = @username;"

        Try
            Using conn As New SQLiteConnection(connectionString.ToString)
                Using cmd As New SQLiteCommand(conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.CommandText = sql
                    conn.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        Dim dt As New DataTable
                        da.Fill(dt)

                        If dt.Rows.Count > 0 Then
                            userInfo = dt.Rows(0)
                            'Obtenir le mot de passe de la base de donnée
                            Dim dbPass As String = userInfo("user_password")


                            ' then compare the two hased password if they are the same then return valid password
                            If String.Compare(dbPass, password, False) = 0 Then
                                IsValidUser = True
                            End If

                        End If

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return IsValidUser
    End Function

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub

    Private Sub Txt_password_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMotDePasse.TextChanged

    End Sub

    Private Sub Txt_password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxMotDePasse.KeyDown
        If e.KeyCode = Keys.Enter Then
            Authenticate()
        Else
            Exit Sub
        End If

    End Sub

End Class