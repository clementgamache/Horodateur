Public Class Fenetre_Backup
    Private nomPath As String
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonParcourir.Click
        Using fld As New FolderBrowserDialog()
            If fld.ShowDialog() = Windows.Forms.DialogResult.OK Then
                TextBox1.Text = fld.SelectedPath
                nomPath = fld.SelectedPath
                ButtonBackUp.Enabled = True
            End If
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonBackUp.Click
        Try
            ecrireXmlTypes()
            ecrireXmlDepartements()
            ecrireXmlEmployes()
            ecrireXmlEntreeSortie()
            MsgBox(CONFIRMATIONMODIFICATION, MsgBoxStyle.Information, CONFIRMATIONMODIFICATION)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
    End Sub

    Private Sub ecrireXmlTypes()
        Dim objStreamWriter As New System.IO.StreamWriter(nomPath + "\Types.xml")
        Dim x As New System.Xml.Serialization.XmlSerializer(obtenirTousTypes.GetType)
        x.Serialize(objStreamWriter, obtenirTousTypes)
        objStreamWriter.Close()
    End Sub
    Private Sub ecrireXmlDepartements()
        Dim objStreamWriter As New System.IO.StreamWriter(nomPath + "\Departements.xml")
        Dim x As New System.Xml.Serialization.XmlSerializer(obtenirTousDepartements.GetType)
        x.Serialize(objStreamWriter, obtenirTousDepartements)
        objStreamWriter.Close()
    End Sub
    Private Sub ecrireXmlEmployes()
        Dim objStreamWriter As New System.IO.StreamWriter(nomPath + "\Employes.xml")
        Dim x As New System.Xml.Serialization.XmlSerializer(obtenirTousEmployes.GetType)
        x.Serialize(objStreamWriter, obtenirTousEmployes)
        objStreamWriter.Close()
    End Sub
    Private Sub ecrireXmlEntreeSortie()
        Dim objStreamWriter As New System.IO.StreamWriter(nomPath + "\EntreesSorties.xml")
        Dim x As New System.Xml.Serialization.XmlSerializer(obtenirToutesEntreesSorties.GetType)
        x.Serialize(objStreamWriter, obtenirToutesEntreesSorties)
        objStreamWriter.Close()
    End Sub

    Private Sub Fenetre_Backup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        etablirDimensions()
    End Sub
    Private Sub etablirDimensions()
        LabelTitre.SetBounds(0, 0, dimX, hauteurLabelTitre)
        TextBox1.Width = LabelConsignes.Width - ButtonParcourir.Width - distanceXEntre2PetitsGroupBox
        ButtonBackUp.Width = LabelConsignes.Width / 2
        ButtonBackUp.Height = ButtonBackUp.Width * 0.618033
        ButtonQuitter.Size = ButtonBackUp.Size
        ButtonParcourir.Height = TextBox1.Height

        LabelConsignes.Location = New Point(dimX / 2 - LabelConsignes.Width / 2, dimY / 2 - (ButtonBackUp.Height + TextBox1.Height + LabelConsignes.Height + 2 * distanceYEntre2PetitsGroupBox) / 2)
        TextBox1.Location = obtenirNouvelleLocationY(LabelConsignes.Location, LabelConsignes.Height + distanceYEntre2PetitsGroupBox)
        ButtonParcourir.Location = obtenirNouvelleLocationX(TextBox1.Location, TextBox1.Width + distanceXEntre2PetitsGroupBox)
        ButtonBackUp.Location = Point.Add(TextBox1.Location, New Size(LabelConsignes.Width / 2 - ButtonBackUp.Width / 2, TextBox1.Height + distanceYEntre2PetitsGroupBox))
        ButtonQuitter.Location = New Point(LabelConsignes.Location.X + LabelConsignes.Width + distanceXEntre2GrosGroupBox, dimY / 2 - ButtonQuitter.Height / 2)
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub
End Class