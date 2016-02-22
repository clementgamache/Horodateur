Public Module Variables_globales_interface_graphique
    'Général
    Public dimX As Double = My.Computer.Screen.Bounds.Width
    Public dimY As Double = My.Computer.Screen.Bounds.Height
    

    'Horodateur
    Public distanceEntreDeuxBoutonsNumero As Double = dimX / 128
    'Titre
    Public hauteurLabelTitre As Double = dimY / 8

    'Recherche d'employé
    Public largeurGroupBoxRechercheEmploye As Double = dimX * 3 / 8

    Public distanceXEntre2PetitsGroupBox As Double = dimY / 32
    Public distanceYEntre2PetitsGroupBox As Double = dimY / 32
    Public locationXDuPremierElementDUnPetitGroupBox As Double = dimY / 64
    Public locationYDuPremierElementDUnPetitGroupBox As Double = dimY * 1.5 / 32

    Public distanceXEntre2GrosGroupBox As Double = dimY / 16
    Public distanceYEntre2GrosGroupBox As Double = dimY / 16
    Public locationXDuPremierElementDUnGrosGroupBox As Double = dimY / 64
    Public locationYDuPremierElementDUnGrosGroupBox As Double = dimY / 16

    'Filtre de département
    Public Sub remplirComboBoxDepartements(ByRef ComboBoxDepartements As System.Windows.Forms.ComboBox, ByVal avecTous As Boolean)

        ComboBoxDepartements.Items.Clear()
        ComboBoxDepartements.Sorted = True
        If avecTous Then
            ComboBoxDepartements.Items.Add("(Tous)")
        End If
        For Each departement In obtenirTousDepartements()
            ComboBoxDepartements.Items.Add(departement.id + " - " + departement.nom)
        Next
        If ComboBoxDepartements.Items.Count > 0 And avecTous Then
            ComboBoxDepartements.SelectedIndex = 0
        End If

    End Sub
    Public Sub remplirComboBoxTypes(ByRef ComboBoxTypes As System.Windows.Forms.ComboBox, ByVal avecTous As Boolean)

        ComboBoxTypes.Items.Clear()
        ComboBoxTypes.Sorted = True
        If avecTous Then
            ComboBoxTypes.Items.Add("(Tous)")
        End If
        For Each type In obtenirTousTypes()
            ComboBoxTypes.Items.Add(type.id + " - " + type.nom)
        Next
        If obtenirTousTypes().Length > 0 Then
            ComboBoxTypes.SelectedItem = "(Tous)"
        End If
    End Sub
    Public Function obtenirNouvelleLocationY(ByVal locationOrigine As Point, ByVal distance As Double)
        Return Point.Add(locationOrigine, New Size(0, distance))
    End Function
    Public Function obtenirNouvelleLocationX(ByVal locationOrigine As Point, ByVal distance As Double)
        Return Point.Add(locationOrigine, New Size(distance, 0))
    End Function
    Public Function obtenirHauteurGroupBox(ByVal objet As Object) As Double
        Return objet.location.y + objet.height + objet.location.x
    End Function
End Module
