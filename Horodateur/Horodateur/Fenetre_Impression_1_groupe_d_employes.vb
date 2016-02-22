Public Class Fenetre_Impression_1_groupe_d_employes
    Private listeDeRapports As Rapport()
    Private indice As Integer
    Private noDePage As Integer
    Private poursuite As Boolean
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
        noDePage=1
        Try
            ReDim listeDeRapports(obtenirListeDEmployesDemandes().Length - 1)
            For i As Integer = 0 To listeDeRapports.Length - 1
                listeDeRapports(i) = New Rapport(obtenirListeDEmployesDemandes()(i).id, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart + TimeSpan.FromDays(1) - TimeSpan.FromSeconds(1))
                'rapportIndividuel(obtenirListeDEmployesDemandes()(i).id, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart + TimeSpan.FromDays(1) - TimeSpan.FromSeconds(1))
            Next
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
        ecrireRapports(e, poursuite, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart, listeDeRapports, noDePage)
        'setMargesRapportDeTemps(e)

        'imprimerHeaderRapportDeTemps(e, obtenirType(obtenirListeDEmployesDemandes(indice).idType), MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart)

        'imprimerRapport(e, listeDeRapports, indice)
        'imprimerNoDePage(e, noDePage)
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
                Return trierParType(obtenirTousEmployes())
            Case ComboBoxType.SelectedItem = "(Tous)" And ComboBoxDepartement.SelectedItem <> "(Tous)"
                Return trierParType(obtenirEmployesDuDepartement(ComboBoxDepartement.SelectedItem.ToString.Substring(0, 2)))
            Case ComboBoxType.SelectedItem <> "(Tous)" And ComboBoxDepartement.SelectedItem = "(Tous)"
                Return trierParType(obtenirEmployesDuType(ComboBoxType.SelectedItem.ToString.Substring(0, 2)))
            Case ComboBoxType.SelectedItem <> "(Tous)" And ComboBoxDepartement.SelectedItem <> "(Tous)"
                Return trierParType(obtenirEmployesTypeEtDepartement(ComboBoxDepartement.SelectedItem.ToString.Substring(0, 2), ComboBoxType.SelectedItem.ToString.Substring(0, 2)))
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




End Class