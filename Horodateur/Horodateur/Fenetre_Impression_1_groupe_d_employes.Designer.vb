<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Impression_1_groupe_d_employes
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
        Me.ComboBoxDepartement = New System.Windows.Forms.ComboBox()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonImprimer = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBoxDepartement = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDates = New System.Windows.Forms.GroupBox()
        Me.LabelFin = New System.Windows.Forms.Label()
        Me.LabelDebut = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBoxFiltre = New System.Windows.Forms.GroupBox()
        Me.GroupBoxType = New System.Windows.Forms.GroupBox()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.GroupBoxDepartement.SuspendLayout()
        Me.GroupBoxDates.SuspendLayout()
        Me.GroupBoxFiltre.SuspendLayout()
        Me.GroupBoxType.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxDepartement
        '
        Me.ComboBoxDepartement.FormattingEnabled = True
        Me.ComboBoxDepartement.Location = New System.Drawing.Point(23, 43)
        Me.ComboBoxDepartement.Name = "ComboBoxDepartement"
        Me.ComboBoxDepartement.Size = New System.Drawing.Size(140, 32)
        Me.ComboBoxDepartement.TabIndex = 12
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar2.Location = New System.Drawing.Point(12, 268)
        Me.MonthCalendar2.MaxSelectionCount = 1
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.ShowToday = False
        Me.MonthCalendar2.TabIndex = 11
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(12, 25)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.TabIndex = 10
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(637, 322)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(151, 69)
        Me.ButtonQuitter.TabIndex = 9
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonImprimer
        '
        Me.ButtonImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImprimer.Location = New System.Drawing.Point(637, 186)
        Me.ButtonImprimer.Name = "ButtonImprimer"
        Me.ButtonImprimer.Size = New System.Drawing.Size(203, 87)
        Me.ButtonImprimer.TabIndex = 8
        Me.ButtonImprimer.Text = "Imprimer"
        Me.ButtonImprimer.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'GroupBoxDepartement
        '
        Me.GroupBoxDepartement.Controls.Add(Me.ComboBoxDepartement)
        Me.GroupBoxDepartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDepartement.Location = New System.Drawing.Point(33, 36)
        Me.GroupBoxDepartement.Name = "GroupBoxDepartement"
        Me.GroupBoxDepartement.Size = New System.Drawing.Size(200, 100)
        Me.GroupBoxDepartement.TabIndex = 14
        Me.GroupBoxDepartement.TabStop = False
        Me.GroupBoxDepartement.Text = "Département :"
        '
        'GroupBoxDates
        '
        Me.GroupBoxDates.Controls.Add(Me.LabelFin)
        Me.GroupBoxDates.Controls.Add(Me.LabelDebut)
        Me.GroupBoxDates.Controls.Add(Me.MonthCalendar1)
        Me.GroupBoxDates.Controls.Add(Me.MonthCalendar2)
        Me.GroupBoxDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDates.Location = New System.Drawing.Point(277, 118)
        Me.GroupBoxDates.Name = "GroupBoxDates"
        Me.GroupBoxDates.Size = New System.Drawing.Size(319, 607)
        Me.GroupBoxDates.TabIndex = 15
        Me.GroupBoxDates.TabStop = False
        Me.GroupBoxDates.Text = "Sélection des dates"
        '
        'LabelFin
        '
        Me.LabelFin.AutoSize = True
        Me.LabelFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFin.Location = New System.Drawing.Point(91, 236)
        Me.LabelFin.Name = "LabelFin"
        Me.LabelFin.Size = New System.Drawing.Size(169, 24)
        Me.LabelFin.TabIndex = 14
        Me.LabelFin.Text = "Fin (inclusivement)"
        '
        'LabelDebut
        '
        Me.LabelDebut.AutoSize = True
        Me.LabelDebut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDebut.Location = New System.Drawing.Point(37, 55)
        Me.LabelDebut.Name = "LabelDebut"
        Me.LabelDebut.Size = New System.Drawing.Size(70, 24)
        Me.LabelDebut.TabIndex = 13
        Me.LabelDebut.Text = "Début :"
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.LabelTitre.Location = New System.Drawing.Point(-1, -4)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(597, 67)
        Me.LabelTitre.TabIndex = 12
        Me.LabelTitre.Text = "Impression du rapport des heures d'un groupe d'employés"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxFiltre
        '
        Me.GroupBoxFiltre.Controls.Add(Me.GroupBoxType)
        Me.GroupBoxFiltre.Controls.Add(Me.GroupBoxDepartement)
        Me.GroupBoxFiltre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFiltre.Location = New System.Drawing.Point(37, 137)
        Me.GroupBoxFiltre.Name = "GroupBoxFiltre"
        Me.GroupBoxFiltre.Size = New System.Drawing.Size(248, 276)
        Me.GroupBoxFiltre.TabIndex = 16
        Me.GroupBoxFiltre.TabStop = False
        Me.GroupBoxFiltre.Text = "Filtres"
        '
        'GroupBoxType
        '
        Me.GroupBoxType.Controls.Add(Me.ComboBoxType)
        Me.GroupBoxType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxType.Location = New System.Drawing.Point(33, 170)
        Me.GroupBoxType.Name = "GroupBoxType"
        Me.GroupBoxType.Size = New System.Drawing.Size(200, 100)
        Me.GroupBoxType.TabIndex = 15
        Me.GroupBoxType.TabStop = False
        Me.GroupBoxType.Text = "Type :"
        '
        'ComboBoxType
        '
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Location = New System.Drawing.Point(23, 43)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(140, 32)
        Me.ComboBoxType.TabIndex = 12
        '
        'Fenetre_Impression_1_groupe_d_employes
        '
        Me.AcceptButton = Me.ButtonImprimer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(900, 527)
        Me.Controls.Add(Me.GroupBoxFiltre)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBoxDates)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonImprimer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Impression_1_groupe_d_employes"
        Me.Text = "Impression_1_Departement"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxDepartement.ResumeLayout(False)
        Me.GroupBoxDates.ResumeLayout(False)
        Me.GroupBoxDates.PerformLayout()
        Me.GroupBoxFiltre.ResumeLayout(False)
        Me.GroupBoxType.ResumeLayout(False)
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents ComboBoxDepartement As System.Windows.Forms.ComboBox
    Friend WithEvents MonthCalendar2 As System.Windows.Forms.MonthCalendar
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
    Friend WithEvents ButtonImprimer As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents GroupBoxDepartement As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDates As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDebut As System.Windows.Forms.Label
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBoxFiltre As System.Windows.Forms.GroupBox
    Friend WithEvents LabelFin As System.Windows.Forms.Label
    Friend WithEvents GroupBoxType As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxType As System.Windows.Forms.ComboBox
End Class
