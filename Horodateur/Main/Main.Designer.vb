<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.Bouton1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bouton1
        '
        Me.Bouton1.Location = New System.Drawing.Point(0, 0)
        Me.Bouton1.Name = "Bouton1"
        Me.Bouton1.Size = New System.Drawing.Size(75, 23)
        Me.Bouton1.TabIndex = 0
        Me.Bouton1.Text = "1"
        Me.Bouton1.UseVisualStyleBackColor = True
        '
        'Main
        '
        With Me
            .Size = SystemInformation.PrimaryMonitorSize
            .WindowState = 2
            '.Location = New Point(0, 0)
            .TopMost = True
            .FormBorderStyle = 0
            'auto
            .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            .Controls.Add(Me.Bouton1)
            .Name = "Horodateur"
            .Text = "Horodateur"
            .ResumeLayout(False)
        End With
        

    End Sub
    Friend WithEvents Bouton1 As System.Windows.Forms.Button
End Class
