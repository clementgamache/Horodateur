Public Class Fenetre_Gestion_des_entreessorties
    Private indiceSelection As Integer
    Private transactionSelectionnee As Transaction
    Private tabTransactions As Transaction()
    'Private tabEntreesSortiesEmployeSelectionne As EntreeSortie()
    Private Sub Gestion_des_entreessorties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
        ComboBoxDepartement.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList
        remplirComboBoxDepartements(ComboBoxDepartement, True)
        remplirComboBoxTypes(ComboBoxType, True)
        RadioButtonTriId.Checked = True
        miseAJourListBox1()
        miseAJourListBox2()
    End Sub

    Private Sub miseAJourListBox1()
        Try


            definirListbox(RadioButtonTriId.Checked, _
                           RadioButtonTriNom.Checked, _
                           RadioButtonTriPrenom.Checked, _
                           ComboBoxDepartement.SelectedItem.ToString, _
                           ComboBoxType.SelectedItem.ToString, _
                           ListBoxEmployes)
            If ListBoxEmployes.Items.Count = 0 Then
                ListBoxEntreeSortie.Items.Clear()
                viderToutesLesEntrees()
                Exit Sub
            End If

        Catch ex As Exception
            If Not ex.HResult = -2147467261 Then
                MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            End If
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriId.CheckedChanged
        miseAJourListBox1()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriNom.CheckedChanged
        miseAJourListBox1()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriPrenom.CheckedChanged
        miseAJourListBox1()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartement.SelectedIndexChanged
        miseAJourListBox1()
    End Sub
    Private Sub ComboBoxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxType.SelectedIndexChanged
        miseAJourListBox1()
    End Sub
    Private Sub ButtonInserer_Click(sender As Object, e As EventArgs) Handles ButtonInserer.Click
        Try
            
            Dim date1 As Date = CDate(TextBoxEntreeDate.Text + " " + TextBoxEntreeHeure.Text + ":" + TextBoxEntreeMinute.Text + ":" + TextBoxEntreeSeconde.Text)
            Dim date2 As Date = CDate(TextBoxSortieDate.Text + " " + TextBoxSortieHeure.Text + ":" + TextBoxSortieMinute.Text + ":" + TextBoxSortieSeconde.Text)
            
            'Fin avant début
            If Not DateTime.Compare(date1, date2) < 0 Then
                Throw (New Exception(ERREURSORTIEAVANTENTREE))
            End If

            'Date entre les deux proposées
            If chercherEntreeSortieEntreDansTransaction(New Transaction(New EntreeSortie(date1, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, True), New EntreeSortie(date2, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, False))) Then

                Throw (New Exception(ERREURISOLEMENTDEDATE))
            End If
            If estDansTransactionExistante(New Transaction(New EntreeSortie(date1, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, True), New EntreeSortie(date2, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, False))) Then
                Throw (New Exception(ERREURISOLEMENTDEDATE))
            End If
            'Date avant maintenant
            If Not DateTime.Compare(date2, Date.Now) < 0 Then
                Throw (New Exception(ERREURDATEAPRESMAINTENANT))
            End If
            incrementerCompte()
            Dim entree As EntreeSortie = New EntreeSortie(date1, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), obtenirCompte, True)
            Dim sortie As EntreeSortie = New EntreeSortie(date2, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, False)
            Dim insertion As Transaction = New Transaction(entree, sortie)
            insertion.inserer()
            'entree.insererDansBd()
            'sortie.insererDansBd()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
        miseAJourListBox2()
    End Sub
    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click


        Try
            If Not ListBoxEntreeSortie.Items.Count > 0 Then
                Throw (New Exception(ERREURAUCUNELEMENTSELECTIONNE))
            End If
            Dim date1 As Date = CDate(TextBoxEntreeDate.Text + " " + TextBoxEntreeHeure.Text + ":" + TextBoxEntreeMinute.Text + ":" + TextBoxEntreeSeconde.Text)
            Dim date2 As Date = CDate(TextBoxSortieDate.Text + " " + TextBoxSortieHeure.Text + ":" + TextBoxSortieMinute.Text + ":" + TextBoxSortieSeconde.Text)

            'Fin avant début
            If Not DateTime.Compare(date1, date2) < 0 Then
                Throw (New Exception(ERREURSORTIEAVANTENTREE))
            End If

            'Date avant maintenant
            If Not DateTime.Compare(date2, Date.Now) < 0 Then
                Throw (New Exception(ERREURDATEAPRESMAINTENANT))
            End If
            If ListBoxEntreeSortie.Items.Count = 0 Then
                Throw (New Exception(ERREURAUCUNELEMENTSELECTIONNE))
            End If
            Dim indiceinverse As Integer = tabTransactions.Length - 1 - ListBoxEntreeSortie.SelectedIndex

            'Date entre les deux proposées
            'If chercherEntreeSortieEntreDansTransaction(New Transaction(New EntreeSortie(date1, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, True), New EntreeSortie(date2, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, False))) Then
            '    Throw New Exception(ERREURISOLEMENTDEDATE)
            'End If
            'If estDansTransactionExistante(New Transaction(New EntreeSortie(date1, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, True), New EntreeSortie(date2, ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), 0, False))) Then
            '    Throw (New Exception(ERREURISOLEMENTDEDATE))
            'End If
            tabTransactions(indiceinverse).modifier(date1, date2)
            'modifierEntreeSortieDeBd(tabEntreesSortiesEmployeSelectionne(indiceSelection + 1).temps, date1)
            'modifierEntreeSortieDeBd(tabEntreesSortiesEmployeSelectionne(indiceSelection + 2).temps, date2)
            MsgBox(CONFIRMATIONMODIFICATION, MsgBoxStyle.Information, CONFIRMATIONMODIFICATION)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try

        miseAJourListBox2()
    End Sub


    Private Sub ButtonSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
        Try
            If Not ListBoxEntreeSortie.Items.Count > 0 Then
                Throw (New Exception(ERREURAUCUNELEMENTSELECTIONNE))
            End If
            Dim indiceinverse As Integer = tabTransactions.Length - 1 - ListBoxEntreeSortie.SelectedIndex
            tabTransactions(indiceinverse).supprimer()
            'supprimerEntreeSortieDeBd(tabEntreesSortiesEmployeSelectionne(indiceSelection + 1).temps)
            'supprimerEntreeSortieDeBd(tabEntreesSortiesEmployeSelectionne(indiceSelection).temps)
            miseAJourListBox2()

            MsgBox(CONFIRMATIONSUPPRESSION, MsgBoxStyle.Information, CONFIRMATIONSUPPRESSION)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmployes.SelectedIndexChanged
        miseAJourListBox2()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEntreeSortie.SelectedIndexChanged
        If ListBoxEmployes.Items.Count = 0 Then
            ListBoxEntreeSortie.Items.Clear()
            viderToutesLesEntrees()
            Exit Sub
        End If
        'setIndiceSelection()
        Dim indiceinverse As Integer = tabTransactions.Length - 1 - ListBoxEntreeSortie.SelectedIndex
        TextBoxEntreeDate.Text = tabTransactions(indiceinverse).entree.temps.ToShortDateString
        TextBoxEntreeHeure.Text = tabTransactions(indiceinverse).entree.temps.ToLongTimeString.Substring(0, 2)
        TextBoxEntreeMinute.Text = tabTransactions(indiceinverse).entree.temps.ToLongTimeString.Substring(3, 2)
        TextBoxEntreeSeconde.Text = tabTransactions(indiceinverse).entree.temps.ToLongTimeString.Substring(6, 2)
        TextBoxSortieDate.Text = tabTransactions(indiceinverse).sortie.temps.ToShortDateString
        TextBoxSortieHeure.Text = tabTransactions(indiceinverse).sortie.temps.ToLongTimeString.Substring(0, 2)
        TextBoxSortieMinute.Text = tabTransactions(indiceinverse).sortie.temps.ToLongTimeString.Substring(3, 2)
        TextBoxSortieSeconde.Text = tabTransactions(indiceinverse).sortie.temps.ToLongTimeString.Substring(6, 2)
    End Sub
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub miseAJourListBox2()
        Try

            viderToutesLesEntrees()
            setTableauEntreesSortiesEmployeSelectionne()
            ListBoxEntreeSortie.Items.Clear()
            For i As Integer = tabTransactions.Length - 1 To 0 Step -1
                ListBoxEntreeSortie.Items.Add(tabTransactions(i).affichage)
            Next
            'For i As Integer = tabEntreesSortiesEmployeSelectionne.Length - 1 To 0 Step -2
            '    ListBoxEntreeSortie.Items.Add(CStr(tabEntreesSortiesEmployeSelectionne(i - 1).code) + " - " + CStr(tabEntreesSortiesEmployeSelectionne(i - 1).temps) + " - " + CStr(tabEntreesSortiesEmployeSelectionne(i).temps))
            'Next
            If ListBoxEntreeSortie.Items.Count > 0 Then
                ListBoxEntreeSortie.SelectedIndex = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub
    'tabEntreesSortiesEmployeSelectionne est le tableau des entrées et des sorties en ordre décroissant. 0 est donc une sortie
    Private Sub setTableauEntreesSortiesEmployeSelectionne()
        Dim tabEntreesSortiesEmployeSelectionne(rejeterEntreesInutiles(obtenirEntreesSortiesEmploye(ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), CDate("2014-05-13 01:15:21"), Date.Now)).Length - 1) As EntreeSortie
        ReDim tabTransactions(tabEntreesSortiesEmployeSelectionne.Length / 2 - 1)
        Array.Copy(rejeterEntreesInutiles(obtenirEntreesSortiesEmploye(ListBoxEmployes.SelectedItem.ToString.Substring(0, 3), CDate("2014-05-13 01:15:21"), Date.Now)), tabEntreesSortiesEmployeSelectionne, tabEntreesSortiesEmployeSelectionne.Length)
        For i As Integer = 0 To tabTransactions.Length - 1
            tabTransactions(i) = New Transaction(tabEntreesSortiesEmployeSelectionne(2 * i), tabEntreesSortiesEmployeSelectionne(2 * i + 1))
        Next
    End Sub

    'IndiceSelection est l'indice 
    'Private Sub setIndiceSelection()
    '    For i As Integer = 0 To tabEntreesSortiesEmployeSelectionne.Length / 2 - 1
    '        If tabEntreesSortiesEmployeSelectionne(2 * i).code.ToString = ListBoxEntreeSortie.Text.Substring(0, ListBoxEntreeSortie.Text.IndexOf(" ")) Then
    '            indiceSelection = 2 * i
    '            Exit Sub
    '        End If
    '    Next
    'End Sub


    Private Sub viderToutesLesEntrees()
        TextBoxEntreeDate.Clear()
        TextBoxEntreeHeure.Clear()
        TextBoxEntreeMinute.Clear()
        TextBoxEntreeSeconde.Clear()
        TextBoxSortieSeconde.Clear()
        TextBoxSortieMinute.Clear()
        TextBoxSortieHeure.Clear()
        TextBoxSortieDate.Clear()
    End Sub

    Private Sub etablirDimensions()
        'Dimensions en x
        LabelTitre.Width = dimX
        GroupBoxRechercheEmploye.Width = dimX * 3 / 8
        GroupBoxGestion.Width = GroupBoxRechercheEmploye.Width
        ButtonInserer.Width = dimX / 8
        ButtonModifier.Width = ButtonInserer.Width
        ButtonSupprimer.Width = ButtonModifier.Width
        ButtonQuitter.Width = ButtonModifier.Width

        'Location en x
        LabelTitre.Location = New Point(0, 0)
        GroupBoxRechercheEmploye.Location = New Point( _
            (dimX - (GroupBoxRechercheEmploye.Width + GroupBoxGestion.Width + ButtonModifier.Width + 2 * distanceXEntre2GrosGroupBox)) / 2, 0)
        GroupBoxGestion.Location = obtenirNouvelleLocationX(GroupBoxRechercheEmploye.Location, GroupBoxRechercheEmploye.Width + distanceXEntre2GrosGroupBox)
        ButtonInserer.Location = obtenirNouvelleLocationX(GroupBoxGestion.Location, GroupBoxGestion.Width + distanceXEntre2GrosGroupBox)

        etablirGroupBoxRechercheEmploye(LabelTitre, GroupBoxRechercheEmploye, GroupBoxTri, GroupBoxFiltre, ListBoxEmployes, RadioButtonTriId, RadioButtonTriNom, RadioButtonTriPrenom, LabelDepartement, ComboBoxDepartement, LabelType, ComboBoxType)


        'Dimensions en y
        LabelTitre.Height = hauteurLabelTitre
        GroupBoxRechercheEmploye.Height = obtenirHauteurGroupBox(ListBoxEmployes)

        'Exception
        GroupBoxGestion.Height = GroupBoxRechercheEmploye.Height
        etablirGroupBoxGestion()
        ButtonInserer.Height = ButtonInserer.Width * 0.618033
        ButtonModifier.Height = ButtonInserer.Height
        ButtonSupprimer.Height = ButtonModifier.Height
        ButtonQuitter.Height = ButtonModifier.Height

        'Location en y
        GroupBoxRechercheEmploye.Location = obtenirNouvelleLocationY(GroupBoxRechercheEmploye.Location, LabelTitre.Height)
        GroupBoxGestion.Location = obtenirNouvelleLocationY(GroupBoxGestion.Location, LabelTitre.Height)
        ButtonInserer.Location = obtenirNouvelleLocationY(ButtonInserer.Location, LabelTitre.Height)
        ButtonModifier.Location = obtenirNouvelleLocationY(ButtonInserer.Location, ButtonModifier.Height + distanceXEntre2GrosGroupBox)
        ButtonSupprimer.Location = obtenirNouvelleLocationY(ButtonModifier.Location, ButtonModifier.Height + distanceXEntre2GrosGroupBox)
        ButtonQuitter.Location = obtenirNouvelleLocationY(ButtonSupprimer.Location, ButtonSupprimer.Height + distanceYEntre2GrosGroupBox)
    End Sub
    Private Sub etablirGroupBoxGestion()
        'Dimensions en x
        ListBoxEntreeSortie.Width = GroupBoxGestion.Width - 2 * locationXDuPremierElementDUnGrosGroupBox
        GroupBoxEntree.Width = (ListBoxEntreeSortie.Width - distanceXEntre2PetitsGroupBox) / 2
        GroupBoxSortie.Width = GroupBoxEntree.Width

        'Location en x
        ListBoxEntreeSortie.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, 0)
        GroupBoxEntree.Location = ListBoxEntreeSortie.Location
        GroupBoxSortie.Location = ListBoxEntreeSortie.Location

        etablirGroupBoxEntree()
        etablirGroupBoxSortie()

        'Dimensions en y
        GroupBoxEntree.Height = obtenirHauteurGroupBox(TextBoxEntreeHeure)
        GroupBoxSortie.Height = GroupBoxEntree.Height
        ListBoxEntreeSortie.Height = GroupBoxGestion.Height - (locationYDuPremierElementDUnGrosGroupBox + GroupBoxEntree.Height + distanceYEntre2PetitsGroupBox)

        'Location en y
        ListBoxEntreeSortie.Location = obtenirNouvelleLocationY(ListBoxEntreeSortie.Location, locationYDuPremierElementDUnGrosGroupBox)
        GroupBoxEntree.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, GroupBoxGestion.Height - GroupBoxEntree.Height - distanceXEntre2PetitsGroupBox)
        GroupBoxSortie.Location = obtenirNouvelleLocationX(GroupBoxEntree.Location, GroupBoxEntree.Width + distanceXEntre2PetitsGroupBox)
    End Sub
    Private Sub etablirGroupBoxEntree()
        LabelEntreeDate.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        TextBoxEntreeDate.Location = obtenirNouvelleLocationY(LabelEntreeDate.Location, LabelEntreeDate.Height)
        LabelEntreeHeure.Location = obtenirNouvelleLocationY(TextBoxEntreeDate.Location, TextBoxEntreeDate.Height)
        TextBoxEntreeHeure.Location = obtenirNouvelleLocationY(LabelEntreeHeure.Location, LabelEntreeHeure.Height)
        LabelEntreeHeureMinute.Location = obtenirNouvelleLocationX(TextBoxEntreeHeure.Location, TextBoxEntreeHeure.Width)
        TextBoxEntreeMinute.Location = obtenirNouvelleLocationX(LabelEntreeHeureMinute.Location, LabelEntreeHeureMinute.Width)
        LabelEntreeMinuteSeconde.Location = obtenirNouvelleLocationX(TextBoxEntreeMinute.Location, TextBoxEntreeMinute.Width)
        TextBoxEntreeSeconde.Location = obtenirNouvelleLocationX(LabelEntreeMinuteSeconde.Location, LabelEntreeMinuteSeconde.Width)

    End Sub
    Private Sub etablirGroupBoxSortie()
        LabelSortieDate.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        TextBoxSortieDate.Location = obtenirNouvelleLocationY(LabelSortieDate.Location, LabelSortieDate.Height)
        LabelSortieHeure.Location = obtenirNouvelleLocationY(TextBoxSortieDate.Location, TextBoxSortieDate.Height)
        TextBoxSortieHeure.Location = obtenirNouvelleLocationY(LabelSortieHeure.Location, LabelSortieHeure.Height)
        LabelSortieHeureMinute.Location = obtenirNouvelleLocationX(TextBoxSortieHeure.Location, TextBoxSortieHeure.Width)
        TextBoxSortieMinute.Location = obtenirNouvelleLocationX(LabelSortieHeureMinute.Location, LabelSortieHeureMinute.Width)
        LabelSortieMinuteSeconde.Location = obtenirNouvelleLocationX(TextBoxSortieMinute.Location, TextBoxSortieMinute.Width)
        TextBoxSortieSeconde.Location = obtenirNouvelleLocationX(LabelSortieMinuteSeconde.Location, LabelSortieMinuteSeconde.Width)

    End Sub


End Class