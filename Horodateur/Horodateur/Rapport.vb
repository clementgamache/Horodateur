Public Class Rapport
    Private ESPACECODE As Integer = 14
    Private ESPACEDATE As Integer = 14
    Private ESPACEHEURE As Integer = 14
    Private ESPACETEMPS As Integer = 10
    Private ESPACEDESCRIPTIONEMPLOYE As Integer = 11
    Private ESPACETOTAL As Integer = NBPPARLIGNE

    Private _idEmploye As String
    Private _stringEmploye As String
    Private _stringContenu As List(Of String)
    Private _stringTotal As String

    Public Property hauteur As Integer
        Get
            Return hEMPLOYE.Height + 4 / 3 * p.Height + p.Height * (_stringContenu.Count - 2) + hTOTAL.Height + ESPACEAJOUTE
        End Get
        Set(value As Integer)

        End Set
    End Property
    Public Property idEmploye As String
        Get
            Return _idEmploye
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property stringEmploye As String
        Get
            Return _stringEmploye
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property stringContenu As List(Of String)
        Get
            Return _stringContenu
        End Get
        Set(value As List(Of String))

        End Set
    End Property
    Public Property stringTotal As String
        Get
            Return _stringTotal
        End Get
        Set(value As String)

        End Set
    End Property

    Private Function forcerTailleDroite(ByVal entree As String, ByVal taille As Integer) As String
        If entree.Length >= taille - 1 Then
            Return entree.Substring(0, taille - 1) + " "
        Else
            While entree.Length < taille - 1
                entree += " "
            End While
            entree += " "
            Return entree
        End If
    End Function
    Private Function forcerTailleGauche(ByVal entree As String, ByVal taille As Integer) As String
        If entree.Length >= taille - 1 Then
            Return entree.Substring(0, taille - 1) + " "
        Else
            While entree.Length < taille - 1
                entree = " " + entree
            End While
            entree += " "
            Return entree
        End If
    End Function
    Private Function employeAString(ByVal employe As Employe) As String
        Dim deuxp As String = " : "
        Dim espace As String = "    "
        Dim strTempo As String = _
        "Nom" + deuxp + employe.nom.ToUpper + ", " + employe.prenom.ToUpper + espace + _
        "Id" + deuxp + employe.id
        Return strTempo
    End Function
    Private Function nomColonnes() As String
        Dim strTempo As String = _
        forcerTailleDroite("No. Trans", ESPACECODE) + _
        forcerTailleDroite("Date entrée", ESPACEDATE) + _
        forcerTailleDroite("Date sortie", ESPACEDATE) + _
        forcerTailleDroite("Heure entrée", ESPACEHEURE) + _
        forcerTailleDroite("Heure sortie", ESPACEHEURE) + _
        forcerTailleGauche("Minutes", ESPACETEMPS)
        Return strTempo
    End Function
    Private Function entreeSortieAString(ByVal entree As EntreeSortie, ByVal sortie As EntreeSortie) As String
        Dim strEntreeSortie As String = _
            forcerTailleDroite(CStr(entree.code), ESPACECODE) + _
            forcerTailleDroite(entree.temps.ToShortDateString, ESPACEDATE) + _
            forcerTailleDroite(sortie.temps.ToShortDateString, ESPACEDATE) + _
            forcerTailleDroite(entree.temps.ToLongTimeString, ESPACEHEURE) + _
            forcerTailleDroite(sortie.temps.ToLongTimeString, ESPACEHEURE) + _
            forcerTailleGauche(CStr(CInt(Math.Floor((sortie.temps - entree.temps).TotalMinutes + (sortie.temps - entree.temps).TotalHours / 60.0 + (sortie.temps - entree.temps).TotalDays / 1440.0))), ESPACETEMPS)
        Return strEntreeSortie
    End Function
    Private Function tabEntreeSortieAString(ByVal tabEntreeSortie As EntreeSortie()) As List(Of String)
        Dim strTempo As New List(Of String)
        For i As Integer = 0 To rejeterEntreesInutiles(tabEntreeSortie).Length - 1 Step +2
            strTempo.Add(entreeSortieAString(rejeterEntreesInutiles(tabEntreeSortie)(i), rejeterEntreesInutiles(tabEntreeSortie)(i + 1)))
        Next
        Return strTempo
    End Function
    Private Function sommeMinutes(ByVal tabEntreeSortie As EntreeSortie()) As Integer
        Dim somme As Integer = 0
        For i As Integer = 0 To rejeterEntreesInutiles(tabEntreeSortie).Length - 1 Step +2
            somme += CInt(Math.Floor((rejeterEntreesInutiles(tabEntreeSortie)(i + 1).temps - rejeterEntreesInutiles(tabEntreeSortie)(i).temps).TotalMinutes))
        Next
        Return somme
    End Function
    Private Function sommeHeures(ByVal sommeMinutes As Integer) As Double
        Return CDbl(CInt(Math.Floor(sommeMinutes * 4.0 / 60.0)) / 4.0)
    End Function
    Sub New(ByVal id As String, ByVal dateDebut As Date, ByVal dateFin As Date)
        _idEmploye = id
        _stringEmploye = employeAString(obtenirEmploye(id))
        _stringContenu = New List(Of String)
        _stringContenu.Add(New String("_", ESPACETOTAL - 1))
        '_stringContenu.Add(New String("_", ESPACETOTAL - 1))
        _stringContenu.Add(nomColonnes)
        _stringContenu.Add(New String("_", ESPACETOTAL - 1))
        Dim listeEntreeSortie As List(Of String) = tabEntreeSortieAString(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin))
        For i As Integer = 0 To listeEntreeSortie.Count - 1
            _stringContenu.Add(listeEntreeSortie(i))
        Next
        _stringContenu.Add(New String("_", ESPACETOTAL - 1))
        _stringContenu.Add(forcerTailleGauche("Total de minutes : " + CStr(sommeMinutes(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin))), ESPACETOTAL))
        _stringContenu.Add(forcerTailleGauche(New String("_", ("Total de minutes : " + CStr(sommeMinutes(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin)))).Length), ESPACETOTAL))



        _stringTotal = forcerTailleGauche("Total d'heures : " + CStr(FormatNumber(sommeHeures(sommeMinutes(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin))), 2)), NBHTOTALPARLIGNE)
        '_stringTotal = forcerTailleGauche("Total d'heures : " + CStr(FormatNumber(sommeHeures(sommeMinutes(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin))), 2)), ESPACETOTAL)

        'tabEntreeSortieAString(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin)) + _
        'New String("_", ESPACETOTAL - 1) + vbNewLine + _
        'forcerTailleGauche("Total de minutes : " + CStr(sommeMinutes(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin))), ESPACETOTAL) + vbNewLine + _
        'forcerTailleGauche(New String("_", "Total de minutes".Length + 4), ESPACETOTAL))
        '_stringTotal = forcerTailleGauche("Total d'heures : " + FormatNumber(sommeHeures(sommeMinutes(obtenirEntreesSortiesEmploye(id, dateDebut, dateFin))), 2), ESPACETOTAL)

    End Sub
    
End Class
