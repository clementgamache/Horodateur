Public Class Fenetre_Gestionnaire_de_Types

    Private Sub Gestionnaire_de_Types_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
        RadioButtonModifierSupprimer.Checked = True
        miseAJourListBox()

    End Sub
    Sub miseAJourListBox()
        ListBoxTypes.Items.Clear()
        For Each type In obtenirTousTypes()
            ListBoxTypes.Items.Add(type.id + " - " + type.nom)
        Next
        If ListBoxTypes.Items.Count <> 0 Then
            ListBoxTypes.SelectedIndex = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonModifierSupprimer.CheckedChanged
        AcceptButton = ButtonModifier
        ButtonModifier.Enabled = True
        ButtonSupprimer.Enabled = True
        ButtonInserer.Enabled = False
        ListBoxTypes.Enabled = True
        miseAJourListBox()
        TextBoxTypeId.Enabled = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonInserer.CheckedChanged
        AcceptButton = ButtonInserer
        ButtonModifier.Enabled = False
        ButtonSupprimer.Enabled = False
        ButtonInserer.Enabled = True
        ListBoxTypes.Enabled = False
        TextBoxTypeId.Enabled = True
        TextBoxTypeId.Clear()
        TextBoxType.Clear()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTypes.SelectedIndexChanged
        TextBoxTypeId.Text = ListBoxTypes.SelectedItem.ToString.Substring(0, 2)
        TextBoxType.Text = obtenirType(ListBoxTypes.SelectedItem.ToString.Substring(0, 2)).nom
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Try
            If modEstCorrecte() Then
                renommerType(ListBoxTypes.SelectedItem.ToString.Substring(0, 2), TextBoxType.Text)
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
        If TextBoxType.Text.Trim = obtenirType(TextBoxTypeId.Text).nom Then
            Throw (New Exception(ERREURAUCUNEMODIFICATION))
        End If
        If Not (TextBoxType.Text.Length > 0 And TextBoxType.Text.Length < 30) Then
            Throw (New Exception(ERREURTYPEDEMAUVAISELONGUEUR))
        End If
        Return True
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
        Try
            If typeUtilise(ListBoxTypes.SelectedItem.ToString.Substring(0, 2)) Then
                Throw (New Exception(ERREURTYPEENCOREUTILISE))
            End If
            If MsgBox(DEMANDEDECONFIRMATION, 52, DEMANDEDECONFIRMATIONTITRE) = 6 Then
                supprimerType(ListBoxTypes.SelectedItem.ToString.Substring(0, 2))
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
            Dim nouveauType As New Type(TextBoxTypeId.Text, TextBoxType.Text)
            If insertionCorrecte(nouveauType) Then
                nouveauType.insererDansBd()
                MsgBox(CONFIRMATIONINSERTION, MsgBoxStyle.Information, CONFIRMATIONINSERTION)
                miseAJourListBox()
                TextBoxTypeId.Clear()
                TextBoxType.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub
    Private Function insertionCorrecte(ByVal type As Type) As Boolean
        If Not type.id Like "##" Then
            Throw (New Exception(ERREURID2CHIFFRES))
        ElseIf typeEstDansBd(type.id) Then
            Throw (New Exception(ERREURIDDEJAPRIS))
        ElseIf Not (type.nom.Length > 0 And type.nom.Length <= 30) Then
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
        GroupBoxListeTypes.Width = dimX / 4
        GroupBoxGestionTypes.Width = dimX * 5 / 16
        ButtonModifier.Width = dimX / 8
        ButtonSupprimer.Width = ButtonModifier.Width
        ButtonInserer.Width = ButtonModifier.Width
        ButtonQuitter.Width = ButtonModifier.Width

        'Position en x
        LabelTitre.Location = New Point(0, 0)
        GroupBoxListeTypes.Location = New Point((dimX - (GroupBoxListeTypes.Width + GroupBoxGestionTypes.Width + ButtonModifier.Width + 2 * distanceXEntre2GrosGroupBox)) / 2, 0)
        GroupBoxGestionTypes.Location = obtenirNouvelleLocationX(GroupBoxListeTypes.Location, GroupBoxListeTypes.Width + distanceXEntre2GrosGroupBox)
        ButtonModifier.Location = obtenirNouvelleLocationX(GroupBoxGestionTypes.Location, GroupBoxGestionTypes.Width + distanceXEntre2GrosGroupBox)
        ButtonSupprimer.Location = ButtonModifier.Location
        ButtonInserer.Location = ButtonModifier.Location
        ButtonQuitter.Location = ButtonModifier.Location

        etablirGroupBoxListeTypes()
        etablirGroupBoxGestionTypes()

        'Dimensions en y
        LabelTitre.Height = hauteurLabelTitre
        GroupBoxListeTypes.Height = obtenirHauteurGroupBox(ListBoxTypes)
        GroupBoxGestionTypes.Height = obtenirHauteurGroupBox(GroupBoxDonnees)
        ButtonModifier.Height = ButtonModifier.Width * 0.618033
        ButtonSupprimer.Height = ButtonModifier.Height
        ButtonInserer.Height = ButtonModifier.Height
        ButtonQuitter.Height = ButtonModifier.Height

        'Position en y
        GroupBoxListeTypes.Location = obtenirNouvelleLocationY(GroupBoxListeTypes.Location, LabelTitre.Height)
        GroupBoxGestionTypes.Location = obtenirNouvelleLocationY(GroupBoxGestionTypes.Location, LabelTitre.Height)
        ButtonModifier.Location = obtenirNouvelleLocationY(ButtonModifier.Location, LabelTitre.Height)
        ButtonSupprimer.Location = obtenirNouvelleLocationY(ButtonModifier.Location, ButtonModifier.Height + distanceYEntre2GrosGroupBox)
        ButtonInserer.Location = obtenirNouvelleLocationY(ButtonSupprimer.Location, ButtonSupprimer.Height + distanceYEntre2GrosGroupBox)
        ButtonQuitter.Location = obtenirNouvelleLocationY(ButtonInserer.Location, ButtonInserer.Height + distanceYEntre2GrosGroupBox)

    End Sub
    Private Sub etablirGroupBoxListeTypes()
        'Dimension en x
        ListBoxTypes.Width = GroupBoxListeTypes.Width - 2 * locationXDuPremierElementDUnGrosGroupBox

        'Position (x et y)
        ListBoxTypes.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, locationYDuPremierElementDUnGrosGroupBox)

        'Dimension en y
        ListBoxTypes.Height = dimY - (LabelTitre.Height + ListBoxTypes.Location.Y + distanceYEntre2GrosGroupBox + locationXDuPremierElementDUnPetitGroupBox)
    End Sub

    Private Sub etablirGroupBoxGestionTypes()
        'Dimensions en x
        GroupBoxSelectionAction.Width = GroupBoxGestionTypes.Width - 2 * locationXDuPremierElementDUnGrosGroupBox
        GroupBoxDonnees.Width = GroupBoxSelectionAction.Width

        'Position en x
        GroupBoxSelectionAction.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, 0)
        GroupBoxDonnees.Location = GroupBoxSelectionAction.Location

        etablirGroupBoxSelectionAction()
        etablirGroupBoxDonnees()

        'Dimensions en y
        GroupBoxSelectionAction.Height = obtenirHauteurGroupBox(RadioButtonInserer)
        GroupBoxDonnees.Height = obtenirHauteurGroupBox(TextBoxType)

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
        TextBoxType.Width = GroupBoxDonnees.Width - 2 * locationXDuPremierElementDUnPetitGroupBox
        'Position
        LabelTypeId.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        TextBoxTypeId.Location = obtenirNouvelleLocationY(LabelTypeId.Location, LabelTypeId.Height)
        LabelType.Location = obtenirNouvelleLocationY(TextBoxTypeId.Location, TextBoxTypeId.Height)
        TextBoxType.Location = obtenirNouvelleLocationY(LabelType.Location, LabelType.Height)

    End Sub

End Class