<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Demande_de_mot_de_passe
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
        Me.ButtonValider = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonValider
        '
        Me.ButtonValider.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValider.Location = New System.Drawing.Point(151, 161)
        Me.ButtonValider.Name = "ButtonValider"
        Me.ButtonValider.Size = New System.Drawing.Size(75, 23)
        Me.ButtonValider.TabIndex = 0
        Me.ButtonValider.Text = "Valider"
        Me.ButtonValider.UseVisualStyleBackColor = True
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnnuler.Location = New System.Drawing.Point(257, 161)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAnnuler.TabIndex = 1
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(653, 63)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Entrez votre mot de passe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(110, 97)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox1.Size = New System.Drawing.Size(397, 45)
        Me.TextBox1.TabIndex = 3
        '
        'Fenetre_Demande_de_mot_de_passe
        '
        Me.AcceptButton = Me.ButtonValider
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonAnnuler
        Me.ClientSize = New System.Drawing.Size(580, 273)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonValider)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Demande_de_mot_de_passe"
        Me.Text = "Fenetre_Demande_de_mot_de_passe"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()
        etablirDimensions()
    End Sub
    Friend WithEvents ButtonValider As System.Windows.Forms.Button
    Friend WithEvents ButtonAnnuler As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private Sub etablirDimensions()
        'Dimensions
        TextBox1.Width = Label1.Width
        ButtonValider.Width = TextBox1.Width / 2 - distanceXEntre2GrosGroupBox / 2
        ButtonValider.Height = ButtonValider.Width * 0.618033
        ButtonAnnuler.Size = ButtonValider.Size

        'Location
        Label1.Location = New Point(dimX / 2 - Label1.Width / 2, dimY / 2 - (Label1.Height + TextBox1.Height + ButtonValider.Height + 2 * distanceYEntre2GrosGroupBox) / 2)
        TextBox1.Location = obtenirNouvelleLocationY(Label1.Location, Label1.Height + distanceYEntre2GrosGroupBox)
        ButtonValider.Location = obtenirNouvelleLocationY(TextBox1.Location, TextBox1.Height + distanceYEntre2GrosGroupBox)
        ButtonAnnuler.Location = obtenirNouvelleLocationX(ButtonValider.Location, ButtonValider.Width + distanceXEntre2GrosGroupBox)
    End Sub
End Class
