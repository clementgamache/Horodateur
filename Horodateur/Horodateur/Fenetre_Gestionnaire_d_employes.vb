Public Class Fenetre_Gestionnaire_d_employes

    Private Sub Gestionnaire_d_employes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
        RadioButtonTriId.Checked = True
        RadioButtonModifierSupprimer.Checked = True
        ComboBoxDepartement.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxDepartementDonnee.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxType.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxTypeDonnee.DropDownStyle = ComboBoxStyle.DropDownList
        remplirComboBoxDepartements(ComboBoxDepartement, True)
        remplirComboBoxDepartements(ComboBoxDepartementDonnee, False)
        remplirComboBoxTypes(ComboBoxType, True)
        remplirComboBoxTypes(ComboBoxTypeDonnee, False)
        miseAJourListBox()
        ListBoxEmployes.SelectedIndex = 0
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDepartement.SelectedIndexChanged
        miseAJourListBox()
    End Sub
    Private Sub ComboBoxType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxType.SelectedIndexChanged
        miseAJourListBox()
    End Sub

    'Buttons radio de tri
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriId.CheckedChanged
        miseAJourListBox()
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriNom.CheckedChanged
        miseAJourListBox()
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTriPrenom.CheckedChanged
        miseAJourListBox()
    End Sub

    'Buttons radio de sélection d'action
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonModifierSupprimer.CheckedChanged
        TextBoxId.Enabled = False
        ButtonModifier.Enabled = True
        ButtonSupprimer.Enabled = True
        ButtonInserer.Enabled = False
        GroupBoxTri.Enabled = True
        GroupBoxFiltre.Enabled = True
        ComboBoxDepartement.Enabled = True
        ListBoxEmployes.Enabled = True
        miseAJourListBox()
    End Sub
    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonInserer.CheckedChanged
        TextBoxId.Enabled = True
        ButtonModifier.Enabled = False
        ButtonSupprimer.Enabled = False
        ButtonInserer.Enabled = True
        GroupBoxTri.Enabled = False
        GroupBoxFiltre.Enabled = False
        ComboBoxDepartement.Enabled = False
        ListBoxEmployes.Enabled = False
        reinitialiserEntrees()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmployes.SelectedIndexChanged
        Dim employeSelectionne As Employe = obtenirEmploye(ListBoxEmployes.SelectedItem.ToString.Substring(0, 3))
        TextBoxId.Text = employeSelectionne.id
        TextBoxNom.Text = employeSelectionne.nom
        TextBoxPrenom.Text = employeSelectionne.prenom
        ComboBoxDepartementDonnee.SelectedItem = employeSelectionne.idDepartement + " - " + obtenirDepartement(employeSelectionne.idDepartement).nom
        ComboBoxTypeDonnee.SelectedItem = employeSelectionne.idType + " - " + obtenirType(employeSelectionne.idType).nom
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Try
            If Not estDifferentDuContenuDeLaListe() Then
                Throw (New Exception(ERREURAUCUNEMODIFICATION))
            End If
            If ListBoxEmployes.Items.Count = 0 Then
                Throw (New Exception(ERREURAUCUNELEMENTSELECTIONNE))
            End If
            If valeursProposeesCorrectes() Then
                modifierEmploye(TextBoxId.Text, TextBoxNom.Text, TextBoxPrenom.Text, ComboBoxDepartementDonnee.SelectedItem.ToString.Substring(0, 2), ComboBoxTypeDonnee.SelectedItem.ToString.Substring(0, 2))
                MsgBox(CONFIRMATIONMODIFICATION, MsgBoxStyle.Information, CONFIRMATIONMODIFICATION)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
        miseAJourListBox()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
        Try
            If ListBoxEmployes.Items.Count = 0 Then
                Throw (New Exception(ERREURAUCUNELEMENTSELECTIONNE))
                Exit Sub
            End If
            If MsgBox(DEMANDEDECONFIRMATION, 52, DEMANDEDECONFIRMATIONTITRE) = 6 Then
                supprimerEmploye(TextBoxId.Text())
                MsgBox(CONFIRMATIONSUPPRESSION, MsgBoxStyle.Information, CONFIRMATIONSUPPRESSION)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try

        miseAJourListBox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonInserer.Click
        If valeursProposeesCorrectes() Then
            Try
                If employeEstDansBd(TextBoxId.Text) Then
                    Throw (New Exception(ERREURIDDEJAPRIS))
                End If
                Dim nouvelEmploye As New Employe(TextBoxId.Text, TextBoxNom.Text, TextBoxPrenom.Text, ComboBoxDepartementDonnee.SelectedItem.ToString.Substring(0, 2), ComboBoxTypeDonnee.SelectedItem.ToString.Substring(0, 2))
                nouvelEmploye.insererDansBd()
                MsgBox(CONFIRMATIONINSERTION, MsgBoxStyle.Information, CONFIRMATIONINSERTION)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
                If CONNEXION.State = ConnectionState.Open Then
                    CONNEXION.Close()
                End If
            End Try
        End If
        miseAJourListBox()
        reinitialiserEntrees()
    End Sub
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub reinitialiserEntrees()
        TextBoxId.Clear()
        TextBoxNom.Clear()
        TextBoxPrenom.Clear()
        If ComboBoxDepartementDonnee.Items.Count > 0 Then
            ComboBoxDepartementDonnee.SelectedItem = ComboBoxDepartementDonnee.SelectionStart
        End If
        If ComboBoxTypeDonnee.Items.Count > 0 Then
            ComboBoxTypeDonnee.SelectedItem = ComboBoxTypeDonnee.SelectionStart
        End If
    End Sub

    Private Function valeursProposeesCorrectes() As String
        Dim messageDErreur As String = ""
        Dim resultat As Boolean = True
        If Not TextBoxId.Text Like "###" Then
            resultat = False
            messageDErreur += ERREURID3CHIFFRES + vbNewLine
        End If
        If TextBoxNom.Text.Length < 1 Or TextBoxNom.Text.Length > 30 Then
            resultat = False
            messageDErreur += ERREURNOMNONCONFORME + vbNewLine
        End If
        If TextBoxPrenom.Text.Length < 1 Or TextBoxPrenom.Text.Length > 30 Then
            resultat = False
            messageDErreur += ERREURPRENOMNONCONFORME + vbNewLine
        End If
        If resultat = False Then
            Throw (New Exception(messageDErreur))
            Return False
        Else
            Return True
        End If
    End Function
    Private Function estDifferentDuContenuDeLaListe() As Boolean
        Dim employeSelectionne As Employe = obtenirEmploye(ListBoxEmployes.SelectedItem.ToString.Substring(0, 3))
        If employeSelectionne.id = TextBoxId.Text And _
            employeSelectionne.nom = TextBoxNom.Text And _
            employeSelectionne.prenom = TextBoxPrenom.Text And _
            employeSelectionne.idDepartement = ComboBoxDepartementDonnee.SelectedItem.ToString.Substring(0, 2) And _
            employeSelectionne.idType = ComboBoxTypeDonnee.SelectedItem.ToString.Substring(0, 2) Then
            'MsgBox(ERREURAUCUNEMODIFICATION, MsgBoxStyle.Exclamation, ERREURAUCUNEMODIFICATION)
            Return False
        End If
        Return True
    End Function

    Private Sub miseAJourListBox()
        Try
            definirListbox(RadioButtonTriId.Checked, RadioButtonTriNom.Checked, RadioButtonTriPrenom.Checked, ComboBoxDepartement.SelectedItem, ComboBoxType.SelectedItem, ListBoxEmployes)

        Catch ex As Exception
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub

    Private Sub etablirDimensions()
        'Dimensions en x
        LabelTitre.Width = dimX
        GroupBoxRechercheEmploye.Width = dimX * 3 / 8
        GroupBoxGestionEmploye.Width = dimX / 4
        ButtonModifier.Width = dimX / 8
        ButtonSupprimer.Width = ButtonModifier.Width
        ButtonInserer.Width = ButtonModifier.Width
        ButtonQuitter.Width = ButtonModifier.Width



        'Positionnement des éléments en x
        Dim espaceReserveALaSeparation As Double = 2 * distanceXEntre2GrosGroupBox
        LabelTitre.Location = New Point(0, 0)
        GroupBoxRechercheEmploye.Location = New Point(((dimX - (GroupBoxRechercheEmploye.Width + GroupBoxGestionEmploye.Width + ButtonModifier.Width)) - espaceReserveALaSeparation) / 2, 0)
        GroupBoxGestionEmploye.Location = obtenirNouvelleLocationX(GroupBoxRechercheEmploye.Location, GroupBoxRechercheEmploye.Width + distanceXEntre2GrosGroupBox)
        ButtonModifier.Location = obtenirNouvelleLocationX(GroupBoxGestionEmploye.Location, GroupBoxGestionEmploye.Width + distanceXEntre2GrosGroupBox)
        ButtonSupprimer.Location = ButtonModifier.Location
        ButtonInserer.Location = ButtonModifier.Location
        ButtonQuitter.Location = ButtonModifier.Location

        'Remplissage des colonnes
        etablirGroupBoxRechercheEmploye(LabelTitre, GroupBoxRechercheEmploye, GroupBoxTri, GroupBoxFiltre, ListBoxEmployes, RadioButtonTriId, RadioButtonTriNom, RadioButtonTriPrenom, LabelDepartement, ComboBoxDepartement, LabelType, ComboBoxType)
        etablirGroupBoxGestionEmploye()

        'Dimensions en y
        LabelTitre.Height = hauteurLabelTitre
        GroupBoxRechercheEmploye.Height = obtenirHauteurGroupBox(ListBoxEmployes)
        GroupBoxGestionEmploye.Height = obtenirHauteurGroupBox(GroupBoxDonnees)
        ButtonModifier.Height = ButtonModifier.Width * 0.618033
        ButtonSupprimer.Size = ButtonModifier.Size
        ButtonInserer.Size = ButtonModifier.Size
        ButtonQuitter.Size = ButtonModifier.Size

        'Positionnement en y
        GroupBoxRechercheEmploye.Location = obtenirNouvelleLocationY(GroupBoxRechercheEmploye.Location, LabelTitre.Height)
        GroupBoxGestionEmploye.Location = obtenirNouvelleLocationY(GroupBoxGestionEmploye.Location, LabelTitre.Height)
        ButtonModifier.Location = obtenirNouvelleLocationY(ButtonModifier.Location, LabelTitre.Height)
        ButtonSupprimer.Location = obtenirNouvelleLocationY(ButtonModifier.Location, ButtonModifier.Height + distanceYEntre2GrosGroupBox)
        ButtonInserer.Location = obtenirNouvelleLocationY(ButtonSupprimer.Location, ButtonSupprimer.Height + distanceYEntre2GrosGroupBox)
        ButtonQuitter.Location = obtenirNouvelleLocationY(ButtonInserer.Location, ButtonInserer.Height + distanceYEntre2GrosGroupBox)
    End Sub



    Private Sub etablirGroupBoxGestionEmploye()
        'Dimensions en x
        GroupBoxSelectionAction.Width = GroupBoxGestionEmploye.Width - 2 * locationXDuPremierElementDUnGrosGroupBox
        GroupBoxDonnees.Width = GroupBoxSelectionAction.Width

        'Position en x
        GroupBoxSelectionAction.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, 0)
        GroupBoxDonnees.Location = GroupBoxSelectionAction.Location

        etablirGroupBoxSelectionAction()
        etablirGroupBoxDonnees()

        'Dimensions en y
        GroupBoxSelectionAction.Height = obtenirHauteurGroupBox(RadioButtonInserer)
        GroupBoxDonnees.Height = obtenirHauteurGroupBox(ComboBoxTypeDonnee)

        'Position en y
        GroupBoxSelectionAction.Location = obtenirNouvelleLocationY(GroupBoxSelectionAction.Location, locationYDuPremierElementDUnGrosGroupBox)
        GroupBoxDonnees.Location = obtenirNouvelleLocationY(GroupBoxSelectionAction.Location, GroupBoxSelectionAction.Height + distanceYEntre2PetitsGroupBox)
    End Sub
    Private Sub etablirGroupBoxSelectionAction()
        'Position en x et y
        RadioButtonModifierSupprimer.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        RadioButtonInserer.Location = obtenirNouvelleLocationY(RadioButtonModifierSupprimer.Location, RadioButtonModifierSupprimer.Height)
    End Sub

    Private Sub etablirGroupBoxDonnees()
        'Dimensions en x
        TextBoxNom.Width = GroupBoxDonnees.Width - 2 * locationXDuPremierElementDUnPetitGroupBox
        TextBoxPrenom.Width = TextBoxNom.Width
        ComboBoxDepartementDonnee.Width = TextBoxNom.Width
        ComboBoxTypeDonnee.Width = ComboBoxDepartementDonnee.Width
        'Position en x et y
        LabelId.Location = RadioButtonModifierSupprimer.Location
        TextBoxId.Location = obtenirNouvelleLocationY(LabelId.Location, LabelId.Height)
        LabelNom.Location = obtenirNouvelleLocationY(TextBoxId.Location, TextBoxId.Height)
        TextBoxNom.Location = obtenirNouvelleLocationY(LabelNom.Location, LabelNom.Height)
        LabelPrenom.Location = obtenirNouvelleLocationY(TextBoxNom.Location, TextBoxNom.Height)
        TextBoxPrenom.Location = obtenirNouvelleLocationY(LabelPrenom.Location, LabelPrenom.Height)
        LabelDepartementDonnee.Location = obtenirNouvelleLocationY(TextBoxPrenom.Location, TextBoxPrenom.Height)
        ComboBoxDepartementDonnee.Location = obtenirNouvelleLocationY(LabelDepartementDonnee.Location, LabelDepartementDonnee.Height)
        LabelTypeDonnee.Location = obtenirNouvelleLocationY(ComboBoxDepartementDonnee.Location, ComboBoxDepartementDonnee.Height)
        ComboBoxTypeDonnee.Location = obtenirNouvelleLocationY(LabelTypeDonnee.Location, LabelTypeDonnee.Height)
    End Sub
End Class