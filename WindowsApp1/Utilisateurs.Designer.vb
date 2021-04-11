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
        Me.UserList = New System.Windows.Forms.ListBox()
        Me.ButtonAjouter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonDel = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserList
        '
        Me.UserList.BackColor = System.Drawing.Color.White
        Me.UserList.FormattingEnabled = True
        Me.UserList.ItemHeight = 16
        Me.UserList.Location = New System.Drawing.Point(35, 26)
        Me.UserList.Margin = New System.Windows.Forms.Padding(4)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(548, 372)
        Me.UserList.TabIndex = 1
        '
        'ButtonAjouter
        '
        Me.ButtonAjouter.Location = New System.Drawing.Point(626, 26)
        Me.ButtonAjouter.Name = "ButtonAjouter"
        Me.ButtonAjouter.Size = New System.Drawing.Size(83, 25)
        Me.ButtonAjouter.TabIndex = 2
        Me.ButtonAjouter.Text = "Ajouter"
        Me.ButtonAjouter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(626, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonDel
        '
        Me.ButtonDel.Location = New System.Drawing.Point(626, 122)
        Me.ButtonDel.Name = "ButtonDel"
        Me.ButtonDel.Size = New System.Drawing.Size(83, 25)
        Me.ButtonDel.TabIndex = 4
        Me.ButtonDel.Text = "Supprimer"
        Me.ButtonDel.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Location = New System.Drawing.Point(626, 169)
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
        Me.ClientSize = New System.Drawing.Size(800, 427)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonDel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonAjouter)
        Me.Controls.Add(Me.UserList)
        Me.Name = "Utilisateurs"
        Me.Text = "Utilisateurs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserList As ListBox
    Friend WithEvents ButtonAjouter As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ButtonDel As Button
    Friend WithEvents ButtonQuitter As Button
End Class
