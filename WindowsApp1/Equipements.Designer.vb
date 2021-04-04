<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equipements
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
        Me.ButtonFacture = New System.Windows.Forms.Button()
        Me.LabelInternet = New System.Windows.Forms.Label()
        Me.LabelModem = New System.Windows.Forms.Label()
        Me.LabelMicroOrdi = New System.Windows.Forms.Label()
        Me.GroupBoxEquipement = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxInternet = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFrs = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ButtonDateEnservice = New System.Windows.Forms.Button()
        Me.ButtonClendar = New System.Windows.Forms.Button()
        Me.DateAcquisition = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateMiseService = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMOrdinateurCost = New System.Windows.Forms.Label()
        Me.LabelModemCost = New System.Windows.Forms.Label()
        Me.LabelInternetCost = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.CheckBoxLouer = New System.Windows.Forms.CheckBox()
        Me.TextBoxModem = New System.Windows.Forms.TextBox()
        Me.TextBoxMOrdi = New System.Windows.Forms.TextBox()
        Me.ButtonCalculate = New System.Windows.Forms.Button()
        Me.GroupBoxEquipement.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonFacture
        '
        Me.ButtonFacture.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonFacture.Location = New System.Drawing.Point(389, 422)
        Me.ButtonFacture.Name = "ButtonFacture"
        Me.ButtonFacture.Size = New System.Drawing.Size(68, 27)
        Me.ButtonFacture.TabIndex = 22
        Me.ButtonFacture.Text = "ok"
        Me.ButtonFacture.UseVisualStyleBackColor = True
        '
        'LabelInternet
        '
        Me.LabelInternet.AutoSize = True
        Me.LabelInternet.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelInternet.ForeColor = System.Drawing.Color.Black
        Me.LabelInternet.Location = New System.Drawing.Point(19, 212)
        Me.LabelInternet.Name = "LabelInternet"
        Me.LabelInternet.Size = New System.Drawing.Size(133, 21)
        Me.LabelInternet.TabIndex = 21
        Me.LabelInternet.Text = "Ligne Internet /an"
        '
        'LabelModem
        '
        Me.LabelModem.AutoSize = True
        Me.LabelModem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelModem.ForeColor = System.Drawing.Color.Black
        Me.LabelModem.Location = New System.Drawing.Point(19, 162)
        Me.LabelModem.Name = "LabelModem"
        Me.LabelModem.Size = New System.Drawing.Size(64, 21)
        Me.LabelModem.TabIndex = 20
        Me.LabelModem.Text = "Modem"
        '
        'LabelMicroOrdi
        '
        Me.LabelMicroOrdi.AutoSize = True
        Me.LabelMicroOrdi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LabelMicroOrdi.ForeColor = System.Drawing.Color.Black
        Me.LabelMicroOrdi.Location = New System.Drawing.Point(19, 116)
        Me.LabelMicroOrdi.Name = "LabelMicroOrdi"
        Me.LabelMicroOrdi.Size = New System.Drawing.Size(129, 21)
        Me.LabelMicroOrdi.TabIndex = 19
        Me.LabelMicroOrdi.Text = "Micro-ordinateur"
        '
        'GroupBoxEquipement
        '
        Me.GroupBoxEquipement.Controls.Add(Me.Button1)
        Me.GroupBoxEquipement.Controls.Add(Me.TextBoxInternet)
        Me.GroupBoxEquipement.Controls.Add(Me.GroupBox4)
        Me.GroupBoxEquipement.Controls.Add(Me.Label4)
        Me.GroupBoxEquipement.Controls.Add(Me.Label3)
        Me.GroupBoxEquipement.Controls.Add(Me.Label2)
        Me.GroupBoxEquipement.Controls.Add(Me.GroupBox3)
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
        Me.GroupBoxEquipement.Font = New System.Drawing.Font("Segoe UI", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBoxEquipement.ForeColor = System.Drawing.Color.Navy
        Me.GroupBoxEquipement.Location = New System.Drawing.Point(2, 3)
        Me.GroupBoxEquipement.Name = "GroupBoxEquipement"
        Me.GroupBoxEquipement.Size = New System.Drawing.Size(646, 706)
        Me.GroupBoxEquipement.TabIndex = 23
        Me.GroupBoxEquipement.TabStop = False
        Me.GroupBoxEquipement.Text = "Equipements"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 656)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 33)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxInternet
        '
        Me.TextBoxInternet.Location = New System.Drawing.Point(222, 212)
        Me.TextBoxInternet.Name = "TextBoxInternet"
        Me.TextBoxInternet.Size = New System.Drawing.Size(83, 33)
        Me.TextBoxInternet.TabIndex = 39
        Me.TextBoxInternet.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TxtFrs)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TxtStock)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(17, 334)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(561, 54)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consultation Article"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(323, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fournisseur"
        '
        'TxtFrs
        '
        Me.TxtFrs.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtFrs.ForeColor = System.Drawing.SystemColors.Menu
        Me.TxtFrs.Location = New System.Drawing.Point(408, 19)
        Me.TxtFrs.Name = "TxtFrs"
        Me.TxtFrs.Size = New System.Drawing.Size(123, 20)
        Me.TxtFrs.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Stock disponible"
        '
        'TxtStock
        '
        Me.TxtStock.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TxtStock.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.TxtStock.Location = New System.Drawing.Point(125, 23)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(140, 20)
        Me.TxtStock.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 25)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 25)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Prix"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Liste des types"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.MonthCalendar2)
        Me.GroupBox3.Controls.Add(Me.MonthCalendar1)
        Me.GroupBox3.Controls.Add(Me.ButtonDateEnservice)
        Me.GroupBox3.Controls.Add(Me.ButtonClendar)
        Me.GroupBox3.Controls.Add(Me.DateAcquisition)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.DateMiseService)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(23, 412)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 215)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Date"
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(321, 56)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 29
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(27, 56)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 28
        '
        'ButtonDateEnservice
        '
        Me.ButtonDateEnservice.Location = New System.Drawing.Point(519, 27)
        Me.ButtonDateEnservice.Name = "ButtonDateEnservice"
        Me.ButtonDateEnservice.Size = New System.Drawing.Size(29, 27)
        Me.ButtonDateEnservice.TabIndex = 27
        Me.ButtonDateEnservice.UseVisualStyleBackColor = True
        '
        'ButtonClendar
        '
        Me.ButtonClendar.Location = New System.Drawing.Point(225, 20)
        Me.ButtonClendar.Name = "ButtonClendar"
        Me.ButtonClendar.Size = New System.Drawing.Size(29, 30)
        Me.ButtonClendar.TabIndex = 24
        Me.ButtonClendar.UseVisualStyleBackColor = True
        '
        'DateAcquisition
        '
        Me.DateAcquisition.Location = New System.Drawing.Point(124, 24)
        Me.DateAcquisition.Name = "DateAcquisition"
        Me.DateAcquisition.Size = New System.Drawing.Size(101, 20)
        Me.DateAcquisition.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(283, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Date mise en service"
        '
        'DateMiseService
        '
        Me.DateMiseService.Location = New System.Drawing.Point(415, 30)
        Me.DateMiseService.Name = "DateMiseService"
        Me.DateMiseService.Size = New System.Drawing.Size(104, 20)
        Me.DateMiseService.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Date d'acquisition"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(325, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Total :"
        '
        'LabelMOrdinateurCost
        '
        Me.LabelMOrdinateurCost.AutoSize = True
        Me.LabelMOrdinateurCost.ForeColor = System.Drawing.Color.Black
        Me.LabelMOrdinateurCost.Location = New System.Drawing.Point(400, 113)
        Me.LabelMOrdinateurCost.Name = "LabelMOrdinateurCost"
        Me.LabelMOrdinateurCost.Size = New System.Drawing.Size(45, 25)
        Me.LabelMOrdinateurCost.TabIndex = 30
        Me.LabelMOrdinateurCost.Text = "500"
        '
        'LabelModemCost
        '
        Me.LabelModemCost.AutoSize = True
        Me.LabelModemCost.ForeColor = System.Drawing.Color.Black
        Me.LabelModemCost.Location = New System.Drawing.Point(398, 159)
        Me.LabelModemCost.Name = "LabelModemCost"
        Me.LabelModemCost.Size = New System.Drawing.Size(45, 25)
        Me.LabelModemCost.TabIndex = 29
        Me.LabelModemCost.Text = "100"
        '
        'LabelInternetCost
        '
        Me.LabelInternetCost.AutoSize = True
        Me.LabelInternetCost.ForeColor = System.Drawing.Color.Black
        Me.LabelInternetCost.Location = New System.Drawing.Point(395, 209)
        Me.LabelInternetCost.Name = "LabelInternetCost"
        Me.LabelInternetCost.Size = New System.Drawing.Size(45, 25)
        Me.LabelInternetCost.TabIndex = 28
        Me.LabelInternetCost.Text = "450"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.ForeColor = System.Drawing.Color.Black
        Me.LabelTotal.Location = New System.Drawing.Point(395, 263)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(61, 25)
        Me.LabelTotal.TabIndex = 27
        Me.LabelTotal.Text = "$0.00"
        '
        'CheckBoxLouer
        '
        Me.CheckBoxLouer.AutoSize = True
        Me.CheckBoxLouer.Location = New System.Drawing.Point(67, 422)
        Me.CheckBoxLouer.Name = "CheckBoxLouer"
        Me.CheckBoxLouer.Size = New System.Drawing.Size(81, 29)
        Me.CheckBoxLouer.TabIndex = 25
        Me.CheckBoxLouer.Text = "Louer"
        Me.CheckBoxLouer.UseVisualStyleBackColor = True
        '
        'TextBoxModem
        '
        Me.TextBoxModem.Location = New System.Drawing.Point(222, 156)
        Me.TextBoxModem.Name = "TextBoxModem"
        Me.TextBoxModem.Size = New System.Drawing.Size(83, 33)
        Me.TextBoxModem.TabIndex = 23
        Me.TextBoxModem.Text = "0"
        '
        'TextBoxMOrdi
        '
        Me.TextBoxMOrdi.Location = New System.Drawing.Point(222, 110)
        Me.TextBoxMOrdi.Name = "TextBoxMOrdi"
        Me.TextBoxMOrdi.Size = New System.Drawing.Size(83, 33)
        Me.TextBoxMOrdi.TabIndex = 22
        Me.TextBoxMOrdi.Text = "0"
        '
        'ButtonCalculate
        '
        Me.ButtonCalculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonCalculate.ForeColor = System.Drawing.Color.Black
        Me.ButtonCalculate.Location = New System.Drawing.Point(497, 266)
        Me.ButtonCalculate.Name = "ButtonCalculate"
        Me.ButtonCalculate.Size = New System.Drawing.Size(81, 29)
        Me.ButtonCalculate.TabIndex = 16
        Me.ButtonCalculate.Text = "Calculer"
        Me.ButtonCalculate.UseVisualStyleBackColor = True
        '
        'Equipements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 704)
        Me.Controls.Add(Me.GroupBoxEquipement)
        Me.Name = "Equipements"
        Me.Text = "Equipements"
        Me.GroupBoxEquipement.ResumeLayout(False)
        Me.GroupBoxEquipement.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonFacture As Button
    Friend WithEvents LabelInternet As Label
    Friend WithEvents LabelModem As Label
    Friend WithEvents LabelMicroOrdi As Label
    Friend WithEvents GroupBoxEquipement As GroupBox
    Friend WithEvents ButtonCalculate As Button
    Friend WithEvents CheckBoxLouer As CheckBox
    Friend WithEvents TextBoxModem As TextBox
    Friend WithEvents TextBoxMOrdi As TextBox
    Friend WithEvents LabelMOrdinateurCost As Label
    Friend WithEvents LabelModemCost As Label
    Friend WithEvents LabelInternetCost As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ButtonDateEnservice As Button
    Friend WithEvents ButtonClendar As Button
    Friend WithEvents DateAcquisition As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DateMiseService As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtFrs As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxInternet As TextBox
    Friend WithEvents Button1 As Button
End Class
