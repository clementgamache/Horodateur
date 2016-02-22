<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Gestionnaire_de_Types
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
        Me.ListBoxTypes = New System.Windows.Forms.ListBox()
        Me.GroupBoxSelectionAction = New System.Windows.Forms.GroupBox()
        Me.RadioButtonInserer = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModifierSupprimer = New System.Windows.Forms.RadioButton()
        Me.TextBoxType = New System.Windows.Forms.TextBox()
        Me.GroupBoxListeTypes = New System.Windows.Forms.GroupBox()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ButtonInserer = New System.Windows.Forms.Button()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.GroupBoxDonnees = New System.Windows.Forms.GroupBox()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelTypeId = New System.Windows.Forms.Label()
        Me.TextBoxTypeId = New System.Windows.Forms.TextBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.GroupBoxGestionTypes = New System.Windows.Forms.GroupBox()
        Me.GroupBoxSelectionAction.SuspendLayout()
        Me.GroupBoxListeTypes.SuspendLayout()
        Me.GroupBoxDonnees.SuspendLayout()
        Me.GroupBoxGestionTypes.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxTypes
        '
        Me.ListBoxTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTypes.FormattingEnabled = True
        Me.ListBoxTypes.ItemHeight = 24
        Me.ListBoxTypes.Location = New System.Drawing.Point(31, 64)
        Me.ListBoxTypes.Name = "ListBoxTypes"
        Me.ListBoxTypes.Size = New System.Drawing.Size(120, 76)
        Me.ListBoxTypes.Sorted = True
        Me.ListBoxTypes.TabIndex = 0
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
        Me.RadioButtonInserer.Size = New System.Drawing.Size(153, 28)
        Me.RadioButtonInserer.TabIndex = 1
        Me.RadioButtonInserer.TabStop = True
        Me.RadioButtonInserer.Text = "Insérer un type" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButtonInserer.UseVisualStyleBackColor = True
        '
        'RadioButtonModifierSupprimer
        '
        Me.RadioButtonModifierSupprimer.AutoSize = True
        Me.RadioButtonModifierSupprimer.Location = New System.Drawing.Point(26, 22)
        Me.RadioButtonModifierSupprimer.Name = "RadioButtonModifierSupprimer"
        Me.RadioButtonModifierSupprimer.Size = New System.Drawing.Size(255, 28)
        Me.RadioButtonModifierSupprimer.TabIndex = 0
        Me.RadioButtonModifierSupprimer.TabStop = True
        Me.RadioButtonModifierSupprimer.Text = "Modifier/Supprimer un type"
        Me.RadioButtonModifierSupprimer.UseVisualStyleBackColor = True
        '
        'TextBoxType
        '
        Me.TextBoxType.Location = New System.Drawing.Point(6, 121)
        Me.TextBoxType.MaxLength = 30
        Me.TextBoxType.Name = "TextBoxType"
        Me.TextBoxType.Size = New System.Drawing.Size(100, 29)
        Me.TextBoxType.TabIndex = 2
        '
        'GroupBoxListeTypes
        '
        Me.GroupBoxListeTypes.Controls.Add(Me.ListBoxTypes)
        Me.GroupBoxListeTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxListeTypes.Location = New System.Drawing.Point(23, 44)
        Me.GroupBoxListeTypes.Name = "GroupBoxListeTypes"
        Me.GroupBoxListeTypes.Size = New System.Drawing.Size(218, 201)
        Me.GroupBoxListeTypes.TabIndex = 14
        Me.GroupBoxListeTypes.TabStop = False
        Me.GroupBoxListeTypes.Text = "Liste des types"
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(103, -40)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(554, 46)
        Me.LabelTitre.TabIndex = 13
        Me.LabelTitre.Text = "Gestionnaire de départements"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonInserer
        '
        Me.ButtonInserer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInserer.Location = New System.Drawing.Point(595, 132)
        Me.ButtonInserer.Name = "ButtonInserer"
        Me.ButtonInserer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInserer.TabIndex = 12
        Me.ButtonInserer.Text = "Insérer"
        Me.ButtonInserer.UseVisualStyleBackColor = True
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupprimer.Location = New System.Drawing.Point(595, 102)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSupprimer.TabIndex = 11
        Me.ButtonSupprimer.Text = "Supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = True
        '
        'ButtonModifier
        '
        Me.ButtonModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.Location = New System.Drawing.Point(595, 71)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModifier.TabIndex = 10
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'GroupBoxDonnees
        '
        Me.GroupBoxDonnees.Controls.Add(Me.LabelType)
        Me.GroupBoxDonnees.Controls.Add(Me.LabelTypeId)
        Me.GroupBoxDonnees.Controls.Add(Me.TextBoxTypeId)
        Me.GroupBoxDonnees.Controls.Add(Me.TextBoxType)
        Me.GroupBoxDonnees.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDonnees.Location = New System.Drawing.Point(26, 181)
        Me.GroupBoxDonnees.Name = "GroupBoxDonnees"
        Me.GroupBoxDonnees.Size = New System.Drawing.Size(200, 184)
        Me.GroupBoxDonnees.TabIndex = 8
        Me.GroupBoxDonnees.TabStop = False
        Me.GroupBoxDonnees.Text = "Données sur le type"
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(3, 107)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(51, 24)
        Me.LabelType.TabIndex = 5
        Me.LabelType.Text = "Nom"
        '
        'LabelTypeId
        '
        Me.LabelTypeId.AutoSize = True
        Me.LabelTypeId.Location = New System.Drawing.Point(60, 56)
        Me.LabelTypeId.Name = "LabelTypeId"
        Me.LabelTypeId.Size = New System.Drawing.Size(25, 24)
        Me.LabelTypeId.TabIndex = 4
        Me.LabelTypeId.Text = "Id"
        '
        'TextBoxTypeId
        '
        Me.TextBoxTypeId.Location = New System.Drawing.Point(7, 75)
        Me.TextBoxTypeId.MaxLength = 2
        Me.TextBoxTypeId.Name = "TextBoxTypeId"
        Me.TextBoxTypeId.Size = New System.Drawing.Size(28, 29)
        Me.TextBoxTypeId.TabIndex = 3
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(595, 182)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuitter.TabIndex = 15
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'GroupBoxGestionTypes
        '
        Me.GroupBoxGestionTypes.Controls.Add(Me.GroupBoxDonnees)
        Me.GroupBoxGestionTypes.Controls.Add(Me.GroupBoxSelectionAction)
        Me.GroupBoxGestionTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestionTypes.Location = New System.Drawing.Point(261, 18)
        Me.GroupBoxGestionTypes.Name = "GroupBoxGestionTypes"
        Me.GroupBoxGestionTypes.Size = New System.Drawing.Size(314, 471)
        Me.GroupBoxGestionTypes.TabIndex = 9
        Me.GroupBoxGestionTypes.TabStop = False
        Me.GroupBoxGestionTypes.Text = "Gestion du type"
        '
        'Fenetre_Gestionnaire_de_Types
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(727, 449)
        Me.Controls.Add(Me.GroupBoxListeTypes)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonInserer)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.GroupBoxGestionTypes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Gestionnaire_de_Types"
        Me.Text = "Fenetre_Gestionnaire_de_types"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxSelectionAction.ResumeLayout(False)
        Me.GroupBoxSelectionAction.PerformLayout()
        Me.GroupBoxListeTypes.ResumeLayout(False)
        Me.GroupBoxDonnees.ResumeLayout(False)
        Me.GroupBoxDonnees.PerformLayout()
        Me.GroupBoxGestionTypes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxTypes As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxSelectionAction As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonInserer As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonModifierSupprimer As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxType As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxListeTypes As System.Windows.Forms.GroupBox
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents ButtonInserer As System.Windows.Forms.Button
    Friend WithEvents ButtonSupprimer As System.Windows.Forms.Button
    Friend WithEvents ButtonModifier As System.Windows.Forms.Button
    Friend WithEvents GroupBoxDonnees As System.Windows.Forms.GroupBox
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents LabelTypeId As System.Windows.Forms.Label
    Friend WithEvents TextBoxTypeId As System.Windows.Forms.TextBox
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
    Friend WithEvents GroupBoxGestionTypes As System.Windows.Forms.GroupBox
End Class
