Public Class Fenetre_impression_plusieurs_employes_par_page
    Private listeDeRapports As Rapport()
    Private indice As Integer
    Private nombreDeLignesDansLaPage As Integer
    Private departementsValides As Departement()
    Private noDePage As Integer
    Private poursuite As Integer

    'Chargement de la page
    Private Sub Impression_1_groupe_d_employes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
        remplirComboBoxDepartements(ComboBoxDepartement, True)
        remplirComboBoxTypes(ComboBoxType, True)
        ComboBoxDepartement.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList
        setCaracteristiquesImprimante(PrintDocument1)
        MonthCalendar1.SelectionStart = Date.Now - TimeSpan.FromDays(1)
    End Sub


    'Évènements

    'ComboBox
    Private Sub ComboBoxDepartements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartement.SelectedIndexChanged
        miseAJourButton()
    End Sub
    Private Sub ComboBoxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxType.SelectedIndexChanged
        miseAJourButton()
    End Sub
    'Calendriers
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Try
            If MonthCalendar2.SelectionStart < MonthCalendar1.SelectionStart Then
                MonthCalendar1.SelectionStart = MonthCalendar2.SelectionStart - TimeSpan.FromDays(1)
                Throw (New Exception(ERREURDATEFINAVANTDATEDEBUT))
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
        
        miseAJourButton()
    End Sub
    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        Try
            If MonthCalendar2.SelectionStart < MonthCalendar1.SelectionStart Then
                MonthCalendar2.SelectionStart = MonthCalendar1.SelectionStart + TimeSpan.FromDays(1)
                Throw (New Exception(ERREURDATEFINAVANTDATEDEBUT))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
        miseAJourButton()
    End Sub
    'Buttons
    Private Sub ButtonImprimer_Click(sender As Object, e As EventArgs) Handles ButtonImprimer.Click
        indice = 0
        noDePage = 1
        
        Try
            ReDim listeDeRapports(obtenirListeDEmployesDemandes.Length - 1)
            For i As Integer = 0 To obtenirListeDEmployesDemandes.Length - 1
                listeDeRapports(i) = New Rapport(obtenirListeDEmployesDemandes(i).id, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart)
            Next
            Dim changement As Boolean = True
            While changement
                changement = False
                For i As Integer = 0 To listeDeRapports.Length - 2
                    If (obtenirEmploye(listeDeRapports(i).idEmploye).idDepartement) > (obtenirEmploye(listeDeRapports(i + 1).idEmploye).idDepartement) Then
                        Dim rapportTempo As Rapport = listeDeRapports(i)
                        listeDeRapports(i) = listeDeRapports(i + 1)
                        listeDeRapports(i + 1) = rapportTempo
                        changement = True
                    End If
                Next
            End While
            poursuite = False
            ''Création du tableau de rapports
            'For i As Integer = 0 To listeDeRapports.Length - 1
            '    nombreDeLignesDansLaPage = 0
            '    listeDeRapports(i) = ""
            '    For Each employe In obtenirEmployesDuDepartement(obtenirTousDepartements(i).id)
            '        If employeEstDansTabEmploye(employe, obtenirListeDEmployesDemandes) Then
            '            If nombreDeLignesDansLaPage > NOMBRESDELIGNESPARFEUILLE - 10 Then
            '                For j As Integer = 0 To NOMBRESDELIGNESPARFEUILLE - nombreDeLignesDansLaPage - 1
            '                    listeDeRapports(i) += vbNewLine
            '                Next
            '                nombreDeLignesDansLaPage = 0
            '            End If
            '            listeDeRapports(i) += rapportSansHeader(employe.id, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart + TimeSpan.FromDays(1) - TimeSpan.FromSeconds(1))
            '            nombreDeLignesDansLaPage += (rapportSansHeader(employe.id, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart + TimeSpan.FromDays(1) - TimeSpan.FromSeconds(1)).Split(vbNewLine).Length - 1) Mod NOMBRESDELIGNESPARFEUILLE

            '        End If
            '    Next
            '    listeDeRapports(i).Trim(vbNewLine)
            '    listeDeRapports(i).Trim(vbCrLf)
            'Next
            ''Enlever les rapports vides
            'Dim k As Integer = 0
            'While k < listeDeRapports.Length
            '    If listeDeRapports(k).Length = 0 Then
            '        For j As Integer = k To listeDeRapports.Length - 2
            '            listeDeRapports(j) = listeDeRapports(j + 1)
            '            departementsValides(j) = departementsValides(j + 1)
            '        Next
            '        ReDim Preserve listeDeRapports(listeDeRapports.Length - 2)
            '        ReDim Preserve departementsValides(departementsValides.Length - 2)
            '    Else
            '        k += 1
            '    End If
            'End While
            If Not listeDeRapports.Length > 0 Then
                Throw (New Exception(ERREURAUCUNEMPLOYECORRESPONDANT))
            End If
            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try

    End Sub
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub
    'Imprimante
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        noDePage = 1
        ecrireVerification(e, poursuite, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart, listeDeRapports, noDePage)

        'setMargesVerification(e)

        'imprimerHeaderVerification(e, departementsValides(indice), MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart)

        'imprimerNoDePage(e, noDePage)

        'imprimerRapport(e, listeDeRapports, indice)

        'determinerSiPlusDePages(e, listeDeRapports, indice)
    End Sub

    'Fonctions construites

    Private Sub miseAJourButton()
        ButtonImprimer.Text = _
                "Imprimer les rapports : " + vbNewLine + _
                "Du : " + MonthCalendar1.SelectionStart.ToShortDateString + vbNewLine + _
                "Au : " + MonthCalendar2.SelectionStart.ToShortDateString
    End Sub
    Private Function obtenirListeDEmployesDemandes() As Employe()
        Select Case True
            Case ComboBoxType.SelectedItem = "(Tous)" And ComboBoxDepartement.SelectedItem = "(Tous)"
                Return obtenirTousEmployes()
            Case ComboBoxType.SelectedItem = "(Tous)" And ComboBoxDepartement.SelectedItem <> "(Tous)"
                Return obtenirEmployesDuDepartement(ComboBoxDepartement.SelectedItem.ToString.Substring(0, 2))
            Case ComboBoxType.SelectedItem <> "(Tous)" And ComboBoxDepartement.SelectedItem = "(Tous)"
                Return obtenirEmployesDuType(ComboBoxType.SelectedItem.ToString.Substring(0, 2))
            Case ComboBoxType.SelectedItem <> "(Tous)" And ComboBoxDepartement.SelectedItem <> "(Tous)"
                Return obtenirEmployesTypeEtDepartement(ComboBoxDepartement.SelectedItem.ToString.Substring(0, 2), ComboBoxType.SelectedItem.ToString.Substring(0, 2))
        End Select
    End Function

    'Interface
    Private Sub etablirDimensions()
        'Dimensions en x
        LabelTitre.Width = dimX
        GroupBoxFiltre.Width = dimX / 4
        GroupBoxDates.Width = dimX / 4
        ButtonImprimer.Width = dimX / 4
        ButtonQuitter.Width = dimX / 4

        ButtonImprimer.Height = ButtonImprimer.Width * 0.618033
        ButtonQuitter.Height = ButtonImprimer.Height

        'Positionnement des éléments en x
        Dim espaceReserveALaSeparation As Double = 2 * distanceXEntre2GrosGroupBox
        LabelTitre.Location = New Point(0, 0)
        GroupBoxFiltre.Location = New Point(((dimX - (GroupBoxFiltre.Width + GroupBoxDates.Width + ButtonImprimer.Width)) - espaceReserveALaSeparation) / 2, 0)
        GroupBoxDates.Location = obtenirNouvelleLocationX(GroupBoxFiltre.Location, GroupBoxFiltre.Width + espaceReserveALaSeparation / 2)
        ButtonImprimer.Location = obtenirNouvelleLocationX(GroupBoxDates.Location, GroupBoxDates.Width + espaceReserveALaSeparation / 2)
        ButtonQuitter.Location = ButtonImprimer.Location

        'Remplissage des colonnes
        etablirGroupBoxFiltre()
        etablirGroupBoxDates(GroupBoxDates, LabelDebut, MonthCalendar1, LabelFin, MonthCalendar2)

        'Dimensions en y
        Dim distanceEntreDernierElementEtLimite As Double = GroupBoxDepartement.Location.X
        LabelTitre.Height = hauteurLabelTitre
        GroupBoxFiltre.Height = obtenirHauteurGroupBox(GroupBoxType)
        GroupBoxDates.Height = obtenirHauteurGroupBox(MonthCalendar2)
        ButtonImprimer.Height = ButtonImprimer.Height * 0.618033
        ButtonQuitter.Size = ButtonImprimer.Size

        'Positionnement en y
        GroupBoxFiltre.Location = obtenirNouvelleLocationY(GroupBoxFiltre.Location, LabelTitre.Height)
        GroupBoxDates.Location = obtenirNouvelleLocationY(GroupBoxDates.Location, LabelTitre.Height)
        ButtonImprimer.Location = obtenirNouvelleLocationY(ButtonImprimer.Location, LabelTitre.Height + GroupBoxDepartement.Location.Y)
        ButtonQuitter.Location = obtenirNouvelleLocationY(ButtonImprimer.Location, ButtonImprimer.Height + espaceReserveALaSeparation / 2)
    End Sub
    Private Sub etablirGroupBoxFiltre()
        'Dimensions en x
        GroupBoxDepartement.Width = GroupBoxFiltre.Width - 2 * locationXDuPremierElementDUnGrosGroupBox
        GroupBoxType.Width = GroupBoxDepartement.Width

        'Positionnement en x
        GroupBoxDepartement.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, 0)
        GroupBoxType.Location = GroupBoxDepartement.Location

        'Remplissage des colonnes
        etablirGroupBoxDepartements()
        etablirGroupBoxType()

        'Dimensions en y
        GroupBoxDepartement.Height = obtenirHauteurGroupBox(ComboBoxDepartement)
        GroupBoxType.Height = obtenirHauteurGroupBox(ComboBoxType)

        'Positionnement en y
        GroupBoxDepartement.Location = obtenirNouvelleLocationY(GroupBoxDepartement.Location, locationYDuPremierElementDUnGrosGroupBox)
        GroupBoxType.Location = obtenirNouvelleLocationY(GroupBoxDepartement.Location, GroupBoxDepartement.Height + distanceYEntre2PetitsGroupBox)

    End Sub
    Private Sub etablirGroupBoxDepartements()
        'Dimension en x
        ComboBoxDepartement.Width = GroupBoxDepartement.Width - 2 * locationXDuPremierElementDUnPetitGroupBox
        'Positionnement
        ComboBoxDepartement.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)

    End Sub
    Private Sub etablirGroupBoxType()
        'Dimension en x
        ComboBoxType.Width = GroupBoxDepartement.Width - 2 * locationXDuPremierElementDUnPetitGroupBox
        'Positionnement
        ComboBoxType.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)

    End Sub

    Private Function employeEstDansTabEmploye(ByVal employe As Employe, ByVal tabEmploye() As Employe) As Boolean
        For Each employeDuTab In tabEmploye
            If employe.id = employeDuTab.id Then
                Return True
            End If
        Next
        Return False
    End Function




End Class