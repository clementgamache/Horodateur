Public Class Fenetre_Effacage_memoire

    
    Private Sub ButtonValider_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        Try
            supprimerToutesEntreeSortieAvantLaDateDeBd(DateTimePicker1.Value + TimeSpan.FromDays(1))
            MsgBox(CONFIRMATIONSUPPRESSION, MsgBoxStyle.Information, CONFIRMATIONSUPPRESSION)
        Catch ex As Exception
            MsgBox("L'action n'a pas pu être effectuée", MsgBoxStyle.Critical, "Erreur")
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub


    
    
End Class