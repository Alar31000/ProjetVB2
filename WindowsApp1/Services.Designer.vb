<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
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
        Me.lstBoxService = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBoxService
        '
        Me.lstBoxService.FormattingEnabled = True
        Me.lstBoxService.Items.AddRange(New Object() {"Formation du personnel.", "Réparation des équipements.", "Programmation des pages Web.", "Assistance téléphonique.", "Impression des rapports et statistiques", "Installation des équipements", "La livraison des équipements"})
        Me.lstBoxService.Location = New System.Drawing.Point(32, 48)
        Me.lstBoxService.Name = "lstBoxService"
        Me.lstBoxService.Size = New System.Drawing.Size(404, 199)
        Me.lstBoxService.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.btnOK.ForeColor = System.Drawing.Color.Navy
        Me.btnOK.Location = New System.Drawing.Point(163, 263)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(81, 27)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Gestion des Services"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(264, 265)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitter.TabIndex = 30
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 300)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstBoxService)
        Me.Name = "Services"
        Me.Text = "Services"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBoxService As ListBox
    Friend WithEvents btnOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnQuitter As Button
End Class
