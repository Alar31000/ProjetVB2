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
        Me.ListUtilisateurs.ItemHeight = 16
        Me.ListUtilisateurs.Location = New System.Drawing.Point(13, 13)
        Me.ListUtilisateurs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListUtilisateurs.Name = "ListUtilisateurs"
        Me.ListUtilisateurs.Size = New System.Drawing.Size(642, 228)
        Me.ListUtilisateurs.TabIndex = 1
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(297, 247)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(83, 25)
        Me.ButtonQuitter.TabIndex = 5
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Utilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 283)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ListUtilisateurs)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Utilisateurs"
        Me.Text = "Utilisateurs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListUtilisateurs As ListBox
    Friend WithEvents ButtonQuitter As Button
End Class
