<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TextBoxUtilisateur = New System.Windows.Forms.TextBox()
        Me.TextBoxMotDePasse = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxUtilisateur
        '
        Me.TextBoxUtilisateur.Location = New System.Drawing.Point(252, 132)
        Me.TextBoxUtilisateur.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxUtilisateur.Name = "TextBoxUtilisateur"
        Me.TextBoxUtilisateur.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxUtilisateur.TabIndex = 0
        '
        'TextBoxMotDePasse
        '
        Me.TextBoxMotDePasse.Location = New System.Drawing.Point(252, 166)
        Me.TextBoxMotDePasse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxMotDePasse.MaxLength = 327678
        Me.TextBoxMotDePasse.Name = "TextBoxMotDePasse"
        Me.TextBoxMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxMotDePasse.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxMotDePasse.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom D'utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 168)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de Passe"
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.ForeColor = System.Drawing.Color.Navy
        Me.ButtonAnnuler.Location = New System.Drawing.Point(346, 204)
        Me.ButtonAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(72, 23)
        Me.ButtonAnnuler.TabIndex = 5
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(486, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.Navy
        Me.btnOK.Location = New System.Drawing.Point(272, 200)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(52, 27)
        Me.btnOK.TabIndex = 27
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(596, 308)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxMotDePasse)
        Me.Controls.Add(Me.TextBoxUtilisateur)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Login"
        Me.Text = "Connexion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUtilisateur As TextBox
    Friend WithEvents TextBoxMotDePasse As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnOK As Button
End Class
