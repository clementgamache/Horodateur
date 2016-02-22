Public Module Fonctions_globales_compte
    'Méthodes de modifications du compte d'entrées et de sorties 
    Public Sub incrementerCompte()
        Dim nouveauCompte As Integer = obtenirCompte() + 1
        Dim requete As String = "UPDATE Compte SET Compte = " + CStr(nouveauCompte)
        executerTache(requete)
    End Sub
    Public Sub reinitialiserCompte()
        Dim requete As String = "UPDATE Compte SET Compte = 0"
        executerTache(requete)
    End Sub

    'Méthode d'obtention du compte
    Public Function obtenirCompte() As Integer
        CONNEXION.Open()
        Dim Requete As String = "SELECT * FROM Compte"
        Dim Commande As New SqlCommand(Requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        MonReader.Read()
        Dim tempCompte As Integer = MonReader("Compte")
        CONNEXION.Close()
        Return tempCompte
    End Function
End Module
