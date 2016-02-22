<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Gestionnaire_admin
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
        Me.TextBoxActuel = New System.Windows.Forms.TextBox()
        Me.TextBoxNouveau1 = New System.Windows.Forms.TextBox()
        Me.TextBoxNouveau2 = New System.Windows.Forms.TextBox()
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.LabelDemandeAncien = New System.Windows.Forms.Label()
        Me.LabelDemandeNouveau = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.LabelDemandeReecriture = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxActuel
        '
        Me.TextBoxActuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxActuel.Location = New System.Drawing.Point(155, 106)
        Me.TextBoxActuel.Name = "TextBoxActuel"
        Me.TextBoxActuel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxActuel.Size = New System.Drawing.Size(100, 38)
        Me.TextBoxActuel.TabIndex = 0
        '
        'TextBoxNouveau1
        '
        Me.TextBoxNouveau1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNouveau1.Location = New System.Drawing.Point(155, 183)
        Me.TextBoxNouveau1.Name = "TextBoxNouveau1"
        Me.TextBoxNouveau1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxNouveau1.Size = New System.Drawing.Size(100, 38)
        Me.TextBoxNouveau1.TabIndex = 1
        '
        'TextBoxNouveau2
        '
        Me.TextBoxNouveau2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNouveau2.Location = New System.Drawing.Point(156, 272)
        Me.TextBoxNouveau2.Name = "TextBoxNouveau2"
        Me.TextBoxNouveau2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBoxNouveau2.Size = New System.Drawing.Size(100, 38)
        Me.TextBoxNouveau2.TabIndex = 2
        '
        'ButtonValider
        '
        Me.ButtonValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValider.Location = New System.Drawing.Point(173, 326)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(75, 23)
        Me.ButtonValider.TabIndex = 3
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnnuler.Location = New System.Drawing.Point(290, 316)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAnnuler.TabIndex = 4
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'LabelDemandeAncien
        '
        Me.LabelDemandeAncien.AutoSize = True
        Me.LabelDemandeAncien.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDemandeAncien.Location = New System.Drawing.Point(155, 64)
        Me.LabelDemandeAncien.Name = "LabelDemandeAncien"
        Me.LabelDemandeAncien.Size = New System.Drawing.Size(271, 31)
        Me.LabelDemandeAncien.TabIndex = 5
        Me.LabelDemandeAncien.Text = "Mot de passe actuel :"
        '
        'LabelDemandeNouveau
        '
        Me.LabelDemandeNouveau.AutoSize = True
        Me.LabelDemandeNouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDemandeNouveau.Location = New System.Drawing.Point(155, 147)
        Me.LabelDemandeNouveau.Name = "LabelDemandeNouveau"
        Me.LabelDemandeNouveau.Size = New System.Drawing.Size(307, 31)
        Me.LabelDemandeNouveau.TabIndex = 6
        Me.LabelDemandeNouveau.Text = "Nouveau mot de passe :"
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(38, 3)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(578, 61)
        Me.LabelTitre.TabIndex = 7
        Me.LabelTitre.Text = "Modification du mot de passe"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDemandeReecriture
        '
        Me.LabelDemandeReecriture.AutoSize = True
        Me.LabelDemandeReecriture.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDemandeReecriture.Location = New System.Drawing.Point(155, 233)
        Me.LabelDemandeReecriture.Name = "LabelDemandeReecriture"
        Me.LabelDemandeReecriture.Size = New System.Drawing.Size(459, 31)
        Me.LabelDemandeReecriture.TabIndex = 8
        Me.LabelDemandeReecriture.Text = "Réécrivez le nouveau mot de passe :"
        '
        'Fenetre_Gestionnaire_admin
        '
        Me.AcceptButton = Me.ButtonValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonAnnuler
        Me.ClientSize = New System.Drawing.Size(605, 406)
        Me.Controls.Add(Me.LabelDemandeReecriture)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.LabelDemandeNouveau)
        Me.Controls.Add(Me.LabelDemandeAncien)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonValider)
        Me.Controls.Add(Me.TextBoxNouveau2)
        Me.Controls.Add(Me.TextBoxNouveau1)
        Me.Controls.Add(Me.TextBoxActuel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Gestionnaire_admin"
        Me.Text = "Gestionnaire_admin1"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxActuel As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNouveau1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNouveau2 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonValider As System.Windows.Forms.Button
    Friend WithEvents ButtonAnnuler As System.Windows.Forms.Button
    Friend WithEvents LabelDemandeAncien As System.Windows.Forms.Label
    Friend WithEvents LabelDemandeNouveau As System.Windows.Forms.Label
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents LabelDemandeReecriture As System.Windows.Forms.Label
End Class
