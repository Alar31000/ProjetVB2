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
        Me.ButtonOk = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxUtilisateur
        '
        Me.TextBoxUtilisateur.Location = New System.Drawing.Point(315, 165)
        Me.TextBoxUtilisateur.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxUtilisateur.Name = "TextBoxUtilisateur"
        Me.TextBoxUtilisateur.Size = New System.Drawing.Size(208, 22)
        Me.TextBoxUtilisateur.TabIndex = 0
        '
        'TextBoxMotDePasse
        '
        Me.TextBoxMotDePasse.Location = New System.Drawing.Point(315, 208)
        Me.TextBoxMotDePasse.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxMotDePasse.MaxLength = 327678
        Me.TextBoxMotDePasse.Name = "TextBoxMotDePasse"
        Me.TextBoxMotDePasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxMotDePasse.Size = New System.Drawing.Size(208, 22)
        Me.TextBoxMotDePasse.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 168)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nom D'utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de Passe"
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.ForeColor = System.Drawing.Color.Navy
        Me.ButtonAnnuler.Location = New System.Drawing.Point(432, 255)
        Me.ButtonAnnuler.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(90, 29)
        Me.ButtonAnnuler.TabIndex = 5
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 35)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(608, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ButtonOk
        '
        Me.ButtonOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.ButtonOk.ForeColor = System.Drawing.Color.Navy
        Me.ButtonOk.Location = New System.Drawing.Point(340, 255)
        Me.ButtonOk.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.Size = New System.Drawing.Size(86, 29)
        Me.ButtonOk.TabIndex = 27
        Me.ButtonOk.Text = "OK"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(745, 385)
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxMotDePasse)
        Me.Controls.Add(Me.TextBoxUtilisateur)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents ButtonOk As Button
End Class
