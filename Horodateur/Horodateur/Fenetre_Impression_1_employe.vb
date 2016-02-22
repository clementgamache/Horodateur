
Public Class Fenetre_Impression_1_employe
    'Private idSelectionne As String
    'Private contenuRapport As String
    Private globalIdType As String
    Private globalNomType As String
    Private listeDeRapports As Rapport()
    Private poursuite As Boolean
    Private indice As Integer
    Private noDePage As Integer
    'chargement
    Private Sub impression_1_employe_load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirdimensions()
        setcaracteristiquesimprimante(printdocument1)
        comboboxdepartement.dropdownstyle = comboboxstyle.dropdownlist
        comboboxtype.dropdownstyle = comboboxstyle.dropdownlist
        remplirComboBoxDepartements(ComboBoxDepartement, True)
        remplirComboBoxTypes(ComboBoxType, True)
        MonthCalendar1.SelectionStart = Date.Now - TimeSpan.FromDays(1)
        miseajourlistbox()
        listboxemployes.selectedindex = 0

    End Sub
    'Événements

    'Recherche d'employés
    'Tri
    Private Sub RadioButtonTriId_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriId.CheckedChanged
        miseAJourListBox()
        miseAJourButton()
    End Sub
    Private Sub RadioButtonTriNom_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriNom.CheckedChanged
        miseAJourListBox()
        miseAJourButton()
    End Sub
    Private Sub RadioButtonTriPrenom_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriPrenom.CheckedChanged
        miseAJourListBox()
        miseAJourButton()
    End Sub
    'Filtre


    Private Sub ComboBoxDepartements_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartement.SelectedIndexChanged
        miseAJourListBox()
        miseAJourButton()
    End Sub
    'Affichage
    Private Sub ComboBoxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxType.SelectedIndexChanged
        miseAJourListBox()
        miseAJourButton()
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmployes.SelectedIndexChanged
        miseAJourButton()
        'idSelectionne = ListBoxEmployes.SelectedItem.ToString.Substring(0, 3)
    End Sub

    'Calendrier
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
    Private Sub ButtonImprimante_Click(sender As Object, e As EventArgs) Handles ButtonImprimer.Click
        indice = 0
        noDePage = 1

        ReDim listeDeRapports(0)
        Try
            If ListBoxEmployes.Items.Count = 0 Then
                Throw (New Exception(ERREURAUCUNELEMENTSELECTIONNE))
            End If
            listeDeRapports(0) = New Rapport(ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart + TimeSpan.FromDays(1) - TimeSpan.FromSeconds(1))
            poursuite = False
            noDePage = 1
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
    'Impression
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fractionDeLaPageOccupee As Double = 15 / 16
        LARGEURMARGES = e.PageBounds.Width * (1 - (1 - fractionDeLaPageOccupee) / 2)

        Dim margeMobile As New System.Drawing.Rectangle(New Point(e.PageBounds.Width * (1 - fractionDeLaPageOccupee) / 2, e.PageBounds.Height * (1 - fractionDeLaPageOccupee) / 2), New Size(LARGEURMARGES, h1.Height))

        ecrireRapport(e, poursuite, MonthCalendar1.SelectionStart, MonthCalendar2.SelectionStart, listeDeRapports(0), margeMobile, False, noDePage)

    End Sub

    Private Sub miseAJourListBox()
        Try
            definirListbox(RadioButtonTriId.Checked, RadioButtonTriNom.Checked, RadioButtonTriPrenom.Checked, ComboBoxDepartement.SelectedItem.ToString, ComboBoxType.SelectedItem.ToString, ListBoxEmployes)

        Catch ex As Exception
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub
    Private Sub miseAJourButton()
        If ListBoxEmployes.Items.Count = 0 Then
            ButtonImprimer.Text = "Sélectionnez un employé"
            Exit Sub
        End If
        ButtonImprimer.Text = _
            "Imprimer le rapport de : " + vbNewLine + _
            ListBoxEmployes.SelectedItem.ToString.Substring(6, ListBoxEmployes.SelectedItem.ToString.Length - 6) + vbNewLine + _
            "Du : " + MonthCalendar1.SelectionStart.ToShortDateString + vbNewLine + _
            "Au : " + MonthCalendar2.SelectionStart.ToShortDateString
    End Sub





    'Interface

    Private Sub etablirDimensions()
        'Dimensions en x
        LabelTitre.Width = dimX
        GroupBoxRechercheEmploye.Width = dimX * 3 / 8
        GroupBoxDates.Width = dimX / 4
        ButtonImprimer.Width = dimX / 4
        ButtonQuitter.Width = dimX / 4


        'Positionnement des éléments en x
        Dim espaceReserveALaSeparation As Double = 2 * distanceXEntre2GrosGroupBox
        LabelTitre.Location = New Point(0, 0)
        GroupBoxRechercheEmploye.Location = New Point(((dimX - (GroupBoxRechercheEmploye.Width + GroupBoxDates.Width + ButtonImprimer.Width)) - espaceReserveALaSeparation) / 2, 0)
        GroupBoxDates.Location = obtenirNouvelleLocationX(GroupBoxRechercheEmploye.Location, GroupBoxRechercheEmploye.Width + distanceXEntre2GrosGroupBox)
        ButtonImprimer.Location = obtenirNouvelleLocationX(GroupBoxDates.Location, GroupBoxDates.Width + distanceXEntre2GrosGroupBox)
        ButtonQuitter.Location = ButtonImprimer.Location

        'Remplissage des colonnes
        etablirGroupBoxRechercheEmploye(LabelTitre, GroupBoxRechercheEmploye, GroupBoxTri, GroupBoxFiltre, ListBoxEmployes, RadioButtonTriId, RadioButtonTriNom, RadioButtonTriPrenom, LabelDepartement, ComboBoxDepartement, LabelType, ComboBoxType)
        etablirGroupBoxDates(GroupBoxDates, LabelDebut, MonthCalendar1, LabelFin, MonthCalendar2)

        'Dimensions en y
        LabelTitre.Height = hauteurLabelTitre
        GroupBoxRechercheEmploye.Height = obtenirHauteurGroupBox(ListBoxEmployes)
        GroupBoxDates.Height = obtenirHauteurGroupBox(MonthCalendar2)
        ButtonImprimer.Height = ButtonImprimer.Width * 0.618033
        ButtonQuitter.Size = ButtonImprimer.Size

        'Positionnement en y
        GroupBoxRechercheEmploye.Location = obtenirNouvelleLocationY(GroupBoxRechercheEmploye.Location, LabelTitre.Height)
        GroupBoxDates.Location = obtenirNouvelleLocationY(GroupBoxDates.Location, LabelTitre.Height)
        ButtonImprimer.Location = obtenirNouvelleLocationY(ButtonImprimer.Location, LabelTitre.Height + LabelDebut.Location.Y)
        ButtonQuitter.Location = obtenirNouvelleLocationY(ButtonImprimer.Location, ButtonImprimer.Height + distanceYEntre2GrosGroupBox)
    End Sub




End Class