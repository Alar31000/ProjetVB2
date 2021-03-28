Public NotInheritable Class About

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = "/ À Propos"
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "Nom du Produit : Abonnet. INC pour SGARI."
        Me.LabelVersion.Text = "Version : 1.0b."
        Me.LabelCopyright.Text = "Droit Légal :Tous droits sont non réservés."
        Me.LabelCompanyName.Text = "Conçu par : Les Voltiguers."
        Me.TextBoxDescription.Text = "ABONNET est une compagnie spécialisée dans la gestion des abonnements des clients civils et commerciaux au sein de l’établissement, la compagnie offre des services d'abonnement de lignes Internet et offre des équipements à ses clients. Un client peut être une personne physique, une personne morale ou un organisme gouvernemental."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
