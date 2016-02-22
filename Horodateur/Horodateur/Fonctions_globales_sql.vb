Public Module Fonctions_globales_sql
    Public CONNEXION As New SqlConnection("Data Source=(local);Initial Catalog=Horodateur_BD;User Id=sa;Password=31415926535/pi=1;")
    'Pour les tâches
    Public Sub executerTache(ByVal requete As String)
        CONNEXION.Open()
        Dim Commande As New SqlCommand(requete, CONNEXION)
        Commande.ExecuteNonQuery()
        CONNEXION.Close()
    End Sub

    'Pour les recherches
    Public Function dataSetRequete(ByVal requete As String) As DataSet
        Dim Commande As New SqlCommand(requete, CONNEXION)
        Dim Adaptateur As New SqlDataAdapter(Commande)
        Dim MonDataSet As New DataSet
        Adaptateur.Fill(MonDataSet, "Table")
        Return MonDataSet
    End Function
End Module