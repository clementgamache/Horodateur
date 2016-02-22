Public Class Fenetre_Gestionnaire_de_Departements

    Private Sub Gestionnaire_de_Departements_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
        RadioButtonModifierSupprimer.Checked = True
        miseAJourListBox()

    End Sub
    Sub miseAJourListBox()
        ListBoxDepartements.Items.Clear()
        For Each departement In obtenirTousDepartements()
            ListBoxDepartements.Items.Add(departement.id + " - " + departement.nom)
        Next
        If ListBoxDepartements.Items.Count <> 0 Then
            ListBoxDepartements.SelectedIndex = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonModifierSupprimer.CheckedChanged
        AcceptButton = ButtonModifier
        ButtonModifier.Enabled = True
        ButtonSupprimer.Enabled = True
        ButtonInserer.Enabled = False
        ListBoxDepartements.Enabled = True
        miseAJourListBox()
        TextBoxDepartementId.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonInserer.CheckedChanged
        AcceptButton = ButtonInserer
        ButtonModifier.Enabled = False
        ButtonSupprimer.Enabled = False
        ButtonInserer.Enabled = True
        ListBoxDepartements.Enabled = False
        TextBoxDepartementId.Enabled = True
        TextBoxDepartementId.Clear()
        TextBoxDepartement.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDepartements.SelectedIndexChanged
        TextBoxDepartementId.Text = ListBoxDepartements.SelectedItem.ToString.Substring(0, 2)
        TextBoxDepartement.Text = obtenirDepartement(ListBoxDepartements.SelectedItem.ToString.Substring(0, 2)).nom
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Try
            If modEstCorrecte() Then
                renommerDepartement(ListBoxDepartements.SelectedItem.ToString.Substring(0, 2), TextBoxDepartement.Text)
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
    Private Function modEstCorrecte()
        If TextBoxDepartement.Text.Trim = obtenirDepartement(TextBoxDepartementId.Text).nom Then
            Throw (New Exception(ERREURAUCUNEMODIFICATION))
        End If
        If Not (TextBoxDepartement.Text.Length > 0 And TextBoxDepartement.Text.Length < 30) Then
            Throw (New Exception(ERREURDEPARTEMENTDEMAUVAISELONGUEUR))
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
        Try
            If departementUtilise(ListBoxDepartements.SelectedItem.ToString.Substring(0, 2)) Then
                Throw (New Exception(ERREURDEPARTEMENTENCOREUTILISE))
            End If
            If MsgBox(DEMANDEDECONFIRMATION, 52, DEMANDEDECONFIRMATIONTITRE) = 6 Then
                supprimerDepartement(ListBoxDepartements.SelectedItem.ToString.Substring(0, 2))
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
        Try
            Dim nouveauDepartement As New Departement(TextBoxDepartementId.Text, TextBoxDepartement.Text)
            If insertionCorrecte(nouveauDepartement) Then
                nouveauDepartement.insererDansBd()
                MsgBox(CONFIRMATIONINSERTION, MsgBoxStyle.Information, CONFIRMATIONINSERTION)
                miseAJourListBox()
                TextBoxDepartementId.Clear()
                TextBoxDepartement.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub
    Private Function insertionCorrecte(ByVal departement As Departement) As Boolean
        If Not departement.id Like "##" Then
            Throw (New Exception(ERREURID2CHIFFRES))
        ElseIf departementEstDansBd(departement.id) Then
            Throw (New Exception(ERREURIDDEJAPRIS))
        ElseIf Not (departement.nom.Length > 0 And departement.nom.Length <= 30) Then
            Throw (New Exception(ERREURNOMNONCONFORME))
        End If
        Return True
    End Function
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub etablirDimensions()
        'Dimensions en x
        LabelTitre.Width = dimX
        GroupBoxListeDepartements.Width = dimX / 4
        GroupBoxGestionDepartements.Width = dimX * 5 / 16
        ButtonModifier.Width = dimX / 8
        ButtonSupprimer.Width = ButtonModifier.Width
        ButtonInserer.Width = ButtonModifier.Width
        ButtonQuitter.Width = ButtonModifier.Width

        'Position en x
        LabelTitre.Location = New Point(0, 0)
        GroupBoxListeDepartements.Location = New Point((dimX - (GroupBoxListeDepartements.Width + GroupBoxGestionDepartements.Width + ButtonModifier.Width + 2 * distanceXEntre2GrosGroupBox)) / 2, 0)
        GroupBoxGestionDepartements.Location = obtenirNouvelleLocationX(GroupBoxListeDepartements.Location, GroupBoxListeDepartements.Width + distanceXEntre2GrosGroupBox)
        ButtonModifier.Location = obtenirNouvelleLocationX(GroupBoxGestionDepartements.Location, GroupBoxGestionDepartements.Width + distanceXEntre2GrosGroupBox)
        ButtonSupprimer.Location = ButtonModifier.Location
        ButtonInserer.Location = ButtonModifier.Location
        ButtonQuitter.Location = ButtonModifier.Location

        etablirGroupBoxListeDepartements()
        etablirGroupBoxGestionDepartements()

        'Dimensions en y
        LabelTitre.Height = hauteurLabelTitre
        GroupBoxListeDepartements.Height = obtenirHauteurGroupBox(ListBoxDepartements)
        GroupBoxGestionDepartements.Height = obtenirHauteurGroupBox(GroupBoxDonnees)
        ButtonModifier.Height = ButtonModifier.Width * 0.618033
        ButtonSupprimer.Height = ButtonModifier.Height
        ButtonInserer.Height = ButtonModifier.Height
        ButtonQuitter.Height = ButtonModifier.Height

        'Position en y
        GroupBoxListeDepartements.Location = obtenirNouvelleLocationY(GroupBoxListeDepartements.Location, LabelTitre.Height)
        GroupBoxGestionDepartements.Location = obtenirNouvelleLocationY(GroupBoxGestionDepartements.Location, LabelTitre.Height)
        ButtonModifier.Location = obtenirNouvelleLocationY(ButtonModifier.Location, LabelTitre.Height)
        ButtonSupprimer.Location = obtenirNouvelleLocationY(ButtonModifier.Location, ButtonModifier.Height + distanceYEntre2GrosGroupBox)
        ButtonInserer.Location = obtenirNouvelleLocationY(ButtonSupprimer.Location, ButtonSupprimer.Height + distanceYEntre2GrosGroupBox)
        ButtonQuitter.Location = obtenirNouvelleLocationY(ButtonInserer.Location, ButtonInserer.Height + distanceYEntre2GrosGroupBox)

    End Sub
    Private Sub etablirGroupBoxListeDepartements()
        'Dimension en x
        ListBoxDepartements.Width = GroupBoxListeDepartements.Width - 2 * locationXDuPremierElementDUnGrosGroupBox

        'Position (x et y)
        ListBoxDepartements.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, locationYDuPremierElementDUnGrosGroupBox)

        'Dimension en y
        ListBoxDepartements.Height = dimY - (LabelTitre.Height + ListBoxDepartements.Location.Y + distanceYEntre2GrosGroupBox + locationXDuPremierElementDUnPetitGroupBox)
    End Sub

    Private Sub etablirGroupBoxGestionDepartements()
        'Dimensions en x
        GroupBoxSelectionAction.Width = GroupBoxGestionDepartements.Width - 2 * locationXDuPremierElementDUnGrosGroupBox
        GroupBoxDonnees.Width = GroupBoxSelectionAction.Width

        'Position en x
        GroupBoxSelectionAction.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, 0)
        GroupBoxDonnees.Location = GroupBoxSelectionAction.Location

        etablirGroupBoxSelectionAction()
        etablirGroupBoxDonnees()

        'Dimensions en y
        GroupBoxSelectionAction.Height = obtenirHauteurGroupBox(RadioButtonInserer)
        GroupBoxDonnees.Height = obtenirHauteurGroupBox(TextBoxDepartement)

        'Poistion en y
        GroupBoxSelectionAction.Location = obtenirNouvelleLocationY(GroupBoxSelectionAction.Location, locationYDuPremierElementDUnGrosGroupBox)
        GroupBoxDonnees.Location = obtenirNouvelleLocationY(GroupBoxSelectionAction.Location, GroupBoxSelectionAction.Height + distanceYEntre2PetitsGroupBox)
    End Sub
    Private Sub etablirGroupBoxSelectionAction()
        'Position seulement
        RadioButtonModifierSupprimer.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        RadioButtonInserer.Location = obtenirNouvelleLocationY(RadioButtonModifierSupprimer.Location, RadioButtonModifierSupprimer.Height)
    End Sub
    Private Sub etablirGroupBoxDonnees()
        'Dimension en x
        TextBoxDepartement.Width = GroupBoxDonnees.Width - 2 * locationXDuPremierElementDUnPetitGroupBox
        'Position
        LabelDepartementId.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        TextBoxDepartementId.Location = obtenirNouvelleLocationY(LabelDepartementId.Location, LabelDepartementId.Height)
        LabelDepartement.Location = obtenirNouvelleLocationY(TextBoxDepartementId.Location, TextBoxDepartementId.Height)
        TextBoxDepartement.Location = obtenirNouvelleLocationY(LabelDepartement.Location, LabelDepartement.Height)

    End Sub

End Class