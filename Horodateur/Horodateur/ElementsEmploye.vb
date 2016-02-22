Public MustInherit Class ElementsEmploye
    Public _id As String
    Public _nom As String

    Public Property id As String
        Get
            Return _id
        End Get
        Set(ByVal id As String)
            _id = id
        End Set
    End Property
    Public Property nom As String
        Get
            Return _nom
        End Get
        Set(ByVal nom As String)
            _nom = nom
        End Set
    End Property

End Class

Public Class Type
    Inherits ElementsEmploye

    Public Sub New()
        _id = ""
        _nom = ""
    End Sub
    Sub New(ByVal id As String, ByVal nom As String)
        _id = id
        _nom = nom
    End Sub
    Public Sub insererDansBd()
        Dim requete As String = "Insert into Table_Types values ('" + _id + "', '" + _nom + "')"
        executerTache(requete)
    End Sub
End Class

Public Class Departement
    Inherits ElementsEmploye


    Public Sub New()
        _id = ""
        _nom = ""
    End Sub
    Sub New(ByVal id As String, ByVal nom As String)
        _id = id
        _nom = nom
    End Sub
    'Méthode d'insertion dans la base de données
    Public Sub insererDansBd()
        Dim requete As String = "Insert into Table_Departements values ('" + _id + "', '" + _nom + "')"
        executerTache(requete)
    End Sub
End Class

Public Class Employe
    Inherits ElementsEmploye
    'Attributs
    Public _prenom As String
    Public _idDepartement As String
    Public _idType As String
    Public _punchedIn As Boolean

    Public Sub New()
        _id = ""
        _nom = ""
        _prenom = ""
        _idDepartement = ""
        _idType = ""
        _punchedIn = False
    End Sub
    'Constructeur par paramètres
    Sub New(ByVal id As String, ByVal nom As String, ByVal prenom As String, ByVal idDepartement As String, ByVal idType As String, Optional ByVal punchedIn As Boolean = False)
        _id = id
        _nom = nom
        _prenom = prenom
        _idType = idType
        _idDepartement = idDepartement
        _punchedIn = punchedIn
    End Sub

    'Méthodes Get et set
    Public Property prenom As String
        Get
            Return _prenom
        End Get
        Set(ByVal prenom As String)
            _prenom = prenom
        End Set
    End Property
    Public Property idDepartement As String
        Get
            Return _idDepartement
        End Get
        Set(ByVal idDepartement As String)
            _idDepartement = idDepartement
        End Set
    End Property
    Public Property idType As String
        Get
            Return _idType
        End Get
        Set(ByVal idType As String)
            _idType = idType
        End Set
    End Property
    Public Property punchedIn() As Boolean
        Get
            Return _punchedIn
        End Get
        Set(ByVal punchedIn As Boolean)
            _punchedIn = punchedIn
        End Set
    End Property

    'Méthode d'insertion dans la base de données
    Public Sub insererDansBd()
        Dim requete As String = "Insert into Table_Employes values ('" + _id + "', '" + _nom + "', '" + _prenom + "', '" + _idDepartement + "', '" + _idType + "', '" + CStr(_punchedIn) + "')"
        executerTache(requete)
    End Sub


End Class
