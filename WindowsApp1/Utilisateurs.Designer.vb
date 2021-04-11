<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Utilisateurs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListUtilisateurs = New System.Windows.Forms.ListBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListUtilisateurs
        '
        Me.ListUtilisateurs.BackColor = System.Drawing.Color.White
        Me.ListUtilisateurs.FormattingEnabled = True
        Me.ListUtilisateurs.Location = New System.Drawing.Point(26, 21)
        Me.ListUtilisateurs.Name = "ListUtilisateurs"
        Me.ListUtilisateurs.Size = New System.Drawing.Size(463, 160)
        Me.ListUtilisateurs.TabIndex = 1
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(221, 197)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(62, 20)
        Me.ButtonQuitter.TabIndex = 5
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Utilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 230)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ListUtilisateurs)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Utilisateurs"
        Me.Text = "Utilisateurs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListUtilisateurs As ListBox
    Friend WithEvents ButtonQuitter As Button
End Class
