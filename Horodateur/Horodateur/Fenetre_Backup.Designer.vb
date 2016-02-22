<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenetre_Backup
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
        Me.ButtonParcourir = New System.Windows.Forms.Button()
        Me.ButtonBackUp = New System.Windows.Forms.Button()
        Me.LabelConsignes = New System.Windows.Forms.Label()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonParcourir
        '
        Me.ButtonParcourir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParcourir.Location = New System.Drawing.Point(215, 110)
        Me.ButtonParcourir.Name = "ButtonParcourir"
        Me.ButtonParcourir.Size = New System.Drawing.Size(112, 29)
        Me.ButtonParcourir.TabIndex = 0
        Me.ButtonParcourir.Text = "Parcourir..."
        Me.ButtonParcourir.UseVisualStyleBackColor = True
        '
        'ButtonBackUp
        '
        Me.ButtonBackUp.Enabled = False
        Me.ButtonBackUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackUp.Location = New System.Drawing.Point(154, 169)
        Me.ButtonBackUp.Name = "ButtonBackUp"
        Me.ButtonBackUp.Size = New System.Drawing.Size(121, 74)
        Me.ButtonBackUp.TabIndex = 1
        Me.ButtonBackUp.Text = "Sauvegarder les " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "données du locigiel"
        Me.ButtonBackUp.UseVisualStyleBackColor = True
        '
        'LabelConsignes
        '
        Me.LabelConsignes.AutoSize = True
        Me.LabelConsignes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelConsignes.Location = New System.Drawing.Point(84, 81)
        Me.LabelConsignes.Name = "LabelConsignes"
        Me.LabelConsignes.Size = New System.Drawing.Size(364, 24)
        Me.LabelConsignes.TabIndex = 2
        Me.LabelConsignes.Text = "Choisissez la destination de la sauvegarde"
        '
        'LabelTitre
        '
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(518, 56)
        Me.LabelTitre.TabIndex = 3
        Me.LabelTitre.Text = "Sauvegarde de données"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(87, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 29)
        Me.TextBox1.TabIndex = 4
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(355, 195)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(75, 23)
        Me.ButtonQuitter.TabIndex = 5
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'Fenetre_Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonQuitter
        Me.ClientSize = New System.Drawing.Size(542, 273)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Controls.Add(Me.LabelConsignes)
        Me.Controls.Add(Me.ButtonBackUp)
        Me.Controls.Add(Me.ButtonParcourir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Fenetre_Backup"
        Me.Text = "Fenetre_Backup"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonParcourir As System.Windows.Forms.Button
    Friend WithEvents ButtonBackUp As System.Windows.Forms.Button
    Friend WithEvents LabelConsignes As System.Windows.Forms.Label
    Friend WithEvents LabelTitre As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonQuitter As System.Windows.Forms.Button
End Class
