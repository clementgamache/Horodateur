<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Effacage_memoire
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.LabelExplication = New System.Windows.Forms.Label()
        Me.GroupBoxSelection = New System.Windows.Forms.GroupBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.GroupBoxSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.TabIndex = 0
        '
        'ButtonValider
        '
        Me.ButtonValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.TabIndex = 1
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.TabIndex = 2
        Me.LabelTitre.Text = "Effacement d'une partie des entrées et des sorties"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelExplication
        '
        Me.LabelExplication.AutoSize = True
        Me.LabelExplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExplication.Name = "LabelExplication"
        Me.LabelExplication.TabIndex = 3
        Me.LabelExplication.Text = "Date des derniers éléments à supprimer"
        '
        'GroupBoxSelection
        '
        Me.GroupBoxSelection.Controls.Add(Me.LabelExplication)
        Me.GroupBoxSelection.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxSelection.Name = "GroupBoxSelection"
        Me.GroupBoxSelection.TabIndex = 4
        Me.GroupBoxSelection.TabStop = False
        Me.GroupBoxSelection.Text = "Sélection de la date"
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.TabIndex = 5
        Me.ButtonQuitter.Text = "Annuler"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Fenetre_Effacage_memoire
        '
        Me.AcceptButton = Me.ButtonValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(577, 273)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.GroupBoxSelection)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.ButtonValider)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Effacage_memoire"
        Me.Text = "Fenetre_Effacage_memoire"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxSelection.ResumeLayout(False)
        Me.GroupBoxSelection.PerformLayout()
        Me.ResumeLayout(False)
        etablirDimensions()
    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonValider As System.Windows.Forms.Button
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents LabelExplication As System.Windows.Forms.Label
    Friend WithEvents GroupBoxSelection As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button

    Private Sub etablirDimensions()
        'Dimensions en x
        LabelTitre.Width = dimX
        GroupBoxSelection.Width = dimX / 2
        ButtonValider.Width = (GroupBoxSelection.Width - distanceXEntre2GrosGroupBox) / 2
        ButtonQuitter.Width = ButtonValider.Width

        'Location en x
        LabelTitre.Location = New Point(0, 0)
        GroupBoxSelection.Location = New Point(dimX / 2 - GroupBoxSelection.Width / 2, 0)
        ButtonValider.Location = GroupBoxSelection.Location
        ButtonQuitter.Location = obtenirNouvelleLocationX(ButtonValider.Location, ButtonValider.Width + distanceXEntre2GrosGroupBox)

        etablirGroupboxSelection()

        'Dimensions en y
        LabelTitre.Height = hauteurLabelTitre
        GroupBoxSelection.Height = obtenirHauteurGroupBox(DateTimePicker1)
        ButtonValider.Height = ButtonValider.Width * 0.618033
        ButtonQuitter.Height = ButtonValider.Height

        'Locations en y
        GroupBoxSelection.Location = obtenirNouvelleLocationY(GroupBoxSelection.Location, LabelTitre.Height + 2 * distanceYEntre2GrosGroupBox)
        ButtonValider.Location = obtenirNouvelleLocationY(GroupBoxSelection.Location, GroupBoxSelection.Height + distanceYEntre2GrosGroupBox)
        ButtonQuitter.Location = obtenirNouvelleLocationX(ButtonValider.Location, ButtonValider.Width + distanceXEntre2GrosGroupBox)
    End Sub
    Private Sub etablirGroupBoxSelection()
        DateTimePicker1.Width = LabelExplication.Width
        LabelExplication.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, locationYDuPremierElementDUnGrosGroupBox)
        DateTimePicker1.Location = obtenirNouvelleLocationY(LabelExplication.Location, LabelExplication.Height + distanceYEntre2PetitsGroupBox)
    End Sub
End Class
