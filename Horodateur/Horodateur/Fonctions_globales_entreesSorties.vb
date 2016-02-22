Public Module Fonctions_globales_entreesSorties
    'Méthodes de modification d'entrées et de sorties (insertions dans la classe)
    Public Sub modifierEntreeSortieDeBd(ByVal datePrec As Date, ByVal nouvelleDate As Date)
        Dim requete As String = "UPDATE Table_EntreeSortie SET Date = '" + nouvelleDate.ToString + "' WHERE Date = '" + CStr(datePrec) + "'"
        executerTache(requete)
    End Sub
    Public Sub supprimerEntreeSortieDeBd(ByVal date1 As Date)
        Dim requete As String = "DELETE FROM Table_EntreeSortie WHERE Date = '" + CStr(date1) + "'"
        executerTache(requete)
    End Sub
    Public Sub supprimerToutesEntreeSortieAvantLaDateDeBd(ByVal date1 As Date)
        Dim requete As String = "DELETE FROM Table_EntreeSortie WHERE Date <= '" + CStr(date1) + "'"
        executerTache(requete)
    End Sub
    Public Sub supprimerEntreeSortieDEmploye(ByVal id As String)
        Dim requete As String = "DELETE FROM Table_EntreeSortie WHERE IdEmploye = '" + id + "'"
        executerTache(requete)
    End Sub
    Public Sub supprimerToutesEntreeSortie()
        Dim requete As String = "DELETE FROM Table_EntreeSortie"
        executerTache(requete)
    End Sub


    'Méthode de modification d'un tableau pour retirer les entrées sans sorties ou les sorties sans entrées
    Public Function rejeterEntreesInutiles(ByVal tabEntreSortie As EntreeSortie()) As EntreeSortie()
        If tabEntreSortie.Count <> 0 Then
            If tabEntreSortie(0).entree = False Then
                For i As Integer = 1 To tabEntreSortie.Length - 1
                    tabEntreSortie(i - 1) = tabEntreSortie(i)
                Next
                ReDim Preserve tabEntreSortie(tabEntreSortie.Length - 2)
            End If
            If tabEntreSortie.Count <> 0 Then
                If tabEntreSortie(tabEntreSortie.Length - 1).entree Then
                    ReDim Preserve tabEntreSortie(tabEntreSortie.Length - 2)
                End If
            End If
        End If
        Return tabEntreSortie
    End Function

    'Méthode d'obtention d'une entrée
    Public Function chercherEntreeSortieEntreDansTransaction(ByVal trans As Transaction) As Boolean
        CONNEXION.Open()
        Dim Requete As String = "SELECT * FROM Table_EntreeSortie where IdEmploye = '" + trans.id + "' and Date <> '" + trans.entree.temps + "' and Date <> '" + trans.sortie.temps + "' and Date between '" + trans.entree.temps + "' and '" + trans.sortie.temps + "' order by Date"
        Dim Commande As New SqlCommand(Requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        Dim resultat As Boolean = MonReader.Read()
        CONNEXION.Close()
        Return resultat
    End Function
    Public Function estDansTransactionExistante(ByVal insertion As Transaction)
        For i As Integer = 0 To obtenirEntreesSortiesEmploye(insertion.id, "2000-05-29 10:44:06.000", Date.Now).Length - 2
            Dim es1 As EntreeSortie = obtenirEntreesSortiesEmploye(insertion.id, "2000-05-29 10:44:06.000", Date.Now)(i)
            Dim es2 As EntreeSortie = obtenirEntreesSortiesEmploye(insertion.id, "2000-05-29 10:44:06.000", Date.Now)(i + 1)
            If es1.entree = True Then
                If DateTime.Compare(insertion.entree.temps, es1.temps) > 0 And DateTime.Compare(es2.temps, insertion.entree.temps) > 0 Then
                    Return True
                End If
                If DateTime.Compare(insertion.sortie.temps, es1.temps) > 0 And DateTime.Compare(es2.temps, insertion.sortie.temps) > 0 Then
                    Return True
                End If
            End If
        Next
        Return False

    End Function
    Public Function obtenirEntreeSortieCode(ByVal code As Integer) As EntreeSortie
        CONNEXION.Open()
        Dim Requete As String = "SELECT * FROM Table_EntreeSortie where Code = " + CStr(code)
        Dim Commande As New SqlCommand(Requete, CONNEXION)
        Dim MonReader As SqlDataReader = Commande.ExecuteReader()
        MonReader.Read()
        Dim tempEntreeSortie As New EntreeSortie(CDate(MonReader("Date")), CStr(MonReader("Id")), CInt(MonReader("Code")), CBool(MonReader("Entree")))
        CONNEXION.Close()
        Return tempEntreeSortie
    End Function

    'Méthodes d'obtention de tableaux d'entrées et sorties
    Private Function obtenirEntreesSorties(ByVal requete As String) As EntreeSortie()
        CONNEXION.Open()
        Dim MonDataSet As DataSet = dataSetRequete(requete)
        Dim compte As Integer = CInt(MonDataSet.Tables("Table").Rows.Count)
        Dim tabEntreesSorties(compte - 1) As EntreeSortie
        For i As Integer = 0 To compte - 1
            Dim ligne As DataRow = MonDataSet.Tables("Table").Rows(i)
            Dim tempEntreeSortie As New EntreeSortie(CDate(ligne("Date")), ligne("IdEmploye"), ligne("Code"), ligne("Entree"))
            tabEntreesSorties(i) = tempEntreeSortie
        Next
        CONNEXION.Close()
        Return tabEntreesSorties
    End Function
    Public Function obtenirEntreesSortiesEmploye(ByVal id As String, ByVal date1 As Date, ByVal date2 As Date) As EntreeSortie()
        Dim requete As String = "select * from Table_EntreeSortie where Date between '" + date1 + "' and '" + date2 + "' and IdEmploye = '" + id + "' order by Date"
        Return obtenirEntreesSorties(requete)
    End Function
    Public Function obtenirEntreesSortiesTousEmployes(ByVal date1 As Date, ByVal date2 As Date) As EntreeSortie()
        Dim requete As String = "select * from Table_EntreeSortie where Date between '" + date1 + "' and '" + date2 + "' Order by Date"
        Return obtenirEntreesSorties(requete)
    End Function
    Public Function obtenirToutesEntreesSorties()
        Dim requete As String = "select * from Table_EntreeSortie Order By Date"
        Return obtenirEntreesSorties(requete)
    End Function
End Module
