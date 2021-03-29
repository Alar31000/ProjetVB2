<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipements
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBoxEquipement = New System.Windows.Forms.GroupBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonClendar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Calendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Labelstok = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMOrdinateurCost = New System.Windows.Forms.Label()
        Me.LabelModemCost = New System.Windows.Forms.Label()
        Me.LabelInternetCost = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.ButtonFacture = New System.Windows.Forms.Button()
        Me.CheckBoxLouer = New System.Windows.Forms.CheckBox()
        Me.TextBoxModem = New System.Windows.Forms.TextBox()
        Me.TextBoxMOrdi = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.LabelInternet = New System.Windows.Forms.Label()
        Me.LabelModem = New System.Windows.Forms.Label()
        Me.LabelMicroOrdi = New System.Windows.Forms.Label()
        Me.GroupBoxEquipement.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxEquipement
        '
        Me.GroupBoxEquipement.Controls.Add(Me.ListBox4)
        Me.GroupBoxEquipement.Controls.Add(Me.MonthCalendar1)
        Me.GroupBoxEquipement.Controls.Add(Me.Button1)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBox3)
        Me.GroupBoxEquipement.Controls.Add(Me.Label8)
        Me.GroupBoxEquipement.Controls.Add(Me.ButtonClendar)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBox2)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBox1)
        Me.GroupBoxEquipement.Controls.Add(Me.Calendar1)
        Me.GroupBoxEquipement.Controls.Add(Me.Label7)
        Me.GroupBoxEquipement.Controls.Add(Me.Label6)
        Me.GroupBoxEquipement.Controls.Add(Me.ListBox3)
        Me.GroupBoxEquipement.Controls.Add(Me.Labelstok)
        Me.GroupBoxEquipement.Controls.Add(Me.ListBox2)
        Me.GroupBoxEquipement.Controls.Add(Me.ListBox1)
        Me.GroupBoxEquipement.Controls.Add(Me.Label5)
        Me.GroupBoxEquipement.Controls.Add(Me.Label4)
        Me.GroupBoxEquipement.Controls.Add(Me.Label3)
        Me.GroupBoxEquipement.Controls.Add(Me.Label2)
        Me.GroupBoxEquipement.Controls.Add(Me.Label1)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelMOrdinateurCost)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelModemCost)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelInternetCost)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelTotal)
        Me.GroupBoxEquipement.Controls.Add(Me.ButtonFacture)
        Me.GroupBoxEquipement.Controls.Add(Me.CheckBoxLouer)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBoxModem)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBoxMOrdi)
        Me.GroupBoxEquipement.Controls.Add(Me.ButtonCalculate)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelInternet)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelModem)
        Me.GroupBoxEquipement.Controls.Add(Me.LabelMicroOrdi)
        Me.GroupBoxEquipement.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxEquipement.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxEquipement.Location = New System.Drawing.Point(3, -1)
        Me.GroupBoxEquipement.Name = "GroupBoxEquipement"
        Me.GroupBoxEquipement.Size = New System.Drawing.Size(905, 643)
        Me.GroupBoxEquipement.TabIndex = 45
        Me.GroupBoxEquipement.TabStop = False
        Me.GroupBoxEquipement.Text = "Equipements"
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 21
        Me.ListBox4.Items.AddRange(New Object() {"0 Go", "25 Go", "50 Go", "80 Go", "100 Go"})
        Me.ListBox4.Location = New System.Drawing.Point(451, 212)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(64, 25)
        Me.ListBox4.TabIndex = 50
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(654, 410)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(760, 381)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 30)
        Me.Button1.TabIndex = 48
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(654, 381)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 29)
        Me.TextBox3.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(447, 389)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 21)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Date de mise en service"
        '
        'ButtonClendar
        '
        Me.ButtonClendar.Location = New System.Drawing.Point(360, 389)
        Me.ButtonClendar.Name = "ButtonClendar"
        Me.ButtonClendar.Size = New System.Drawing.Size(29, 30)
        Me.ButtonClendar.TabIndex = 45
        Me.ButtonClendar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(239, 389)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(115, 29)
        Me.TextBox2.TabIndex = 44
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(239, 330)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(115, 29)
        Me.TextBox1.TabIndex = 41
        '
        'Calendar1
        '
        Me.Calendar1.Location = New System.Drawing.Point(239, 418)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.TabIndex = 43
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Date d'acquisition"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 21)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Fournisseur"
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 21
        Me.ListBox3.Items.AddRange(New Object() {"Disponible", "Indisponible"})
        Me.ListBox3.Location = New System.Drawing.Point(239, 275)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(115, 25)
        Me.ListBox3.TabIndex = 39
        '
        'Labelstok
        '
        Me.Labelstok.AutoSize = True
        Me.Labelstok.Location = New System.Drawing.Point(38, 275)
        Me.Labelstok.Name = "Labelstok"
        Me.Labelstok.Size = New System.Drawing.Size(50, 21)
        Me.Labelstok.TabIndex = 38
        Me.Labelstok.Text = "Stock"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 21
        Me.ListBox2.Items.AddRange(New Object() {"Dell", "Acer", "Asus", "Sony", "HP"})
        Me.ListBox2.Location = New System.Drawing.Point(239, 171)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(115, 25)
        Me.ListBox2.TabIndex = 37
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Items.AddRange(New Object() {"Dell", "Acer", "Asus", "Sony", "HP"})
        Me.ListBox1.Location = New System.Drawing.Point(239, 108)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(115, 25)
        Me.ListBox1.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(251, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Marque"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(650, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Prix Unité"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Liste des Types"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Qté"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(553, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 22)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Total :"
        '
        'LabelMOrdinateurCost
        '
        Me.LabelMOrdinateurCost.AutoSize = True
        Me.LabelMOrdinateurCost.ForeColor = System.Drawing.Color.Black
        Me.LabelMOrdinateurCost.Location = New System.Drawing.Point(650, 105)
        Me.LabelMOrdinateurCost.Name = "LabelMOrdinateurCost"
        Me.LabelMOrdinateurCost.Size = New System.Drawing.Size(37, 21)
        Me.LabelMOrdinateurCost.TabIndex = 30
        Me.LabelMOrdinateurCost.Text = "500"
        '
        'LabelModemCost
        '
        Me.LabelModemCost.AutoSize = True
        Me.LabelModemCost.ForeColor = System.Drawing.Color.Black
        Me.LabelModemCost.Location = New System.Drawing.Point(650, 162)
        Me.LabelModemCost.Name = "LabelModemCost"
        Me.LabelModemCost.Size = New System.Drawing.Size(28, 21)
        Me.LabelModemCost.TabIndex = 29
        Me.LabelModemCost.Text = "50"
        '
        'LabelInternetCost
        '
        Me.LabelInternetCost.AutoSize = True
        Me.LabelInternetCost.ForeColor = System.Drawing.Color.Black
        Me.LabelInternetCost.Location = New System.Drawing.Point(650, 212)
        Me.LabelInternetCost.Name = "LabelInternetCost"
        Me.LabelInternetCost.Size = New System.Drawing.Size(41, 21)
        Me.LabelInternetCost.TabIndex = 28
        Me.LabelInternetCost.Text = "100 "
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.ForeColor = System.Drawing.Color.Black
        Me.LabelTotal.Location = New System.Drawing.Point(650, 263)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(50, 21)
        Me.LabelTotal.TabIndex = 27
        Me.LabelTotal.Text = "$0.00"
        '
        'ButtonFacture
        '
        Me.ButtonFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonFacture.Location = New System.Drawing.Point(42, 598)
        Me.ButtonFacture.Name = "ButtonFacture"
        Me.ButtonFacture.Size = New System.Drawing.Size(68, 27)
        Me.ButtonFacture.TabIndex = 22
        Me.ButtonFacture.Text = "ok"
        Me.ButtonFacture.UseVisualStyleBackColor = True
        '
        'CheckBoxLouer
        '
        Me.CheckBoxLouer.AutoSize = True
        Me.CheckBoxLouer.Location = New System.Drawing.Point(42, 547)
        Me.CheckBoxLouer.Name = "CheckBoxLouer"
        Me.CheckBoxLouer.Size = New System.Drawing.Size(70, 25)
        Me.CheckBoxLouer.TabIndex = 25
        Me.CheckBoxLouer.Text = "Louer"
        Me.CheckBoxLouer.UseVisualStyleBackColor = True
        '
        'TextBoxModem
        '
        Me.TextBoxModem.Location = New System.Drawing.Point(451, 159)
        Me.TextBoxModem.Name = "TextBoxModem"
        Me.TextBoxModem.Size = New System.Drawing.Size(64, 29)
        Me.TextBoxModem.TabIndex = 23
        Me.TextBoxModem.Text = "0"
        Me.TextBoxModem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxMOrdi
        '
        Me.TextBoxMOrdi.Location = New System.Drawing.Point(451, 102)
        Me.TextBoxMOrdi.Name = "TextBoxMOrdi"
        Me.TextBoxMOrdi.Size = New System.Drawing.Size(64, 29)
        Me.TextBoxMOrdi.TabIndex = 22
        Me.TextBoxMOrdi.Text = "0"
        Me.TextBoxMOrdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonCalculate.ForeColor = System.Drawing.Color.Black
        Me.ButtonCalculate.Location = New System.Drawing.Point(742, 259)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(74, 29)
        Me.ButtonCalculate.TabIndex = 16
        Me.ButtonCalculate.Text = "Calculer"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'LabelInternet
        '
        Me.LabelInternet.AutoSize = True
        Me.LabelInternet.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelInternet.Location = New System.Drawing.Point(34, 219)
        Me.LabelInternet.Name = "LabelInternet"
        Me.LabelInternet.Size = New System.Drawing.Size(119, 21)
        Me.LabelInternet.TabIndex = 21
        Me.LabelInternet.Text = "Ligne d'internet"
        '
        'LabelModem
        '
        Me.LabelModem.AutoSize = True
        Me.LabelModem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelModem.Location = New System.Drawing.Point(34, 159)
        Me.LabelModem.Name = "LabelModem"
        Me.LabelModem.Size = New System.Drawing.Size(64, 21)
        Me.LabelModem.TabIndex = 20
        Me.LabelModem.Text = "Modem"
        '
        'LabelMicroOrdi
        '
        Me.LabelMicroOrdi.AutoSize = True
        Me.LabelMicroOrdi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelMicroOrdi.Location = New System.Drawing.Point(33, 113)
        Me.LabelMicroOrdi.Name = "LabelMicroOrdi"
        Me.LabelMicroOrdi.Size = New System.Drawing.Size(129, 21)
        Me.LabelMicroOrdi.TabIndex = 19
        Me.LabelMicroOrdi.Text = "Micro-ordinateur"
        '
        'FrmEquipements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 638)
        Me.Controls.Add(Me.GroupBoxEquipement)
        Me.Name = "FrmEquipements"
        Me.Text = "FrmEquipements"
        Me.GroupBoxEquipement.ResumeLayout(False)
        Me.GroupBoxEquipement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxEquipement As GroupBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonClendar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Calendar1 As MonthCalendar
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Labelstok As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelMOrdinateurCost As Label
    Friend WithEvents LabelModemCost As Label
    Friend WithEvents LabelInternetCost As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents ButtonFacture As Button
    Friend WithEvents CheckBoxLouer As CheckBox
    Friend WithEvents TextBoxModem As TextBox
    Friend WithEvents TextBoxMOrdi As TextBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents LabelInternet As Label
    Friend WithEvents LabelModem As Label
    Friend WithEvents LabelMicroOrdi As Label
End Class
