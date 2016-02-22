Public Module Fonctions_ElementsEmploye
    Private Const NOMTABLEEMPLOYES As String = "Table_Employes"
    Private Const NOMTABLEDEPARTEMENTS As String = "Table_Departements"
    Private Const NOMTABLETYPES As String = "Table_Types"
    'Savoir si l'élément est dans la base de données
    Private Function estDansBd(ByVal id As String, ByVal nomTable As String)
        CONNEXION.Open()
        Dim Requete As String = "SELECT * FROM " + nomTable + " where Id = '" + id + "'"
        Dim Commande As New SqlCommand(Requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        If MonReader.Read() Then
            CONNEXION.Close()
            Return True
        End If
        CONNEXION.Close()
        Return False
    End Function
    Public Function departementEstDansBd(ByVal id As String) As Boolean
        Return estDansBd(id, NOMTABLEDEPARTEMENTS)
    End Function
    Public Function typeEstDansBd(ByVal id As String) As Boolean
        Return estDansBd(id, NOMTABLETYPES)
    End Function
    Public Function employeEstDansBd(ByVal id As String) As Boolean
        Return estDansBd(id, NOMTABLEEMPLOYES)
    End Function
    'Supprimer un élément
    Private Sub supprimerDeTable(ByVal id As String, ByVal nomTable As String)
        executerTache("DELETE FROM " + nomTable + " WHERE Id = '" + id + "'")
    End Sub
    Public Sub supprimerDepartement(ByVal id As String)
        supprimerDeTable(id, NOMTABLEDEPARTEMENTS)
    End Sub
    Public Sub supprimerType(ByVal id As String)
        supprimerDeTable(id, NOMTABLETYPES)
    End Sub
    Public Sub supprimerEmploye(ByVal id As String)
        supprimerDeTable(id, NOMTABLEEMPLOYES)
    End Sub
    'Supprimer tous les éléments
    Private Sub supprimerTable(ByVal nomTable As String)
        executerTache("DELETE FROM " + nomTable)
    End Sub
    Public Sub supprimerTousDepartements()
        supprimerTable(NOMTABLEDEPARTEMENTS)
    End Sub
    Public Sub supprimerTousTypes()
        supprimerTable(NOMTABLETYPES)
    End Sub
    Public Sub supprimerTousEmployes()
        supprimerTable(NOMTABLEEMPLOYES)
    End Sub
    'Modifier les éléments liés à l'id
    Private Sub modifierElement(ByVal id As String, ByVal nomTable As String, ByVal nom As String, Optional ByVal prenom As String = "", Optional ByVal idDepartement As String = "", Optional ByVal idType As String = "")
        Dim requete As String = ""
        If nomTable = NOMTABLEDEPARTEMENTS Or nomTable = NOMTABLETYPES Then
            requete = "UPDATE " + nomTable + " SET Nom = '" + nom + "' WHERE Id = '" + id + "'"
        ElseIf nomTable = NOMTABLEEMPLOYES Then
            requete = "UPDATE " + NOMTABLEEMPLOYES + " SET Nom = '" + nom + "', Prenom = '" + prenom + "', IdDepartement = '" + idDepartement + "', IdType = '" + idType + "' WHERE Id = '" + id + "'"
        End If
        executerTache(requete)
    End Sub
    Public Sub renommerDepartement(ByVal id As String, ByVal nom As String)
        modifierElement(id, NOMTABLEDEPARTEMENTS, nom)
    End Sub
    Public Sub renommerType(ByVal id As String, ByVal nom As String)
        modifierElement(id, NOMTABLETYPES, nom)
    End Sub
    Public Sub modifierEmploye(ByVal id As String, ByVal nom As String, ByVal prenom As String, ByVal idDepartement As String, ByVal idType As String)
        modifierElement(id, NOMTABLEEMPLOYES, nom, prenom, idDepartement, idType)
    End Sub
    'Savoir si un employé possède la caractéristique
    Public Function utiliseParAuMoinsUnEmploye(ByVal idCaracteristique As String, ByVal nomCaracteristique As String) As Boolean
        CONNEXION.Open()
        Dim Requete As String = "SELECT * FROM Table_Employes where Id" + nomCaracteristique + " = '" + idCaracteristique + "'"
        Dim Commande As New SqlCommand(Requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        If MonReader.Read() Then
            CONNEXION.Close()
            Return True
        End If
        CONNEXION.Close()
        Return False
    End Function
    Public Function departementUtilise(ByVal id As String) As Boolean
        Return utiliseParAuMoinsUnEmploye(id, "Departement")
    End Function
    Public Function typeUtilise(ByVal id As String) As Boolean
        Return utiliseParAuMoinsUnEmploye(id, "Type")
    End Function
    'Méthode d'obtention des Types
    Private Function obtenirTypes(ByVal requete As String) As Type()
        CONNEXION.Open()
        Dim MonDataSet As DataSet = dataSetRequete(requete)
        Dim compte As Integer = CInt(MonDataSet.Tables("Table").Rows.Count)
        Dim tabTypesDeRequete(compte - 1) As Type
        For i As Integer = 0 To compte - 1
            Dim ligne As DataRow = MonDataSet.Tables("Table").Rows(i)
            Dim tempTypeDeRequete As New Type(ligne("Id"), ligne("Nom"))
            tabTypesDeRequete(i) = tempTypeDeRequete
        Next
        CONNEXION.Close()
        Return tabTypesDeRequete
    End Function
    Public Function obtenirType(ByVal id As String) As Type
        CONNEXION.Open()
        Dim requete As String = "SELECT * FROM Table_Types where Id = '" + id + "'"
        Dim Commande As New SqlCommand(requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        MonReader.Read()
        Dim tempType As New Type(MonReader("Id"), MonReader("Nom"))
        CONNEXION.Close()
        Return tempType

    End Function
    Public Function obtenirTousTypes() As Type()
        Dim requete As String = "SELECT * FROM Table_Types"
        Return obtenirTypes(requete)
    End Function
    'Départements
    'Méthode d'obtention des Departements
    Private Function obtenirDepartements(ByVal requete As String) As Departement()
        CONNEXION.Open()
        Dim MonDataSet As DataSet = dataSetRequete(requete)
        Dim compte As Integer = CInt(MonDataSet.Tables("Table").Rows.Count)
        Dim tabDepartementsDeRequete(compte - 1) As Departement
        For i As Integer = 0 To compte - 1
            Dim ligne As DataRow = MonDataSet.Tables("Table").Rows(i)
            Dim tempDepartementDeRequete As New Departement(ligne("Id"), ligne("Nom"))
            tabDepartementsDeRequete(i) = tempDepartementDeRequete
        Next
        CONNEXION.Close()
        Return tabDepartementsDeRequete
    End Function
    Public Function obtenirDepartement(ByVal id As String) As Departement
        CONNEXION.Open()
        Dim requete As String = "SELECT * FROM Table_Departements where Id = '" + id + "'"
        Dim Commande As New SqlCommand(requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        MonReader.Read()
        Dim tempDepartement As New Departement(MonReader("Id"), MonReader("Nom"))
        CONNEXION.Close()
        Return tempDepartement
    End Function
    Public Function obtenirTousDepartements() As Departement()
        Dim requete As String = "SELECT * FROM Table_Departements"
        Return obtenirDepartements(requete)
    End Function
    'Employé
    'Méthode de modifications d'employés
    Public Sub punchInOut(ByVal id As String)
        Dim tempEmploye As Employe = obtenirEmploye(id)
        Dim inversePunchedIn As Boolean = Not tempEmploye.punchedIn
        Dim requete As String = "UPDATE Table_Employes SET PunchedIn = '" + CStr(inversePunchedIn) + "' WHERE Id = " + CStr(id)
        executerTache(requete)
    End Sub
    'Méthode d'obtention d'un employé
    Public Function obtenirEmploye(ByVal id As String) As Employe
        CONNEXION.Open()
        Dim Requete As String = "SELECT * FROM Table_Employes where Id = '" + id + "'"
        Dim Commande As New SqlCommand(Requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        MonReader.Read()
        'CONNEXION.Close()
        Dim tempEmploye As New Employe(MonReader("Id"), MonReader("Nom"), MonReader("Prenom"), MonReader("IdDepartement"), MonReader("IdType"), CBool(MonReader("PunchedIn")))
        'CONNEXION.Open()
        CONNEXION.Close()
        Return tempEmploye
    End Function
    'Méthodes d'obtention de tableaux d'employés
    Private Function obtenirEmployes(ByVal requete As String) As Employe()
        CONNEXION.Open()
        Dim MonDataSet As DataSet = dataSetRequete(requete)
        Dim compte As Integer = CInt(MonDataSet.Tables("Table").Rows.Count)
        Dim tabEmployesDeRequete(compte - 1) As Employe
        For i As Integer = 0 To compte - 1
            Dim ligne As DataRow = MonDataSet.Tables("Table").Rows(i)
            CONNEXION.Close()
            Dim tempEmployeDeRequete As New Employe(ligne("Id"), ligne("Nom"), ligne("Prenom"), ligne("IdDepartement"), ligne("IdType"), CBool(ligne("PunchedIn")))
            CONNEXION.Open()
            tabEmployesDeRequete(i) = tempEmployeDeRequete
        Next
        CONNEXION.Close()
        Return tabEmployesDeRequete
    End Function
    Public Function obtenirTousEmployes() As Employe()
        Dim requete As String = "select * from Table_Employes"
        Return obtenirEmployes(requete)
    End Function
    Public Function obtenirEmployesDuDepartement(ByVal idDepartement As String) As Employe()
        Dim requete As String = "select * from Table_Employes where IdDepartement = '" + idDepartement + "'"
        Return obtenirEmployes(requete)
    End Function
    Public Function obtenirEmployesDuType(ByVal idType) As Employe()
        Dim requete As String = "select * from Table_Employes where IdType = '" + idType + "'"
        Return obtenirEmployes(requete)
    End Function
    Public Function obtenirEmployesTypeEtDepartement(ByVal idDepartement As String, ByVal idType As String)
        Dim requete As String = "select * from Table_Employes where IdType = '" + idType + "' and IdDepartement = '" + idDepartement + "'"
        Return obtenirEmployes(requete)
    End Function

    
End Module
