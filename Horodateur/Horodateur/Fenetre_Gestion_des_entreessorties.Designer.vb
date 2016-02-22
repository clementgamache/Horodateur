<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Gestion_des_entreessorties
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
        Me.GroupBoxFiltre = New System.Windows.Forms.GroupBox()
        Me.ComboBoxType = New System.Windows.Forms.ComboBox()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelDepartement = New System.Windows.Forms.Label()
        Me.ComboBoxDepartement = New System.Windows.Forms.ComboBox()
        Me.GroupBoxTri = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTriPrenom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTriNom = New System.Windows.Forms.RadioButton()
        Me.RadioButtonTriId = New System.Windows.Forms.RadioButton()
        Me.ListBoxEmployes = New System.Windows.Forms.ListBox()
        Me.ListBoxEntreeSortie = New System.Windows.Forms.ListBox()
        Me.GroupBoxEntree = New System.Windows.Forms.GroupBox()
        Me.LabelEntreeHeure = New System.Windows.Forms.Label()
        Me.LabelEntreeDate = New System.Windows.Forms.Label()
        Me.LabelEntreeMinuteSeconde = New System.Windows.Forms.Label()
        Me.LabelEntreeHeureMinute = New System.Windows.Forms.Label()
        Me.TextBoxEntreeSeconde = New System.Windows.Forms.TextBox()
        Me.TextBoxEntreeDate = New System.Windows.Forms.TextBox()
        Me.TextBoxEntreeMinute = New System.Windows.Forms.TextBox()
        Me.TextBoxEntreeHeure = New System.Windows.Forms.TextBox()
        Me.GroupBoxSortie = New System.Windows.Forms.GroupBox()
        Me.LabelSortieHeure = New System.Windows.Forms.Label()
        Me.LabelSortieDate = New System.Windows.Forms.Label()
        Me.LabelSortieMinuteSeconde = New System.Windows.Forms.Label()
        Me.TextBoxSortieSeconde = New System.Windows.Forms.TextBox()
        Me.LabelSortieHeureMinute = New System.Windows.Forms.Label()
        Me.TextBoxSortieMinute = New System.Windows.Forms.TextBox()
        Me.TextBoxSortieDate = New System.Windows.Forms.TextBox()
        Me.TextBoxSortieHeure = New System.Windows.Forms.TextBox()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.GroupBoxRechercheEmploye = New System.Windows.Forms.GroupBox()
        Me.GroupBoxGestion = New System.Windows.Forms.GroupBox()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ButtonInserer = New System.Windows.Forms.Button()
        Me.GroupBoxFiltre.SuspendLayout()
        Me.GroupBoxTri.SuspendLayout()
        Me.GroupBoxEntree.SuspendLayout()
        Me.GroupBoxSortie.SuspendLayout()
        Me.GroupBoxRechercheEmploye.SuspendLayout()
        Me.GroupBoxGestion.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxFiltre
        '
        Me.GroupBoxFiltre.Controls.Add(Me.ComboBoxType)
        Me.GroupBoxFiltre.Controls.Add(Me.LabelType)
        Me.GroupBoxFiltre.Controls.Add(Me.LabelDepartement)
        Me.GroupBoxFiltre.Controls.Add(Me.ComboBoxDepartement)
        Me.GroupBoxFiltre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFiltre.Location = New System.Drawing.Point(181, 27)
        Me.GroupBoxFiltre.Name = "GroupBoxFiltre"
        Me.GroupBoxFiltre.Size = New System.Drawing.Size(139, 158)
        Me.GroupBoxFiltre.TabIndex = 12
        Me.GroupBoxFiltre.TabStop = False
        Me.GroupBoxFiltre.Text = "Filtrer par :"
        '
        'ComboBoxType
        '
        Me.ComboBoxType.FormattingEnabled = True
        Me.ComboBoxType.Location = New System.Drawing.Point(6, 106)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(121, 32)
        Me.ComboBoxType.TabIndex = 16
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(6, 77)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(53, 24)
        Me.LabelType.TabIndex = 15
        Me.LabelType.Text = "Type"
        '
        'LabelDepartement
        '
        Me.LabelDepartement.AutoSize = True
        Me.LabelDepartement.Location = New System.Drawing.Point(7, 27)
        Me.LabelDepartement.Name = "LabelDepartement"
        Me.LabelDepartement.Size = New System.Drawing.Size(118, 24)
        Me.LabelDepartement.TabIndex = 12
        Me.LabelDepartement.Text = "Département"
        '
        'ComboBoxDepartement
        '
        Me.ComboBoxDepartement.FormattingEnabled = True
        Me.ComboBoxDepartement.Location = New System.Drawing.Point(0, 37)
        Me.ComboBoxDepartement.Name = "ComboBoxDepartement"
        Me.ComboBoxDepartement.Size = New System.Drawing.Size(140, 32)
        Me.ComboBoxDepartement.TabIndex = 11
        '
        'GroupBoxTri
        '
        Me.GroupBoxTri.Controls.Add(Me.RadioButtonTriPrenom)
        Me.GroupBoxTri.Controls.Add(Me.RadioButtonTriNom)
        Me.GroupBoxTri.Controls.Add(Me.RadioButtonTriId)
        Me.GroupBoxTri.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxTri.Location = New System.Drawing.Point(6, 32)
        Me.GroupBoxTri.Name = "GroupBoxTri"
        Me.GroupBoxTri.Size = New System.Drawing.Size(140, 133)
        Me.GroupBoxTri.TabIndex = 10
        Me.GroupBoxTri.TabStop = False
        Me.GroupBoxTri.Text = "Trier par :"
        '
        'RadioButtonTriPrenom
        '
        Me.RadioButtonTriPrenom.AutoSize = True
        Me.RadioButtonTriPrenom.Location = New System.Drawing.Point(16, 110)
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
        Me.RadioButtonTriNom.Location = New System.Drawing.Point(16, 69)
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
        Me.RadioButtonTriId.Location = New System.Drawing.Point(16, 32)
        Me.RadioButtonTriId.Name = "RadioButtonTriId"
        Me.RadioButtonTriId.Size = New System.Drawing.Size(106, 28)
        Me.RadioButtonTriId.TabIndex = 0
        Me.RadioButtonTriId.TabStop = True
        Me.RadioButtonTriId.Text = "Identifiant"
        Me.RadioButtonTriId.UseVisualStyleBackColor = True
        '
        'ListBoxEmployes
        '
        Me.ListBoxEmployes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEmployes.FormattingEnabled = True
        Me.ListBoxEmployes.ItemHeight = 24
        Me.ListBoxEmployes.Location = New System.Drawing.Point(27, 196)
        Me.ListBoxEmployes.Name = "ListBoxEmployes"
        Me.ListBoxEmployes.Size = New System.Drawing.Size(230, 100)
        Me.ListBoxEmployes.TabIndex = 9
        '
        'ListBoxEntreeSortie
        '
        Me.ListBoxEntreeSortie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxEntreeSortie.FormattingEnabled = True
        Me.ListBoxEntreeSortie.ItemHeight = 24
        Me.ListBoxEntreeSortie.Location = New System.Drawing.Point(27, 19)
        Me.ListBoxEntreeSortie.Name = "ListBoxEntreeSortie"
        Me.ListBoxEntreeSortie.Size = New System.Drawing.Size(350, 244)
        Me.ListBoxEntreeSortie.TabIndex = 17
        '
        'GroupBoxEntree
        '
        Me.GroupBoxEntree.Controls.Add(Me.LabelEntreeHeure)
        Me.GroupBoxEntree.Controls.Add(Me.LabelEntreeDate)
        Me.GroupBoxEntree.Controls.Add(Me.LabelEntreeMinuteSeconde)
        Me.GroupBoxEntree.Controls.Add(Me.LabelEntreeHeureMinute)
        Me.GroupBoxEntree.Controls.Add(Me.TextBoxEntreeSeconde)
        Me.GroupBoxEntree.Controls.Add(Me.TextBoxEntreeDate)
        Me.GroupBoxEntree.Controls.Add(Me.TextBoxEntreeMinute)
        Me.GroupBoxEntree.Controls.Add(Me.TextBoxEntreeHeure)
        Me.GroupBoxEntree.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxEntree.Location = New System.Drawing.Point(13, 271)
        Me.GroupBoxEntree.Name = "GroupBoxEntree"
        Me.GroupBoxEntree.Size = New System.Drawing.Size(200, 163)
        Me.GroupBoxEntree.TabIndex = 18
        Me.GroupBoxEntree.TabStop = False
        Me.GroupBoxEntree.Text = "Entrée"
        '
        'LabelEntreeHeure
        '
        Me.LabelEntreeHeure.AutoSize = True
        Me.LabelEntreeHeure.Location = New System.Drawing.Point(25, 81)
        Me.LabelEntreeHeure.Name = "LabelEntreeHeure"
        Me.LabelEntreeHeure.Size = New System.Drawing.Size(73, 24)
        Me.LabelEntreeHeure.TabIndex = 23
        Me.LabelEntreeHeure.Text = "Heure :"
        '
        'LabelEntreeDate
        '
        Me.LabelEntreeDate.AutoSize = True
        Me.LabelEntreeDate.Location = New System.Drawing.Point(25, 26)
        Me.LabelEntreeDate.Name = "LabelEntreeDate"
        Me.LabelEntreeDate.Size = New System.Drawing.Size(58, 24)
        Me.LabelEntreeDate.TabIndex = 22
        Me.LabelEntreeDate.Text = "Date :"
        '
        'LabelEntreeMinuteSeconde
        '
        Me.LabelEntreeMinuteSeconde.AutoSize = True
        Me.LabelEntreeMinuteSeconde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEntreeMinuteSeconde.Location = New System.Drawing.Point(104, 120)
        Me.LabelEntreeMinuteSeconde.Name = "LabelEntreeMinuteSeconde"
        Me.LabelEntreeMinuteSeconde.Size = New System.Drawing.Size(15, 24)
        Me.LabelEntreeMinuteSeconde.TabIndex = 21
        Me.LabelEntreeMinuteSeconde.Text = ":"
        '
        'LabelEntreeHeureMinute
        '
        Me.LabelEntreeHeureMinute.AutoSize = True
        Me.LabelEntreeHeureMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEntreeHeureMinute.Location = New System.Drawing.Point(55, 115)
        Me.LabelEntreeHeureMinute.Name = "LabelEntreeHeureMinute"
        Me.LabelEntreeHeureMinute.Size = New System.Drawing.Size(15, 24)
        Me.LabelEntreeHeureMinute.TabIndex = 20
        Me.LabelEntreeHeureMinute.Text = ":"
        '
        'TextBoxEntreeSeconde
        '
        Me.TextBoxEntreeSeconde.Location = New System.Drawing.Point(112, 112)
        Me.TextBoxEntreeSeconde.MaxLength = 2
        Me.TextBoxEntreeSeconde.Name = "TextBoxEntreeSeconde"
        Me.TextBoxEntreeSeconde.Size = New System.Drawing.Size(27, 29)
        Me.TextBoxEntreeSeconde.TabIndex = 3
        Me.TextBoxEntreeSeconde.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'TextBoxEntreeDate
        '
        Me.TextBoxEntreeDate.Location = New System.Drawing.Point(25, 45)
        Me.TextBoxEntreeDate.MaxLength = 10
        Me.TextBoxEntreeDate.Name = "TextBoxEntreeDate"
        Me.TextBoxEntreeDate.Size = New System.Drawing.Size(100, 29)
        Me.TextBoxEntreeDate.TabIndex = 0
        Me.TextBoxEntreeDate.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'TextBoxEntreeMinute
        '
        Me.TextBoxEntreeMinute.Location = New System.Drawing.Point(71, 112)
        Me.TextBoxEntreeMinute.MaxLength = 2
        Me.TextBoxEntreeMinute.Name = "TextBoxEntreeMinute"
        Me.TextBoxEntreeMinute.Size = New System.Drawing.Size(27, 29)
        Me.TextBoxEntreeMinute.TabIndex = 2
        Me.TextBoxEntreeMinute.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'TextBoxEntreeHeure
        '
        Me.TextBoxEntreeHeure.Location = New System.Drawing.Point(25, 112)
        Me.TextBoxEntreeHeure.MaxLength = 2
        Me.TextBoxEntreeHeure.Name = "TextBoxEntreeHeure"
        Me.TextBoxEntreeHeure.Size = New System.Drawing.Size(27, 29)
        Me.TextBoxEntreeHeure.TabIndex = 1
        Me.TextBoxEntreeHeure.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'GroupBoxSortie
        '
        Me.GroupBoxSortie.Controls.Add(Me.LabelSortieHeure)
        Me.GroupBoxSortie.Controls.Add(Me.LabelSortieDate)
        Me.GroupBoxSortie.Controls.Add(Me.LabelSortieMinuteSeconde)
        Me.GroupBoxSortie.Controls.Add(Me.TextBoxSortieSeconde)
        Me.GroupBoxSortie.Controls.Add(Me.LabelSortieHeureMinute)
        Me.GroupBoxSortie.Controls.Add(Me.TextBoxSortieMinute)
        Me.GroupBoxSortie.Controls.Add(Me.TextBoxSortieDate)
        Me.GroupBoxSortie.Controls.Add(Me.TextBoxSortieHeure)
        Me.GroupBoxSortie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSortie.Location = New System.Drawing.Point(233, 269)
        Me.GroupBoxSortie.Name = "GroupBoxSortie"
        Me.GroupBoxSortie.Size = New System.Drawing.Size(200, 320)
        Me.GroupBoxSortie.TabIndex = 19
        Me.GroupBoxSortie.TabStop = False
        Me.GroupBoxSortie.Text = "Sortie"
        '
        'LabelSortieHeure
        '
        Me.LabelSortieHeure.AutoSize = True
        Me.LabelSortieHeure.Location = New System.Drawing.Point(15, 112)
        Me.LabelSortieHeure.Name = "LabelSortieHeure"
        Me.LabelSortieHeure.Size = New System.Drawing.Size(73, 24)
        Me.LabelSortieHeure.TabIndex = 25
        Me.LabelSortieHeure.Text = "Heure :"
        '
        'LabelSortieDate
        '
        Me.LabelSortieDate.AutoSize = True
        Me.LabelSortieDate.Location = New System.Drawing.Point(15, 53)
        Me.LabelSortieDate.Name = "LabelSortieDate"
        Me.LabelSortieDate.Size = New System.Drawing.Size(58, 24)
        Me.LabelSortieDate.TabIndex = 24
        Me.LabelSortieDate.Text = "Date :"
        '
        'LabelSortieMinuteSeconde
        '
        Me.LabelSortieMinuteSeconde.AutoSize = True
        Me.LabelSortieMinuteSeconde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSortieMinuteSeconde.Location = New System.Drawing.Point(112, 205)
        Me.LabelSortieMinuteSeconde.Name = "LabelSortieMinuteSeconde"
        Me.LabelSortieMinuteSeconde.Size = New System.Drawing.Size(15, 24)
        Me.LabelSortieMinuteSeconde.TabIndex = 23
        Me.LabelSortieMinuteSeconde.Text = ":"
        '
        'TextBoxSortieSeconde
        '
        Me.TextBoxSortieSeconde.Location = New System.Drawing.Point(133, 190)
        Me.TextBoxSortieSeconde.MaxLength = 2
        Me.TextBoxSortieSeconde.Name = "TextBoxSortieSeconde"
        Me.TextBoxSortieSeconde.Size = New System.Drawing.Size(27, 29)
        Me.TextBoxSortieSeconde.TabIndex = 7
        Me.TextBoxSortieSeconde.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'LabelSortieHeureMinute
        '
        Me.LabelSortieHeureMinute.AutoSize = True
        Me.LabelSortieHeureMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSortieHeureMinute.Location = New System.Drawing.Point(53, 210)
        Me.LabelSortieHeureMinute.Name = "LabelSortieHeureMinute"
        Me.LabelSortieHeureMinute.Size = New System.Drawing.Size(15, 24)
        Me.LabelSortieHeureMinute.TabIndex = 22
        Me.LabelSortieHeureMinute.Text = ":"
        '
        'TextBoxSortieMinute
        '
        Me.TextBoxSortieMinute.Location = New System.Drawing.Point(74, 190)
        Me.TextBoxSortieMinute.MaxLength = 2
        Me.TextBoxSortieMinute.Name = "TextBoxSortieMinute"
        Me.TextBoxSortieMinute.Size = New System.Drawing.Size(27, 29)
        Me.TextBoxSortieMinute.TabIndex = 6
        Me.TextBoxSortieMinute.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'TextBoxSortieDate
        '
        Me.TextBoxSortieDate.Location = New System.Drawing.Point(19, 80)
        Me.TextBoxSortieDate.MaxLength = 10
        Me.TextBoxSortieDate.Name = "TextBoxSortieDate"
        Me.TextBoxSortieDate.Size = New System.Drawing.Size(100, 29)
        Me.TextBoxSortieDate.TabIndex = 4
        Me.TextBoxSortieDate.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'TextBoxSortieHeure
        '
        Me.TextBoxSortieHeure.Location = New System.Drawing.Point(19, 205)
        Me.TextBoxSortieHeure.MaxLength = 2
        Me.TextBoxSortieHeure.Name = "TextBoxSortieHeure"
        Me.TextBoxSortieHeure.Size = New System.Drawing.Size(27, 29)
        Me.TextBoxSortieHeure.TabIndex = 5
        Me.TextBoxSortieHeure.Text = "" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'ButtonModifier
        '
        Me.ButtonModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.Location = New System.Drawing.Point(842, 237)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModifier.TabIndex = 20
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupprimer.Location = New System.Drawing.Point(842, 267)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSupprimer.TabIndex = 21
        Me.ButtonSupprimer.Text = "Supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = True
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(864, 311)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuitter.TabIndex = 22
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'GroupBoxRechercheEmploye
        '
        Me.GroupBoxRechercheEmploye.Controls.Add(Me.ListBoxEmployes)
        Me.GroupBoxRechercheEmploye.Controls.Add(Me.GroupBoxTri)
        Me.GroupBoxRechercheEmploye.Controls.Add(Me.GroupBoxFiltre)
        Me.GroupBoxRechercheEmploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRechercheEmploye.Location = New System.Drawing.Point(35, 79)
        Me.GroupBoxRechercheEmploye.Name = "GroupBoxRechercheEmploye"
        Me.GroupBoxRechercheEmploye.Size = New System.Drawing.Size(326, 311)
        Me.GroupBoxRechercheEmploye.TabIndex = 19
        Me.GroupBoxRechercheEmploye.TabStop = False
        Me.GroupBoxRechercheEmploye.Text = "Recherche de l'employé"
        '
        'GroupBoxGestion
        '
        Me.GroupBoxGestion.Controls.Add(Me.ListBoxEntreeSortie)
        Me.GroupBoxGestion.Controls.Add(Me.GroupBoxEntree)
        Me.GroupBoxGestion.Controls.Add(Me.GroupBoxSortie)
        Me.GroupBoxGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestion.Location = New System.Drawing.Point(368, 79)
        Me.GroupBoxGestion.Name = "GroupBoxGestion"
        Me.GroupBoxGestion.Size = New System.Drawing.Size(451, 597)
        Me.GroupBoxGestion.TabIndex = 4
        Me.GroupBoxGestion.TabStop = False
        Me.GroupBoxGestion.Text = "Gestion de ses passages"
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(141, 13)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(521, 50)
        Me.LabelTitre.TabIndex = 23
        Me.LabelTitre.Text = "Gestionnaire des entrées et des sorties"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonInserer
        '
        Me.ButtonInserer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInserer.Location = New System.Drawing.Point(933, 65)
        Me.ButtonInserer.Name = "ButtonInserer"
        Me.ButtonInserer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInserer.TabIndex = 24
        Me.ButtonInserer.Text = "Insérer"
        Me.ButtonInserer.UseVisualStyleBackColor = True
        '
        'Fenetre_Gestion_des_entreessorties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(1006, 658)
        Me.Controls.Add(Me.ButtonInserer)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBoxGestion)
        Me.Controls.Add(Me.GroupBoxRechercheEmploye)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.ButtonModifier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Gestion_des_entreessorties"
        Me.Text = "Gestion_des_entreessorties"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxFiltre.ResumeLayout(False)
        Me.GroupBoxFiltre.PerformLayout()
        Me.GroupBoxTri.ResumeLayout(False)
        Me.GroupBoxTri.PerformLayout()
        Me.GroupBoxEntree.ResumeLayout(False)
        Me.GroupBoxEntree.PerformLayout()
        Me.GroupBoxSortie.ResumeLayout(False)
        Me.GroupBoxSortie.PerformLayout()
        Me.GroupBoxRechercheEmploye.ResumeLayout(False)
        Me.GroupBoxGestion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxFiltre As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDepartement As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxTri As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonTriPrenom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTriNom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTriId As System.Windows.Forms.RadioButton
    Friend WithEvents ListBoxEmployes As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxEntreeSortie As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxEntree As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxSortie As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxEntreeSeconde As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEntreeMinute As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEntreeHeure As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEntreeDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSortieSeconde As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSortieMinute As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSortieDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSortieHeure As System.Windows.Forms.TextBox
    Friend WithEvents ButtonModifier As System.Windows.Forms.Button
    Friend WithEvents ButtonSupprimer As System.Windows.Forms.Button
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
    Friend WithEvents GroupBoxRechercheEmploye As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxGestion As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDepartement As System.Windows.Forms.Label
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents LabelEntreeHeure As System.Windows.Forms.Label
    Friend WithEvents LabelEntreeDate As System.Windows.Forms.Label
    Friend WithEvents LabelEntreeMinuteSeconde As System.Windows.Forms.Label
    Friend WithEvents LabelEntreeHeureMinute As System.Windows.Forms.Label
    Friend WithEvents LabelSortieHeure As System.Windows.Forms.Label
    Friend WithEvents LabelSortieDate As System.Windows.Forms.Label
    Friend WithEvents LabelSortieMinuteSeconde As System.Windows.Forms.Label
    Friend WithEvents LabelSortieHeureMinute As System.Windows.Forms.Label
    Friend WithEvents ComboBoxType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents ButtonInserer As System.Windows.Forms.Button
End Class
