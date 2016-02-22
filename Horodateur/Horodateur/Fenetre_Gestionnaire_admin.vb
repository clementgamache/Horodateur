Public Class Fenetre_Gestionnaire_admin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonValider.Click
        If TextBoxActuel.Text <> obtenirMotDePasseAdmin() Then
            MsgBox("Le mot de passe actuel est invalide.", MsgBoxStyle.Critical, "Erreur : mot de passe invalide")
        ElseIf TextBoxNouveau1.Text.Length < 5 Or TextBoxNouveau1.Text.Length > 20 Then
            MsgBox("Le nouveau mot de passe doit contenir entre 5 et 20 caractères", MsgBoxStyle.Critical, "Erreur : Mot de passe de mauvaise dimension")
        ElseIf TextBoxNouveau1.Text <> TextBoxNouveau2.Text Then
            MsgBox("Le mot de passe n'a pas bien été transcrit", MsgBoxStyle.Critical, "Erreur : Mauvaise transcription du nouveau mot de passe")
        ElseIf TextBoxNouveau1.Text = TextBoxActuel.Text Then

            MsgBox("Le nouveau mot de passe doit être différent du présent", MsgBoxStyle.Critical, "Erreur : Même mot de passe")
        Else
            modifierMotDePasseAdmin1(TextBoxNouveau1.Text)
            MsgBox("Le mot de passe a été modifié avec succès.", MsgBoxStyle.Information, "Succès")
            Me.Close()
        End If
        TextBoxActuel.Clear()
        TextBoxNouveau1.Clear()
        TextBoxNouveau2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub


    Private Sub Fenetre_Gestionnaire_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
    End Sub

    Private Sub etablirDimensions()
        'Dimensions
        LabelTitre.Size = New Size(dimX, hauteurLabelTitre)
        TextBoxActuel.Width = dimX / 4
        TextBoxNouveau1.Width = TextBoxActuel.Width
        TextBoxNouveau2.Width = TextBoxActuel.Width
        ButtonValider.Size = New Size(dimX / 4, dimX / 4 * 0.618033)
        ButtonAnnuler.Size = ButtonValider.Size
        'Position
        LabelTitre.Location = New Point(0, 0)
        LabelDemandeAncien.Location = New Point(dimX / 4, dimY / 4)
        TextBoxActuel.Location = obtenirNouvelleLocationY(LabelDemandeAncien.Location, LabelDemandeAncien.Height)
        LabelDemandeNouveau.Location = obtenirNouvelleLocationY(TextBoxActuel.Location, TextBoxActuel.Height + distanceYEntre2GrosGroupBox)
        TextBoxNouveau1.Location = obtenirNouvelleLocationY(LabelDemandeNouveau.Location, LabelDemandeNouveau.Height)
        LabelDemandeReecriture.Location = obtenirNouvelleLocationY(TextBoxNouveau1.Location, TextBoxNouveau1.Height)
        TextBoxNouveau2.Location = obtenirNouvelleLocationY(LabelDemandeReecriture.Location, LabelDemandeReecriture.Height)
        ButtonValider.Location = obtenirNouvelleLocationY(TextBoxNouveau2.Location, TextBoxNouveau2.Height + distanceYEntre2GrosGroupBox)
        ButtonAnnuler.Location = obtenirNouvelleLocationX(ButtonValider.Location, ButtonValider.Width + distanceXEntre2GrosGroupBox)
    End Sub

   
End Class