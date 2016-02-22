Imports Microsoft.Win32
Public Class Fenetre_Horodateur
    Private Sub Form1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        KeyboardJammer.Jam()
    End Sub
    Private Sub Form1_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        KeyboardJammer.UnJam()
    End Sub
    Private tempId As String
    
    'Ouverture du programme

    Private Sub Horodateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'etablirDimensions()
        Timer1.Interval = 1000
        Timer1.Start()
        TextBoxId.Focus()
        reinitialiserConditions()
        'SystemParametersInfo(97, True, CStr(1), 0)
        


    End Sub
    
    
    Private Sub frmMyform_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FERMETUREDESACTIVEE Then
            Dim Cancel As Boolean = eventArgs.Cancel
            Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
            Cancel = True
            'Allow it to close if it wasn't the user's action
            eventArgs.Cancel = Cancel
        Else
            'Me.Close()
            Application.Exit()
        End If
    End Sub
    'Pour vérifier si l'entrée permet de faire entrer l'employé
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxId.TextChanged
        If TextBoxId.Text.Length = 3 Then
            Try
                If Not idEstNumérique(TextBoxId.Text) Then
                    Throw (New System.Exception(ERREURID3CHIFFRES))
                End If
                If Not employeEstDansBd(TextBoxId.Text) Then
                    Throw (New System.Exception(ERREURIDINEXISTANT))
                End If
                tempId = TextBoxId.Text
                libererButton()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
                If CONNEXION.State = ConnectionState.Open Then
                    CONNEXION.Close()
                End If
            End Try
            TextBoxId.Text = ""
        Else
        End If
    End Sub

    'Buttons 1 à 10 et clear
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reinitialiserConditions()
        TextBoxId.AppendText(1)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reinitialiserConditions()
        TextBoxId.AppendText(2)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reinitialiserConditions()
        TextBoxId.AppendText(3)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        reinitialiserConditions()
        TextBoxId.AppendText(4)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        reinitialiserConditions()
        TextBoxId.AppendText(5)
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        reinitialiserConditions()
        TextBoxId.AppendText(6)
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        reinitialiserConditions()
        TextBoxId.AppendText(7)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        reinitialiserConditions()
        TextBoxId.AppendText(8)
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        reinitialiserConditions()
        TextBoxId.AppendText(9)
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button0.Click
        reinitialiserConditions()
        TextBoxId.AppendText(0)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        reinitialiserConditions()
        TextBoxId.Clear()
    End Sub

    'Buttons in et out
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles ButtonEntree.Click
        Try
            reinitialiserConditions()
            punchInOut(tempId)
            Dim entreeSortieTemp As New EntreeSortie(tempId)
            entreeSortieTemp.insererDansBd()
            TextBoxId.Enabled = False
            System.Threading.Thread.Sleep(1000)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
        TextBoxId.Enabled = True
        TextBoxId.Focus()
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles ButtonSortie.Click
        Try
            reinitialiserConditions()
            punchInOut(tempId)
            Dim entreeSortieTemp As New EntreeSortie(tempId)
            entreeSortieTemp.insererDansBd()
            TextBoxId.Enabled = False
            System.Threading.Thread.Sleep(1000)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, ex.Message)
            If CONNEXION.State = ConnectionState.Open Then
                CONNEXION.Close()
            End If
        End Try
        TextBoxId.Enabled = True
        TextBoxId.Focus()
    End Sub

    'Cliquer sur "Aller en mode admin"
    
    'Timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Fenetre_Admin.Visible = False Then
            LabelTimer.Text = Date.Now.ToShortDateString + vbNewLine + _
            Date.Now.ToShortTimeString()
            Try
                thread.Start()
            Catch ex As Exception
                If CONNEXION.State = ConnectionState.Open Then
                    CONNEXION.Close()
                End If
            End Try
        End If
    End Sub
    Private Sub TextBoxId_Click(sender As Object, e As EventArgs) Handles TextBoxId.Click
        reinitialiserConditions()
    End Sub
    'Actions à effectuer pour laisser l'employé entrer
    Private Sub libererButton()
        LabelBas.Text = obtenirEmploye(tempId).nom + ", " + obtenirEmploye(tempId).prenom
        If obtenirEmploye(tempId).punchedIn Then
            ButtonSortie.Enabled = True
            ButtonSortie.ForeColor = Color.Red
            'ButtonSortie.BackColor = Color.Yellow
            ButtonSortie.Select()
        Else
            ButtonEntree.Enabled = True
            ButtonEntree.ForeColor = Color.Red
            'ButtonEntree.BackColor = Color.Yellow
            ButtonEntree.Select()
        End If
    End Sub
    'Actions à effectuer pour annuler la proposition d'entrée à l'employé
    Private Sub reinitialiserConditions()
        ButtonEntree.Enabled = False
        ButtonSortie.Enabled = False
        ButtonEntree.ForeColor = Color.Black
        ButtonSortie.ForeColor = Color.Black
        'ButtonEntree.BackColor = Color.Gray
        'ButtonSortie.BackColor = Color.Gray
        LabelBas.Text = "Entrez votre # d'identification"
        TextBoxId.Focus()
    End Sub


   
    
    Private Sub ButtonAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAdmin.Click
        TextBoxId.Focus()
        Fenetre_Demande_de_mot_de_passe.Show()
    End Sub
End Class
