Public Class EntreeSortie
    Private _temps As Date
    Private _id As String
    Private _entree As Boolean
    Private _code As Integer

    Sub New()
        _temps = Date.Now
        _id = ""
        _entree = False
        _code = 0
    End Sub
    Sub New(ByVal id As String)
        _temps = Date.Now
        _id = id
        Dim tempEmploye As Employe = obtenirEmploye(_id)
        _entree = tempEmploye.punchedIn
        If (entree) Then
            incrementerCompte()
            _code = obtenirCompte()
        Else
            _code = 0
        End If
    End Sub
    Sub New(ByVal tempDate As Date, ByVal tempId As String, ByVal tempCode As Integer, ByVal tempEntree As Boolean)
        _temps = tempDate
        _id = tempId
        _code = tempCode
        _entree = tempEntree
    End Sub


    Public Property entree() As Boolean
        Get
            Return _entree
        End Get
        Set(ByVal entree As Boolean)
            _entree = entree
        End Set
    End Property

    Public Property temps() As Date
        Get
            Return _temps
        End Get
        Set(ByVal temps As Date)
            _temps = temps
        End Set
    End Property

    Public Property code() As Integer
        Get
            Return _code
        End Get
        Set(ByVal code As Integer)
            _code = code
        End Set
    End Property

    Public Property id() As String
        Get
            Return _id
        End Get
        Set(value As String)

        End Set
    End Property
    Public Sub insererDansBd()
        Dim requete As String = "Insert into Table_EntreeSortie values ('" + _temps.ToString + "', '" + _id + "', '" + CStr(_entree) + "', " + CStr(_code) + ")"
        executerTache(requete)
    End Sub

End Class
