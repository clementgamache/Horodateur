<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Gestionnaire_d_employes
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
        Me.GroupBoxSelectionAction = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInserer = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModifierSupprimer = New System.Windows.Forms.RadioButton()
        Me.GroupBoxDonnees = New System.Windows.Forms.GroupBox()
        Me.LabelTypeDonnee = New System.Windows.Forms.Label()
        Me.ComboBoxTypeDonnee = New System.Windows.Forms.ComboBox()
        Me.LabelDepartementDonnee = New System.Windows.Forms.Label()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.ComboBoxDepartementDonnee = New System.Windows.Forms.ComboBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.ButtonInserer = New System.Windows.Forms.Button()
        Me.GroupBoxGestionEmploye = New System.Windows.Forms.GroupBox()
        Me.GroupBoxRechercheEmploye = New System.Windows.Forms.GroupBox()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.GroupBoxFiltre.SuspendLayout()
        Me.GroupBoxTri.SuspendLayout()
        Me.GroupBoxSelectionAction.SuspendLayout()
        Me.GroupBoxDonnees.SuspendLayout()
        Me.GroupBoxGestionEmploye.SuspendLayout()
        Me.GroupBoxRechercheEmploye.SuspendLayout()
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
        Me.ComboBoxType.Location = New System.Drawing.Point(7, 103)
        Me.ComboBoxType.Name = "ComboBoxType"
        Me.ComboBoxType.Size = New System.Drawing.Size(121, 32)
        Me.ComboBoxType.TabIndex = 14
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(7, 74)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(53, 24)
        Me.LabelType.TabIndex = 13
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
        Me.ComboBoxDepartement.Location = New System.Drawing.Point(6, 36)
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
        'GroupBoxSelectionAction
        '
        Me.GroupBoxSelectionAction.Controls.Add(Me.RadioButtonInserer)
        Me.GroupBoxSelectionAction.Controls.Add(Me.RadioButtonModifierSupprimer)
        Me.GroupBoxSelectionAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSelectionAction.Location = New System.Drawing.Point(22, 26)
        Me.GroupBoxSelectionAction.Name = "GroupBoxSelectionAction"
        Me.GroupBoxSelectionAction.Size = New System.Drawing.Size(207, 88)
        Me.GroupBoxSelectionAction.TabIndex = 13
        Me.GroupBoxSelectionAction.TabStop = False
        Me.GroupBoxSelectionAction.Text = "Sélectionnez :"
        '
        'RadioButtonInserer
        '
        Me.RadioButtonInserer.AutoSize = True
        Me.RadioButtonInserer.Location = New System.Drawing.Point(7, 48)
        Me.RadioButtonInserer.Name = "RadioButtonInserer"
        Me.RadioButtonInserer.Size = New System.Drawing.Size(191, 28)
        Me.RadioButtonInserer.TabIndex = 1
        Me.RadioButtonInserer.TabStop = True
        Me.RadioButtonInserer.Text = "Insérer un employé"
        Me.RadioButtonInserer.UseVisualStyleBackColor = True
        '
        'RadioButtonModifierSupprimer
        '
        Me.RadioButtonModifierSupprimer.AutoSize = True
        Me.RadioButtonModifierSupprimer.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonModifierSupprimer.Name = "RadioButtonModifierSupprimer"
        Me.RadioButtonModifierSupprimer.Size = New System.Drawing.Size(293, 28)
        Me.RadioButtonModifierSupprimer.TabIndex = 0
        Me.RadioButtonModifierSupprimer.TabStop = True
        Me.RadioButtonModifierSupprimer.Text = "Modifier/Supprimer un employé"
        Me.RadioButtonModifierSupprimer.UseVisualStyleBackColor = True
        '
        'GroupBoxDonnees
        '
        Me.GroupBoxDonnees.Controls.Add(Me.LabelTypeDonnee)
        Me.GroupBoxDonnees.Controls.Add(Me.ComboBoxTypeDonnee)
        Me.GroupBoxDonnees.Controls.Add(Me.LabelDepartementDonnee)
        Me.GroupBoxDonnees.Controls.Add(Me.LabelPrenom)
        Me.GroupBoxDonnees.Controls.Add(Me.LabelNom)
        Me.GroupBoxDonnees.Controls.Add(Me.LabelId)
        Me.GroupBoxDonnees.Controls.Add(Me.ComboBoxDepartementDonnee)
        Me.GroupBoxDonnees.Controls.Add(Me.TextBoxPrenom)
        Me.GroupBoxDonnees.Controls.Add(Me.TextBoxNom)
        Me.GroupBoxDonnees.Controls.Add(Me.TextBoxId)
        Me.GroupBoxDonnees.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDonnees.Location = New System.Drawing.Point(29, 133)
        Me.GroupBoxDonnees.Name = "GroupBoxDonnees"
        Me.GroupBoxDonnees.Size = New System.Drawing.Size(200, 251)
        Me.GroupBoxDonnees.TabIndex = 14
        Me.GroupBoxDonnees.TabStop = False
        Me.GroupBoxDonnees.Text = "Données"
        '
        'LabelTypeDonnee
        '
        Me.LabelTypeDonnee.AutoSize = True
        Me.LabelTypeDonnee.Location = New System.Drawing.Point(11, 196)
        Me.LabelTypeDonnee.Name = "LabelTypeDonnee"
        Me.LabelTypeDonnee.Size = New System.Drawing.Size(53, 24)
        Me.LabelTypeDonnee.TabIndex = 11
        Me.LabelTypeDonnee.Text = "Type"
        '
        'ComboBoxTypeDonnee
        '
        Me.ComboBoxTypeDonnee.FormattingEnabled = True
        Me.ComboBoxTypeDonnee.Location = New System.Drawing.Point(11, 224)
        Me.ComboBoxTypeDonnee.Name = "ComboBoxTypeDonnee"
        Me.ComboBoxTypeDonnee.Size = New System.Drawing.Size(121, 32)
        Me.ComboBoxTypeDonnee.TabIndex = 10
        '
        'LabelDepartementDonnee
        '
        Me.LabelDepartementDonnee.AutoSize = True
        Me.LabelDepartementDonnee.Location = New System.Drawing.Point(7, 141)
        Me.LabelDepartementDonnee.Name = "LabelDepartementDonnee"
        Me.LabelDepartementDonnee.Size = New System.Drawing.Size(118, 24)
        Me.LabelDepartementDonnee.TabIndex = 9
        Me.LabelDepartementDonnee.Text = "Département"
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(7, 102)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(77, 24)
        Me.LabelPrenom.TabIndex = 8
        Me.LabelPrenom.Text = "Prénom"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(7, 59)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(51, 24)
        Me.LabelNom.TabIndex = 7
        Me.LabelNom.Text = "Nom"
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(7, 20)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(88, 24)
        Me.LabelId.TabIndex = 6
        Me.LabelId.Text = "Identifiant"
        '
        'ComboBoxDepartementDonnee
        '
        Me.ComboBoxDepartementDonnee.FormattingEnabled = True
        Me.ComboBoxDepartementDonnee.Location = New System.Drawing.Point(10, 157)
        Me.ComboBoxDepartementDonnee.Name = "ComboBoxDepartementDonnee"
        Me.ComboBoxDepartementDonnee.Size = New System.Drawing.Size(121, 32)
        Me.ComboBoxDepartementDonnee.TabIndex = 3
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(10, 118)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(100, 29)
        Me.TextBoxPrenom.TabIndex = 2
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(10, 75)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(100, 29)
        Me.TextBoxNom.TabIndex = 1
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(0, 40)
        Me.TextBoxId.MaxLength = 3
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(40, 29)
        Me.TextBoxId.TabIndex = 0
        '
        'ButtonModifier
        '
        Me.ButtonModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.Location = New System.Drawing.Point(773, 20)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(134, 146)
        Me.ButtonModifier.TabIndex = 15
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupprimer.Location = New System.Drawing.Point(755, 207)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(152, 85)
        Me.ButtonSupprimer.TabIndex = 16
        Me.ButtonSupprimer.Text = "Supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = True
        '
        'ButtonInserer
        '
        Me.ButtonInserer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInserer.Location = New System.Drawing.Point(788, 307)
        Me.ButtonInserer.Name = "ButtonInserer"
        Me.ButtonInserer.Size = New System.Drawing.Size(102, 87)
        Me.ButtonInserer.TabIndex = 17
        Me.ButtonInserer.Text = "Insérer"
        Me.ButtonInserer.UseVisualStyleBackColor = True
        '
        'GroupBoxGestionEmploye
        '
        Me.GroupBoxGestionEmploye.Controls.Add(Me.GroupBoxSelectionAction)
        Me.GroupBoxGestionEmploye.Controls.Add(Me.GroupBoxDonnees)
        Me.GroupBoxGestionEmploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionEmploye.Location = New System.Drawing.Point(433, 33)
        Me.GroupBoxGestionEmploye.Name = "GroupBoxGestionEmploye"
        Me.GroupBoxGestionEmploye.Size = New System.Drawing.Size(248, 420)
        Me.GroupBoxGestionEmploye.TabIndex = 18
        Me.GroupBoxGestionEmploye.TabStop = False
        Me.GroupBoxGestionEmploye.Text = "Gestion de l'employé"
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
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(32, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(309, 48)
        Me.LabelTitre.TabIndex = 20
        Me.LabelTitre.Text = "Gestionnaire d'employés"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(788, 396)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(87, 84)
        Me.ButtonQuitter.TabIndex = 21
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Fenetre_Gestionnaire_d_employes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(941, 562)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.GroupBoxRechercheEmploye)
        Me.Controls.Add(Me.GroupBoxGestionEmploye)
        Me.Controls.Add(Me.ButtonInserer)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.ButtonModifier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Gestionnaire_d_employes"
        Me.Text = "Gestionnaire_d_employes"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxFiltre.ResumeLayout(False)
        Me.GroupBoxFiltre.PerformLayout()
        Me.GroupBoxTri.ResumeLayout(False)
        Me.GroupBoxTri.PerformLayout()
        Me.GroupBoxSelectionAction.ResumeLayout(False)
        Me.GroupBoxSelectionAction.PerformLayout()
        Me.GroupBoxDonnees.ResumeLayout(False)
        Me.GroupBoxDonnees.PerformLayout()
        Me.GroupBoxGestionEmploye.ResumeLayout(False)
        Me.GroupBoxRechercheEmploye.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxFiltre As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDepartement As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxTri As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonTriPrenom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTriNom As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTriId As System.Windows.Forms.RadioButton
    Friend WithEvents ListBoxEmployes As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxSelectionAction As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonInserer As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonModifierSupprimer As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxDonnees As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDepartementDonnee As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxId As System.Windows.Forms.TextBox
    Friend WithEvents LabelDepartementDonnee As System.Windows.Forms.Label
    Friend WithEvents LabelPrenom As System.Windows.Forms.Label
    Friend WithEvents LabelNom As System.Windows.Forms.Label
    Friend WithEvents LabelId As System.Windows.Forms.Label
    Friend WithEvents ButtonModifier As System.Windows.Forms.Button
    Friend WithEvents ButtonSupprimer As System.Windows.Forms.Button
    Friend WithEvents ButtonInserer As System.Windows.Forms.Button
    Friend WithEvents GroupBoxGestionEmploye As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxRechercheEmploye As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
    Friend WithEvents LabelDepartement As System.Windows.Forms.Label
    Friend WithEvents ComboBoxType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents LabelTypeDonnee As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTypeDonnee As System.Windows.Forms.ComboBox
End Class
