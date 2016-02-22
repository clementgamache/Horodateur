Public Module Fonctions_globales_mots_de_passe
    Public Sub modifierMotDePasseAdmin1(ByVal nouveauMotDePasse As String)
        Dim requete As String = "UPDATE Table_MotsDePasse SET Admin = '" + nouveauMotDePasse + "'"
        executerTache(requete)
    End Sub

    Public Function obtenirImprimante() As String
        CONNEXION.Open()
        Dim requete As String = "SELECT Imprimante FROM Table_MotsDePasse"
        Dim Commande As New SqlCommand(requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        MonReader.Read()
        Dim tempImprimante As New String(CStr(MonReader("Imprimante")))
        CONNEXION.Close()
        Return tempImprimante
    End Function
    Private Function obtenirMotDePasse(ByVal user As String) As String
        CONNEXION.Open()
        Dim requete As String = "SELECT " + user + " FROM Table_MotsDePasse"
        Dim Commande As New SqlCommand(requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        MonReader.Read()
        Dim tempMotDePasse As New String(CStr(MonReader(user)))
        CONNEXION.Close()
        Return tempMotDePasse
    End Function
    Public Function obtenirMotDePasseAdmin() As String
        Return obtenirMotDePasse("Admin")
    End Function
    
End Module