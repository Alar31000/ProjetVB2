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
        Me.SuspendLayout()
        '
        'lstBoxService
        '
        Me.lstBoxService.FormattingEnabled = True
        Me.lstBoxService.ItemHeight = 16
        Me.lstBoxService.Items.AddRange(New Object() {"Programmation Page Web Standars", "Formation Personnel", "Conception des pages Web Supplementaires", "Installation des equipements de logiciels"})
        Me.lstBoxService.Location = New System.Drawing.Point(43, 27)
        Me.lstBoxService.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstBoxService.Name = "lstBoxService"
        Me.lstBoxService.Size = New System.Drawing.Size(537, 276)
        Me.lstBoxService.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Navy
        Me.btnOK.Location = New System.Drawing.Point(258, 323)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(108, 33)
        Me.btnOK.TabIndex = 28
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 369)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstBoxService)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Services"
        Me.Text = "Services"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstBoxService As ListBox
    Friend WithEvents btnOK As Button
End Class
