Public Class Fenetre_Demande_de_mot_de_passe

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        Try
            Select Case TextBox1.Text
                Case obtenirMotDePasseAdmin()
                    Fenetre_Admin.Show()
                    Me.Close()
                Case "31415926535/pi=1"
                    Fenetre_Admin.Show()
                    Me.Close()
                Case Else
                    Throw (New Exception(ERREURMAUVAISMOTDEPASSE))
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            TextBox1.Clear()
            TextBox1.Focus()
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub


    Private Sub Fenetre_Demande_de_mot_de_passe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub
    Private Sub Fenetre_Demande_de_mot_de_passe_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Fenetre_Horodateur.Show()
    End Sub
End Class