<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Impression_1_employe
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ListBoxEmployes = New System.Windows.Forms.ListBox()
        Me.ButtonImprimer = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.GroupBoxTri = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTriPrenom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTriNom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTriId = New System.Windows.Forms.RadioButton()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.ComboBoxDepartement = New System.Windows.Forms.ComboBox()
        Me.GroupBoxFiltre = New System.Windows.Forms.GroupBox()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelDepartement = New System.Windows.Forms.Label()
        Me.GroupBoxRechercheEmploye = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDates = New System.Windows.Forms.GroupBox()
        Me.LabelFin = New System.Windows.Forms.Label()
        Me.LabelDebut = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBoxTri.SuspendLayout()
        Me.GroupBoxFiltre.SuspendLayout()
        Me.GroupBoxRechercheEmploye.SuspendLayout()
        Me.GroupBoxDates.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'ListBoxEmployes
        '
        Me.ListBoxEmployes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEmployes.FormattingEnabled = True
        Me.ListBoxEmployes.ItemHeight = 24
        Me.ListBoxEmployes.Location = New System.Drawing.Point(6, 222)
        Me.ListBoxEmployes.Name = "ListBoxEmployes"
        Me.ListBoxEmployes.Size = New System.Drawing.Size(335, 220)
        Me.ListBoxEmployes.TabIndex = 0
        '
        'ButtonImprimer
        '
        Me.ButtonImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimer.Location = New System.Drawing.Point(783, 107)
        Me.ButtonImprimer.Name = "ButtonImprimer"
        Me.ButtonImprimer.Size = New System.Drawing.Size(203, 87)
        Me.ButtonImprimer.TabIndex = 1
        Me.ButtonImprimer.Text = "Imprimer"
        Me.ButtonImprimer.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(783, 225)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(203, 177)
        Me.ButtonQuitter.TabIndex = 2
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'GroupBoxTri
        '
        Me.GroupBoxTri.Controls.Add(Me.RadioButtonTriPrenom)
        Me.GroupBoxTri.Controls.Add(Me.RadioButtonTriNom)
        Me.GroupBoxTri.Controls.Add(Me.RadioButtonTriId)
        Me.GroupBoxTri.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTri.Location = New System.Drawing.Point(6, 32)
        Me.GroupBoxTri.Name = "GroupBoxTri"
        Me.GroupBoxTri.Size = New System.Drawing.Size(140, 141)
        Me.GroupBoxTri.TabIndex = 3
        Me.GroupBoxTri.TabStop = False
        Me.GroupBoxTri.Text = "Trier par :"
        '
        'RadioButtonTriPrenom
        '
        Me.RadioButtonTriPrenom.AutoSize = True
        Me.RadioButtonTriPrenom.Location = New System.Drawing.Point(56, 99)
        Me.RadioButtonTriPrenom.Name = "RadioButtonTriPrenom"
        Me.RadioButtonTriPrenom.Size = New System.Drawing.Size(95, 28)
        Me.RadioButtonTriPrenom.TabIndex = 2
        Me.RadioButtonTriPrenom.TabStop = True
        Me.RadioButtonTriPrenom.Text = "Prénom"
        Me.RadioButtonTriPrenom.UseVisualStyleBackColor = True
        '
        'RadioButtonTriNom
        '
        Me.RadioButtonTriNom.AutoSize = True
        Me.RadioButtonTriNom.Location = New System.Drawing.Point(56, 58)
        Me.RadioButtonTriNom.Name = "RadioButtonTriNom"
        Me.RadioButtonTriNom.Size = New System.Drawing.Size(69, 28)
        Me.RadioButtonTriNom.TabIndex = 1
        Me.RadioButtonTriNom.TabStop = True
        Me.RadioButtonTriNom.Text = "Nom"
        Me.RadioButtonTriNom.UseVisualStyleBackColor = True
        '
        'RadioButtonTriId
        '
        Me.RadioButtonTriId.AutoSize = True
        Me.RadioButtonTriId.Checked = True
        Me.RadioButtonTriId.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonTriId.Name = "RadioButtonTriId"
        Me.RadioButtonTriId.Size = New System.Drawing.Size(106, 28)
        Me.RadioButtonTriId.TabIndex = 0
        Me.RadioButtonTriId.TabStop = True
        Me.RadioButtonTriId.Text = "Identifiant"
        Me.RadioButtonTriId.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 80)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.TabIndex = 5
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Location = New System.Drawing.Point(12, 151)
        Me.MonthCalendar2.MaxSelectionCount = 1
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.ShowToday = False
        Me.MonthCalendar2.TabIndex = 6
        '
        'ComboBoxDepartement
        '
        Me.ComboBoxDepartement.DropDownWidth = 2000
        Me.ComboBoxDepartement.FormattingEnabled = True
        Me.ComboBoxDepartement.Location = New System.Drawing.Point(18, 52)
        Me.ComboBoxDepartement.Name = "ComboBoxDepartement"
        Me.ComboBoxDepartement.Size = New System.Drawing.Size(140, 32)
        Me.ComboBoxDepartement.TabIndex = 7
        '
        'GroupBoxFiltre
        '
        Me.GroupBoxFiltre.Controls.Add(Me.ComboBoxType)
        Me.GroupBoxFiltre.Controls.Add(Me.LabelType)
        Me.GroupBoxFiltre.Controls.Add(Me.LabelDepartement)
        Me.GroupBoxFiltre.Controls.Add(Me.ComboBoxDepartement)
        Me.GroupBoxFiltre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFiltre.Location = New System.Drawing.Point(166, 32)
        Me.GroupBoxFiltre.Name = "GroupBoxFiltre"
        Me.GroupBoxFiltre.Size = New System.Drawing.Size(175, 166)
        Me.GroupBoxFiltre.TabIndex = 8
        Me.GroupBoxFiltre.TabStop = False
        Me.GroupBoxFiltre.Text = "Filtrer par :"
        '
        'ComboBoxType
        '
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Location = New System.Drawing.Point(18, 119)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(121, 32)
        Me.ComboBoxType.TabIndex = 16
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(18, 90)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(53, 24)
        Me.LabelType.TabIndex = 15
        Me.LabelType.Text = "Type"
        '
        'LabelDepartement
        '
        Me.LabelDepartement.AutoSize = True
        Me.LabelDepartement.Location = New System.Drawing.Point(14, 25)
        Me.LabelDepartement.Name = "LabelDepartement"
        Me.LabelDepartement.Size = New System.Drawing.Size(128, 24)
        Me.LabelDepartement.TabIndex = 8
        Me.LabelDepartement.Text = "Département :"
        '
        'GroupBoxRechercheEmploye
        '
        Me.GroupBoxRechercheEmploye.Controls.Add(Me.ListBoxEmployes)
        Me.GroupBoxRechercheEmploye.Controls.Add(Me.GroupBoxFiltre)
        Me.GroupBoxRechercheEmploye.Controls.Add(Me.GroupBoxTri)
        Me.GroupBoxRechercheEmploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRechercheEmploye.Location = New System.Drawing.Point(12, 86)
        Me.GroupBoxRechercheEmploye.Name = "GroupBoxRechercheEmploye"
        Me.GroupBoxRechercheEmploye.Size = New System.Drawing.Size(359, 533)
        Me.GroupBoxRechercheEmploye.TabIndex = 9
        Me.GroupBoxRechercheEmploye.TabStop = False
        Me.GroupBoxRechercheEmploye.Text = "Recherche de l'employé"
        '
        'GroupBoxDates
        '
        Me.GroupBoxDates.Controls.Add(Me.LabelFin)
        Me.GroupBoxDates.Controls.Add(Me.LabelDebut)
        Me.GroupBoxDates.Controls.Add(Me.MonthCalendar1)
        Me.GroupBoxDates.Controls.Add(Me.MonthCalendar2)
        Me.GroupBoxDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDates.Location = New System.Drawing.Point(377, 86)
        Me.GroupBoxDates.Name = "GroupBoxDates"
        Me.GroupBoxDates.Size = New System.Drawing.Size(346, 428)
        Me.GroupBoxDates.TabIndex = 10
        Me.GroupBoxDates.TabStop = False
        Me.GroupBoxDates.Text = "Sélection des dates"
        '
        'LabelFin
        '
        Me.LabelFin.AutoSize = True
        Me.LabelFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFin.Location = New System.Drawing.Point(13, 139)
        Me.LabelFin.Name = "LabelFin"
        Me.LabelFin.Size = New System.Drawing.Size(179, 24)
        Me.LabelFin.TabIndex = 8
        Me.LabelFin.Text = "Fin (inclusivement) :"
        '
        'LabelDebut
        '
        Me.LabelDebut.AutoSize = True
        Me.LabelDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebut.Location = New System.Drawing.Point(13, 53)
        Me.LabelDebut.Name = "LabelDebut"
        Me.LabelDebut.Size = New System.Drawing.Size(70, 24)
        Me.LabelDebut.TabIndex = 7
        Me.LabelDebut.Text = "Début :"
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.LabelTitre.Location = New System.Drawing.Point(0, 0)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(695, 59)
        Me.LabelTitre.TabIndex = 11
        Me.LabelTitre.Text = "Impression du rapport d'un employé"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fenetre_Impression_1_employe
        '
        Me.AcceptButton = Me.ButtonImprimer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(983, 780)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBoxDates)
        Me.Controls.Add(Me.GroupBoxRechercheEmploye)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonImprimer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Impression_1_employe"
        Me.Text = "Impression_1_employe"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxTri.ResumeLayout(False)
        Me.GroupBoxTri.PerformLayout()
        Me.GroupBoxFiltre.ResumeLayout(False)
        Me.GroupBoxFiltre.PerformLayout()
        Me.GroupBoxRechercheEmploye.ResumeLayout(False)
        Me.GroupBoxDates.ResumeLayout(False)
        Me.GroupBoxDates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ListBoxEmployes As System.Windows.Forms.ListBox
    Friend WithEvents ButtonImprimer As System.Windows.Forms.Button
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
    Friend WithEvents GroupBoxTri As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents RadioButtonTriPrenom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTriNom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTriId As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBoxDepartement As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxFiltre As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDepartement As System.Windows.Forms.Label
    Friend WithEvents GroupBoxRechercheEmploye As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDates As System.Windows.Forms.GroupBox
    Friend WithEvents LabelFin As System.Windows.Forms.Label
    Friend WithEvents LabelDebut As System.Windows.Forms.Label
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ComboBoxType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelType As System.Windows.Forms.Label

    
End Class
