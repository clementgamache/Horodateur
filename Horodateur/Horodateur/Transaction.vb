Public Class Transaction
    Private _code As Integer
    Private _entree As EntreeSortie
    Private _sortie As EntreeSortie
    Private _id As String

    Public Property code As Integer
        Get
            Return _code
        End Get
        Set(value As Integer)

        End Set
    End Property
    Public Property entree As EntreeSortie
        Get
            Return _entree
        End Get
        Set(value As EntreeSortie)

        End Set
    End Property
    Public Property sortie As EntreeSortie
        Get
            Return _sortie
        End Get
        Set(value As EntreeSortie)

        End Set
    End Property
    Public Property id As String
        Get
            Return _id
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property affichage As String
        Get
            Return CStr(code) + " - " + CStr(entree.temps) + " - " + CStr(sortie.temps)
        End Get
        Set(value As String)

        End Set
    End Property
    Sub New(ByVal entree As EntreeSortie, ByVal sortie As EntreeSortie)
        _code = entree.code
        _entree = entree
        _sortie = sortie
        _id = entree.id
    End Sub
    Public Sub modifier(ByVal date1 As Date, ByVal date2 As Date)
        modifierEntreeSortieDeBd(_entree.temps, date1)
        modifierEntreeSortieDeBd(_sortie.temps, date2)

    End Sub
    Public Sub inserer()
        _entree.insererDansBd()
        _sortie.insererDansBd()
    End Sub
    Public Sub supprimer()
        supprimerEntreeSortieDeBd(_entree.temps)
        supprimerEntreeSortieDeBd(_sortie.temps)
    End Sub
End Class
