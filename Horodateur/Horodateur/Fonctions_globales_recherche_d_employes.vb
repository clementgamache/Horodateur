Public Module Fonctions_globales_recherche_d_employes
    'Listbox
    Private Sub remplirListBox(ByVal tabEmployes As Employe(), ByRef ListBoxEmployes As System.Windows.Forms.ListBox)

        ListBoxEmployes.Items.Clear()
        For Each employe In tabEmployes
            ListBoxEmployes.Items.Add(employe.id + " - " + employe.nom + ", " + employe.prenom)
        Next
        If ListBoxEmployes.Items.Count <> 0 Then
            ListBoxEmployes.SelectedIndex = 0
        End If

    End Sub
    Private Sub trierEtRemplirListBox(ByVal tabEmployes As Employe(), ByVal triId As Boolean, ByVal triNom As Boolean, ByVal TriPrenom As Boolean, ByRef ListBoxEmployes As System.Windows.Forms.ListBox)

        Select Case True
            Case triId
                remplirListBox(trierParId(tabEmployes), ListBoxEmployes)
            Case triNom
                remplirListBox(trierParNom(tabEmployes), ListBoxEmployes)
            Case TriPrenom
                remplirListBox(trierParPrenom(tabEmployes), ListBoxEmployes)
        End Select
    End Sub
    Private Function trierParNom(ByVal tabEmployes As Employe()) As Employe()
        For i As Integer = 0 To tabEmployes.Length - 1
            For j As Integer = i To tabEmployes.Length - 1
                If tabEmployes(j).nom < tabEmployes(i).nom And j > i Then
                    permuterDeuxEmployes(tabEmployes, i, j)
                End If
            Next
        Next

        Return tabEmployes
    End Function
    Private Function trierParPrenom(ByVal tabEmployes As Employe()) As Employe()
        For i As Integer = 0 To tabEmployes.Length - 1
            For j As Integer = i To tabEmployes.Length - 1
                If tabEmployes(j).prenom < tabEmployes(i).prenom And j > i Then
                    permuterDeuxEmployes(tabEmployes, i, j)
                End If
            Next
        Next
        Return tabEmployes
    End Function
    Private Function trierParId(ByVal tabEmployes As Employe()) As Employe()
        For i As Integer = 0 To tabEmployes.Length - 1
            For j As Integer = i To tabEmployes.Length - 1
                If tabEmployes(j).id < tabEmployes(i).id And j > i Then
                    permuterDeuxEmployes(tabEmployes, i, j)
                End If
            Next
        Next

        Return tabEmployes
    End Function
    Public Function trierParType(ByVal tabEmployes As Employe()) As Employe()
        For i As Integer = 0 To tabEmployes.Length - 1
            For j As Integer = i To tabEmployes.Length - 1
                If CInt(tabEmployes(j).idType) < CInt(tabEmployes(i).idType) And j > i Then
                    permuterDeuxEmployes(tabEmployes, i, j)
                End If
            Next
        Next

        Return tabEmployes
    End Function
    Private Sub permuterDeuxEmployes(ByRef tabEmployes As Employe(), ByVal index1 As Integer, ByVal index2 As Integer)
        Dim tempEmploye As Employe = tabEmployes(index1)
        tabEmployes(index1) = tabEmployes(index2)
        tabEmployes(index2) = tempEmploye
    End Sub
    Public Sub definirListbox(ByVal triId As Boolean, ByVal triNom As Boolean, ByVal triPrenom As Boolean, _
                              ByVal strDepartement As String, ByVal strType As String, ByRef ListBoxEmployes As System.Windows.Forms.ListBox)


        Dim idDepartement As String = strDepartement.Substring(0, 2)
        Dim idType As String = strType.Substring(0, 2)
        Select Case True
            Case strType = "(Tous)" And strDepartement = "(Tous)"
                trierEtRemplirListBox(obtenirTousEmployes, triId, triNom, triPrenom, ListBoxEmployes)
            Case strType = "(Tous)" And strDepartement <> "(Tous)"
                trierEtRemplirListBox(obtenirEmployesDuDepartement(idDepartement), triId, triNom, triPrenom, ListBoxEmployes)
            Case strType <> "(Tous)" And strDepartement = "(Tous)"
                trierEtRemplirListBox(obtenirEmployesDuType(idType), triId, triNom, triPrenom, ListBoxEmployes)
            Case strType <> "(Tous)" And strDepartement <> "(Tous)"
                trierEtRemplirListBox(obtenirEmployesTypeEtDepartement(idDepartement, idType), triId, triNom, triPrenom, ListBoxEmployes)
        End Select
    End Sub

    
    Public Sub etablirGroupBoxRechercheEmploye(ByRef LabelTitre As System.Windows.Forms.Label, _
                                               ByRef GroupBoxRechercheEmploye As System.Windows.Forms.GroupBox, _
                                               ByRef GroupBoxTri As System.Windows.Forms.GroupBox, _
                                               ByRef GroupBoxFiltre As System.Windows.Forms.GroupBox, _
                                               ByRef ListBoxEmployes As System.Windows.Forms.ListBox, _
                                               ByRef RadioButtonTriId As System.Windows.Forms.RadioButton, _
                                               ByRef RadioButtonTriNom As System.Windows.Forms.RadioButton, _
                                               ByRef RadioButtonTriPrenom As System.Windows.Forms.RadioButton, _
                                               ByRef LabelDepartement As System.Windows.Forms.Label, _
                                               ByRef ComboBoxDepartements As System.Windows.Forms.ComboBox, _
                                               ByRef LabelType As System.Windows.Forms.Label, _
                                               ByRef ComboBoxTypes As System.Windows.Forms.ComboBox)
        'Dimensions en x
        GroupBoxTri.Width = (GroupBoxRechercheEmploye.Width - 2 * locationXDuPremierElementDUnGrosGroupBox - distanceXEntre2PetitsGroupBox) * 3 / 8
        GroupBoxFiltre.Width = GroupBoxTri.Width * 5 / 3
        ListBoxEmployes.Width = GroupBoxRechercheEmploye.Width - 2 * locationXDuPremierElementDUnGrosGroupBox

        'Positionnement en x
        GroupBoxTri.Location = New Point(locationXDuPremierElementDUnGrosGroupBox, 0)
        GroupBoxFiltre.Location = obtenirNouvelleLocationX(GroupBoxTri.Location, GroupBoxTri.Width + distanceXEntre2PetitsGroupBox)
        ListBoxEmployes.Location = GroupBoxTri.Location

        etablirGroupBoxTri(RadioButtonTriId, RadioButtonTriNom, RadioButtonTriPrenom)
        etablirGroupBoxFiltre(GroupBoxFiltre, LabelDepartement, ComboBoxDepartements, LabelType, ComboBoxTypes)

        'Dimensions en y
        GroupBoxFiltre.Height = obtenirHauteurGroupBox(ComboBoxTypes)
        GroupBoxTri.Height = GroupBoxFiltre.Height
        ListBoxEmployes.Height = dimY - (LabelTitre.Height + GroupBoxFiltre.Location.Y + GroupBoxFiltre.Height + distanceYEntre2PetitsGroupBox + distanceYEntre2GrosGroupBox * 2 + locationXDuPremierElementDUnGrosGroupBox)

        'Positionnement en y
        GroupBoxTri.Location = obtenirNouvelleLocationY(GroupBoxTri.Location, locationYDuPremierElementDUnGrosGroupBox)
        GroupBoxFiltre.Location = obtenirNouvelleLocationY(GroupBoxFiltre.Location, locationYDuPremierElementDUnGrosGroupBox)
        ListBoxEmployes.Location = obtenirNouvelleLocationY(ListBoxEmployes.Location, GroupBoxFiltre.Location.Y + GroupBoxFiltre.Height + distanceYEntre2PetitsGroupBox)



    End Sub
    Private Sub etablirGroupBoxTri(ByRef RadioButtonTriId As System.Windows.Forms.RadioButton, _
                                   ByRef RadioButtonTriNom As System.Windows.Forms.RadioButton, _
                                   ByRef RadioButtonTriPrenom As System.Windows.Forms.RadioButton
                                   )
        'Positionnement en x et y
        RadioButtonTriId.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        RadioButtonTriNom.Location = obtenirNouvelleLocationY(RadioButtonTriId.Location, RadioButtonTriId.Height)
        RadioButtonTriPrenom.Location = obtenirNouvelleLocationY(RadioButtonTriNom.Location, RadioButtonTriNom.Height)

    End Sub
    Private Sub etablirGroupBoxFiltre(ByRef GroupBoxFiltre As System.Windows.Forms.GroupBox, _
                                      ByRef LabelDepartement As System.Windows.Forms.Label, _
                                      ByRef ComboBoxDepartement As System.Windows.Forms.ComboBox, _
                                       ByRef LabelType As System.Windows.Forms.Label, _
                                      ByRef ComboBoxType As System.Windows.Forms.ComboBox)
        'Dimensions en x
        ComboBoxDepartement.Width = GroupBoxFiltre.Width - 2 * locationXDuPremierElementDUnPetitGroupBox
        ComboBoxType.Width = ComboBoxDepartement.Width
        'Positionnement en x et y
        LabelDepartement.Location = New Point(locationXDuPremierElementDUnPetitGroupBox, locationYDuPremierElementDUnPetitGroupBox)
        ComboBoxDepartement.Location = obtenirNouvelleLocationY(LabelDepartement.Location, LabelDepartement.Height)
        LabelType.Location = obtenirNouvelleLocationY(ComboBoxDepartement.Location, ComboBoxDepartement.Height)
        ComboBoxType.Location = obtenirNouvelleLocationY(LabelType.Location, LabelType.Height)
    End Sub
End Module
