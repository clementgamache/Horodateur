<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Gestionnaire_de_Departements
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
        Me.ListBoxDepartements = New System.Windows.Forms.ListBox()
        Me.GroupBoxSelectionAction = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInserer = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModifierSupprimer = New System.Windows.Forms.RadioButton()
        Me.TextBoxDepartement = New System.Windows.Forms.TextBox()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.ButtonInserer = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBoxListeDepartements = New System.Windows.Forms.GroupBox()
        Me.GroupBoxDonnees = New System.Windows.Forms.GroupBox()
        Me.LabelDepartement = New System.Windows.Forms.Label()
        Me.LabelDepartementId = New System.Windows.Forms.Label()
        Me.TextBoxDepartementId = New System.Windows.Forms.TextBox()
        Me.GroupBoxGestionDepartements = New System.Windows.Forms.GroupBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.GroupBoxSelectionAction.SuspendLayout()
        Me.GroupBoxListeDepartements.SuspendLayout()
        Me.GroupBoxDonnees.SuspendLayout()
        Me.GroupBoxGestionDepartements.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxDepartements
        '
        Me.ListBoxDepartements.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDepartements.FormattingEnabled = True
        Me.ListBoxDepartements.ItemHeight = 24
        Me.ListBoxDepartements.Location = New System.Drawing.Point(31, 33)
        Me.ListBoxDepartements.Name = "ListBoxDepartements"
        Me.ListBoxDepartements.Size = New System.Drawing.Size(120, 76)
        Me.ListBoxDepartements.Sorted = True
        Me.ListBoxDepartements.TabIndex = 0
        '
        'GroupBoxSelectionAction
        '
        Me.GroupBoxSelectionAction.Controls.Add(Me.RadioButtonInserer)
        Me.GroupBoxSelectionAction.Controls.Add(Me.RadioButtonModifierSupprimer)
        Me.GroupBoxSelectionAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSelectionAction.Location = New System.Drawing.Point(26, 35)
        Me.GroupBoxSelectionAction.Name = "GroupBoxSelectionAction"
        Me.GroupBoxSelectionAction.Size = New System.Drawing.Size(200, 100)
        Me.GroupBoxSelectionAction.TabIndex = 1
        Me.GroupBoxSelectionAction.TabStop = False
        Me.GroupBoxSelectionAction.Text = "Sélectionnez :"
        '
        'RadioButtonInserer
        '
        Me.RadioButtonInserer.AutoSize = True
        Me.RadioButtonInserer.Location = New System.Drawing.Point(26, 55)
        Me.RadioButtonInserer.Name = "RadioButtonInserer"
        Me.RadioButtonInserer.Size = New System.Drawing.Size(224, 28)
        Me.RadioButtonInserer.TabIndex = 1
        Me.RadioButtonInserer.TabStop = True
        Me.RadioButtonInserer.Text = "Insérer un département"
        Me.RadioButtonInserer.UseVisualStyleBackColor = True
        '
        'RadioButtonModifierSupprimer
        '
        Me.RadioButtonModifierSupprimer.AutoSize = True
        Me.RadioButtonModifierSupprimer.Location = New System.Drawing.Point(26, 22)
        Me.RadioButtonModifierSupprimer.Name = "RadioButtonModifierSupprimer"
        Me.RadioButtonModifierSupprimer.Size = New System.Drawing.Size(326, 28)
        Me.RadioButtonModifierSupprimer.TabIndex = 0
        Me.RadioButtonModifierSupprimer.TabStop = True
        Me.RadioButtonModifierSupprimer.Text = "Modifier/Supprimer un département"
        Me.RadioButtonModifierSupprimer.UseVisualStyleBackColor = True
        '
        'TextBoxDepartement
        '
        Me.TextBoxDepartement.Location = New System.Drawing.Point(6, 121)
        Me.TextBoxDepartement.MaxLength = 30
        Me.TextBoxDepartement.Name = "TextBoxDepartement"
        Me.TextBoxDepartement.Size = New System.Drawing.Size(100, 29)
        Me.TextBoxDepartement.TabIndex = 2
        '
        'ButtonModifier
        '
        Me.ButtonModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.Location = New System.Drawing.Point(612, 120)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModifier.TabIndex = 3
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupprimer.Location = New System.Drawing.Point(612, 151)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSupprimer.TabIndex = 4
        Me.ButtonSupprimer.Text = "Supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = True
        '
        'ButtonInserer
        '
        Me.ButtonInserer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInserer.Location = New System.Drawing.Point(612, 181)
        Me.ButtonInserer.Name = "ButtonInserer"
        Me.ButtonInserer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInserer.TabIndex = 5
        Me.ButtonInserer.Text = "Insérer"
        Me.ButtonInserer.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(120, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(554, 46)
        Me.LabelTitre.TabIndex = 6
        Me.LabelTitre.Text = "Gestionnaire de départements"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxListeDepartements
        '
        Me.GroupBoxListeDepartements.Controls.Add(Me.ListBoxDepartements)
        Me.GroupBoxListeDepartements.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxListeDepartements.Location = New System.Drawing.Point(40, 93)
        Me.GroupBoxListeDepartements.Name = "GroupBoxListeDepartements"
        Me.GroupBoxListeDepartements.Size = New System.Drawing.Size(218, 201)
        Me.GroupBoxListeDepartements.TabIndex = 7
        Me.GroupBoxListeDepartements.TabStop = False
        Me.GroupBoxListeDepartements.Text = "Liste des départements"
        '
        'GroupBoxDonnees
        '
        Me.GroupBoxDonnees.Controls.Add(Me.LabelDepartement)
        Me.GroupBoxDonnees.Controls.Add(Me.LabelDepartementId)
        Me.GroupBoxDonnees.Controls.Add(Me.TextBoxDepartementId)
        Me.GroupBoxDonnees.Controls.Add(Me.TextBoxDepartement)
        Me.GroupBoxDonnees.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDonnees.Location = New System.Drawing.Point(26, 181)
        Me.GroupBoxDonnees.Name = "GroupBoxDonnees"
        Me.GroupBoxDonnees.Size = New System.Drawing.Size(200, 184)
        Me.GroupBoxDonnees.TabIndex = 8
        Me.GroupBoxDonnees.TabStop = False
        Me.GroupBoxDonnees.Text = "Données sur le département"
        '
        'LabelDepartement
        '
        Me.LabelDepartement.AutoSize = True
        Me.LabelDepartement.Location = New System.Drawing.Point(3, 107)
        Me.LabelDepartement.Name = "LabelDepartement"
        Me.LabelDepartement.Size = New System.Drawing.Size(51, 24)
        Me.LabelDepartement.TabIndex = 5
        Me.LabelDepartement.Text = "Nom"
        '
        'LabelDepartementId
        '
        Me.LabelDepartementId.AutoSize = True
        Me.LabelDepartementId.Location = New System.Drawing.Point(60, 56)
        Me.LabelDepartementId.Name = "LabelDepartementId"
        Me.LabelDepartementId.Size = New System.Drawing.Size(25, 24)
        Me.LabelDepartementId.TabIndex = 4
        Me.LabelDepartementId.Text = "Id"
        '
        'TextBoxDepartementId
        '
        Me.TextBoxDepartementId.Location = New System.Drawing.Point(7, 75)
        Me.TextBoxDepartementId.MaxLength = 2
        Me.TextBoxDepartementId.Name = "TextBoxDepartementId"
        Me.TextBoxDepartementId.Size = New System.Drawing.Size(28, 29)
        Me.TextBoxDepartementId.TabIndex = 3
        '
        'GroupBoxGestionDepartements
        '
        Me.GroupBoxGestionDepartements.Controls.Add(Me.GroupBoxDonnees)
        Me.GroupBoxGestionDepartements.Controls.Add(Me.GroupBoxSelectionAction)
        Me.GroupBoxGestionDepartements.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionDepartements.Location = New System.Drawing.Point(278, 67)
        Me.GroupBoxGestionDepartements.Name = "GroupBoxGestionDepartements"
        Me.GroupBoxGestionDepartements.Size = New System.Drawing.Size(314, 471)
        Me.GroupBoxGestionDepartements.TabIndex = 1
        Me.GroupBoxGestionDepartements.TabStop = False
        Me.GroupBoxGestionDepartements.Text = "Gestion du département"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(612, 231)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuitter.TabIndex = 8
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Fenetre_Gestionnaire_de_Departements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(741, 550)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.GroupBoxGestionDepartements)
        Me.Controls.Add(Me.GroupBoxListeDepartements)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonInserer)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.ButtonModifier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Gestionnaire_de_Departements"
        Me.Text = "Gestionnaire_de_Departements"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxSelectionAction.ResumeLayout(False)
        Me.GroupBoxSelectionAction.PerformLayout()
        Me.GroupBoxListeDepartements.ResumeLayout(False)
        Me.GroupBoxDonnees.ResumeLayout(False)
        Me.GroupBoxDonnees.PerformLayout()
        Me.GroupBoxGestionDepartements.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxDepartements As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxSelectionAction As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonInserer As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonModifierSupprimer As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxDepartement As System.Windows.Forms.TextBox
    Friend WithEvents ButtonModifier As System.Windows.Forms.Button
    Friend WithEvents ButtonSupprimer As System.Windows.Forms.Button
    Friend WithEvents ButtonInserer As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents GroupBoxListeDepartements As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxDonnees As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxGestionDepartements As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
    Friend WithEvents LabelDepartement As System.Windows.Forms.Label
    Friend WithEvents LabelDepartementId As System.Windows.Forms.Label
    Friend WithEvents TextBoxDepartementId As System.Windows.Forms.TextBox
End Class
