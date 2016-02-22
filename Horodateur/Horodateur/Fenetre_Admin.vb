Public Class Fenetre_Admin

    Private Sub Fenetre_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonImpressionUnEmploye.Click
        Fenetre_Impression_1_employe.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonImpressionPlusieursEmployes.Click
        Fenetre_Impression_1_groupe_d_employes.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonGestionnaireEmployes.Click
        Fenetre_Gestionnaire_d_employes.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonGestionnaireDepartements.Click
        Fenetre_Gestionnaire_de_Departements.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonGestionnaireEntreeSortie.Click
        Fenetre_Gestion_des_entreessorties.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonModifierMotDePasse.Click
        Fenetre_Gestionnaire_admin.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonRetourHorodateur.Click
        Me.Close()
        Fenetre_Horodateur.Show()
    End Sub


    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        FERMETUREDESACTIVEE = False
        thread.Abort()
        Me.Close()
        Fenetre_Horodateur.Close()
        'Application.Exit()
    End Sub

    Private Sub Fenetre_Admin_1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Fenetre_Horodateur.Show()
    End Sub




    Private Sub ButtonEffacerMemoire_Click(sender As Object, e As EventArgs) Handles ButtonEffacerMemoire.Click
        Fenetre_Effacage_memoire.Show()
    End Sub

    Private Sub etablirDimensions()
        'Dimensions
        LabelTitre.Size = New system.drawing.size(dimX, hauteurLabelTitre)
        ButtonImpressionUnEmploye.Height = (dimY - LabelTitre.Height) * 7 / 8 / 4
        ButtonImpressionUnEmploye.Width = ButtonImpressionUnEmploye.Height * 1.618033
        ButtonImpressionPlusieursEmployes.Size = ButtonImpressionUnEmploye.Size
        ButtonGestionnaireEmployes.Size = ButtonImpressionUnEmploye.Size
        ButtonGestionnaireDepartements.Size = ButtonImpressionUnEmploye.Size
        ButtonGestionnaireEntreeSortie.Size = ButtonImpressionUnEmploye.Size
        ButtonModifierMotDePasse.Size = ButtonImpressionUnEmploye.Size
        ButtonEffacerMemoire.Size = ButtonImpressionUnEmploye.Size
        ButtonRetourHorodateur.Size = ButtonImpressionUnEmploye.Size
        ButtonQuitter.Size = ButtonImpressionUnEmploye.Size
        ButtonBackUp.Size = ButtonImpressionPlusieursEmployes.Size
        ButtonImprimerRapportVerification.Size = ButtonImpressionUnEmploye.Size
        ButtonGestionnaireTypes.Size = ButtonImpressionUnEmploye.Size
        'Location
        LabelTitre.Location = New Point(0, 0)
        Dim distanceXEntreBoutons As Double = (dimX - 3 * ButtonImpressionUnEmploye.Width) / 4
        Dim distanceYEntreBoutons As Double = (dimY - hauteurLabelTitre - 4 * ButtonImpressionUnEmploye.Height) / 5
        ButtonImpressionUnEmploye.Location = New Point(distanceXEntreBoutons, LabelTitre.Height + distanceYEntreBoutons)
        ButtonImpressionPlusieursEmployes.Location = obtenirNouvelleLocationY(ButtonImpressionUnEmploye.Location, ButtonImpressionUnEmploye.Height + distanceYEntreBoutons)
        ButtonImprimerRapportVerification.Location = obtenirNouvelleLocationY(ButtonImpressionPlusieursEmployes.Location, ButtonImpressionPlusieursEmployes.Height + distanceYEntreBoutons)
        ButtonBackUp.Location = obtenirNouvelleLocationY(ButtonImprimerRapportVerification.Location, ButtonImprimerRapportVerification.Height + distanceYEntreBoutons)

        ButtonGestionnaireEmployes.Location = obtenirNouvelleLocationX(ButtonImpressionUnEmploye.Location, ButtonImpressionUnEmploye.Width + distanceXEntreBoutons)
        ButtonGestionnaireDepartements.Location = obtenirNouvelleLocationY(ButtonGestionnaireEmployes.Location, ButtonGestionnaireEmployes.Height + distanceYEntreBoutons)
        ButtonGestionnaireTypes.Location = obtenirNouvelleLocationY(ButtonGestionnaireDepartements.Location, ButtonImpressionUnEmploye.Height + distanceYEntreBoutons)
        ButtonGestionnaireEntreeSortie.Location = obtenirNouvelleLocationY(ButtonGestionnaireTypes.Location, ButtonGestionnaireTypes.Height + distanceYEntreBoutons)
        ButtonModifierMotDePasse.Location = obtenirNouvelleLocationX(ButtonGestionnaireEmployes.Location, ButtonImpressionUnEmploye.Width + distanceXEntreBoutons)
        ButtonEffacerMemoire.Location = obtenirNouvelleLocationY(ButtonModifierMotDePasse.Location, ButtonImpressionUnEmploye.Height + distanceYEntreBoutons)
        ButtonRetourHorodateur.Location = obtenirNouvelleLocationY(ButtonEffacerMemoire.Location, ButtonImpressionUnEmploye.Height + distanceYEntreBoutons)
        ButtonQuitter.Location = obtenirNouvelleLocationY(ButtonRetourHorodateur.Location, ButtonImpressionUnEmploye.Height + distanceYEntreBoutons)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonImprimerRapportVerification.Click
        Fenetre_impression_plusieurs_employes_par_page.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonBackUp.Click
        Fenetre_Backup.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles ButtonGestionnaireTypes.Click
        Fenetre_Gestionnaire_de_Types.Show()
    End Sub
End Class