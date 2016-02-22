Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'With Me
        '    .Size = SystemInformation.PrimaryMonitorSize
        '    .WindowState = 2
        '    '.Location = New Point(0, 0)
        '    .TopMost = True
        '    .FormBorderStyle = 0
        'End With

        Dim employe1 As Employe = New Employe("Babbage", "charles", 102)
        Dim entree1 As Entree_sortie = New Entree_sortie(Date.Now, employe1)
        'Dim entree2 As Entree_sortie = New Entree_sortie(Date.Now, employe1)

    End Sub

    
    
    
End Class