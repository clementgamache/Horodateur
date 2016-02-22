Public Module Fonctions_globales_impression
    Public LARGEURMARGES As Integer = 400
    Private ESPACECODE As Integer = 14
    Private ESPACEDATE As Integer = 14
    Private ESPACEHEURE As Integer = 14
    Private ESPACETEMPS As Integer = 8
    Private ESPACEDESCRIPTIONEMPLOYE As Integer = 11
    Private ESPACETOTAL As Integer = ESPACECODE + 2 * ESPACEHEURE + 2 * ESPACEDATE + ESPACETEMPS
    Public p As New Font("Courier New", 12, FontStyle.Bold)
    Public hDATE As New Font("Courier New", 13, FontStyle.Bold)
    Public h1 As New Font("Courier New", 16, FontStyle.Bold)
    Public hEMPLOYE As New Font("Courier New", 17, FontStyle.Bold)
    Public hTOTAL As New Font("Courier New", 16, FontStyle.Bold)
    Private constanteProduit = 955
    Public NBPPARLIGNE As Double = constanteProduit / p.Size
    Public NBHDATEPARLIGNE As Double = constanteProduit / hDATE.Size
    Public NBH1PARLIGNE As Double = constanteProduit / h1.Size
    Public NBHTOTALPARLIGNE As Double = constanteProduit / hTOTAL.Size
    Private NOMBRELIGNESPARFEUILLE As Integer = 40
    Public NOMBRESDELIGNESPARFEUILLE As Integer = 45
    Public MARGESTITRE As System.Drawing.Rectangle
    Public MARGESTEXTE As System.Drawing.Rectangle
    Public MARGESDATES As System.Drawing.Rectangle
    Public MARGESNODEPAGE As System.Drawing.Rectangle
    Public NBLIGNESAJOUTEES As Integer = 3
    Public ESPACEAJOUTE As Integer = 50

    Public Sub setCaracteristiquesImprimante(ByRef PrintDocument1 As System.Drawing.Printing.PrintDocument)
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintDocument1.PrinterSettings.Copies = 1
        'PrintDocument1.PrinterSettings.PrinterName = "Bullzip PDF Printer"
        PrintDocument1.PrinterSettings.PrinterName = obtenirImprimante()
    End Sub

    Private Sub ecrireTitre(ByRef e As Printing.PrintPageEventArgs, _
                             ByRef rapportDemande As Rapport, _
                             ByRef margeMobile As System.Drawing.Rectangle, _
                             ByVal titre() As String)
        e.Graphics.DrawString(titre(0), h1, Brushes.Black, margeMobile, StringFormat.GenericTypographic)
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, h1.Height))
        e.Graphics.DrawString(titre(1), h1, Brushes.Black, margeMobile, StringFormat.GenericTypographic)
    End Sub

    Private Sub ecrireDates(ByRef e As Printing.PrintPageEventArgs, _
                             ByRef rapportDemande As Rapport, _
                             ByRef margeMobile As System.Drawing.Rectangle, _
                             ByVal stringDate As String)
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, h1.Height * 1.5))
        margeMobile.Height = hDATE.Height
        e.Graphics.DrawString(stringDate, hDATE, Brushes.Black, margeMobile, StringFormat.GenericTypographic)
    End Sub
    Public Sub ecrireRapport(ByRef e As Printing.PrintPageEventArgs, _
                             ByRef poursuite As Boolean, _
                             ByVal date1 As Date, _
                             ByVal date2 As Date, _
                             ByRef rapportDemande As Rapport, _
                             ByRef margeMobile As System.Drawing.Rectangle, _
                             ByVal verif As Boolean, _
                             ByRef compte As Integer)

        'Écriture du titre

        Dim titre As String() = IIf(verif, _
                                    {"RAPPORT DE VÉRIFICATION", "Département : " + obtenirEmploye(rapportDemande.idEmploye).idDepartement + " - " + obtenirDepartement(obtenirEmploye(rapportDemande.idEmploye).idDepartement).nom}, _
                                    {"RAPPORT DE TEMPS", "Type : " + obtenirEmploye(rapportDemande.idEmploye).idType + " - " + obtenirType(obtenirEmploye(rapportDemande.idEmploye).idType).nom})

        ecrireTitre(e, rapportDemande, margeMobile, titre)


        'Écriture de la date
        Dim stringDate As String = "DATE DÉBUT : " + date1.ToShortDateString + "   " + "DATE FIN : " + date2.ToShortDateString
        ecrireDates(e, rapportDemande, margeMobile, stringDate)


        'Écriture du nom
        If Not poursuite Then
            'Écriture du nom
            margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, hDATE.Height * 2))
            margeMobile.Height = hEMPLOYE.Height
            e.Graphics.DrawString(rapportDemande.stringEmploye, hEMPLOYE, Brushes.Black, margeMobile, StringFormat.GenericTypographic)

        End If
        'Écriture du contenu
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, hEMPLOYE.Height))
        margeMobile.Height = p.Height
        e.Graphics.DrawString(compte, p, Brushes.Black, New System.Drawing.Point(margeMobile.Location.X + margeMobile.Width, 950 + p.Height), StringFormat.GenericTypographic)
        compte += 1
        For i As Integer = 0 To rapportDemande.stringContenu.Count - 1
            'If listeDeRapports(0).stringContenu.Count < 0 Then
            '    Exit For
            'End If
            If margeMobile.Location.Y >= 950 Then
                poursuite = True
                e.HasMorePages = True
                Exit Sub
            Else
                e.HasMorePages = False
            End If
            If rapportDemande.stringContenu(0).Contains("____") Then
                margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, p.Height / 3))
            Else
                margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, p.Height))
            End If
            e.Graphics.DrawString(rapportDemande.stringContenu(0), p, Brushes.Black, margeMobile, StringFormat.GenericTypographic)
            rapportDemande.stringContenu.Remove(rapportDemande.stringContenu(0))
        Next

        margeMobile.Height = hTOTAL.Height
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, p.Height))
        e.Graphics.DrawString(rapportDemande.stringTotal, hTOTAL, Brushes.Black, margeMobile, StringFormat.GenericTypographic)
        poursuite = False


    End Sub
    Private Sub ecrireSansHeader(ByRef e As Printing.PrintPageEventArgs, _
                             ByVal date1 As Date, _
                             ByVal date2 As Date, _
                             ByRef rapportDemande As Rapport, _
                             ByRef margeMobile As System.Drawing.Rectangle)
        'Écriture du nom
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, hDATE.Height * 2))
        margeMobile.Height = hEMPLOYE.Height
        e.Graphics.DrawString(rapportDemande.stringEmploye, hEMPLOYE, Brushes.Black, margeMobile, StringFormat.GenericTypographic)

        'Écriture du contenu
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, hEMPLOYE.Height))
        margeMobile.Height = p.Height
        For i As Integer = 0 To rapportDemande.stringContenu.Count - 1
            'If listeDeRapports(0).stringContenu.Count < 0 Then
            '    Exit For
            'End If

            If rapportDemande.stringContenu(0).Contains("____") Then
                margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, p.Height / 3))
            Else
                margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, p.Height))
            End If
            e.Graphics.DrawString(rapportDemande.stringContenu(0), p, Brushes.Black, margeMobile, StringFormat.GenericTypographic)
            rapportDemande.stringContenu.Remove(rapportDemande.stringContenu(0))
        Next

        margeMobile.Height = hTOTAL.Height
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, p.Height))
        e.Graphics.DrawString(rapportDemande.stringTotal, hTOTAL, Brushes.Black, margeMobile, StringFormat.GenericTypographic)

    End Sub
    Public Sub ecrireRapports(ByRef e As Printing.PrintPageEventArgs, _
                             ByRef poursuite As Boolean, _
                             ByVal date1 As Date, _
                             ByVal date2 As Date, _
                             ByRef listeDeRapports() As Rapport, _
                             ByRef compte As Integer)
        Dim fractionDeLaPageOccupee As Double = 15 / 16
        LARGEURMARGES = e.PageBounds.Width * (1 - (1 - fractionDeLaPageOccupee) / 2)
        Dim margeMobile As New System.Drawing.Rectangle(New Point(e.PageBounds.Width * (1 - fractionDeLaPageOccupee) / 2, e.PageBounds.Height * (1 - fractionDeLaPageOccupee) / 2), New Size(LARGEURMARGES, h1.Height))

        ecrireRapport(e, poursuite, date1, date2, listeDeRapports(0), margeMobile, False, compte)
        If Not poursuite Then
            For i As Integer = 1 To UBound(listeDeRapports)
                listeDeRapports(i - 1) = listeDeRapports(i)
            Next
            ReDim Preserve listeDeRapports(UBound(listeDeRapports) - 1)
        End If
        e.HasMorePages = listeDeRapports.Length > 0
    End Sub

    Public Sub ecrireVerification(ByRef e As Printing.PrintPageEventArgs, _
                             ByRef poursuite As Boolean, _
                             ByVal date1 As Date, _
                             ByVal date2 As Date, _
                             ByRef listeDeRapports() As Rapport, _
                             ByRef compte As Integer)
        Dim fractionDeLaPageOccupee As Double = 15 / 16
        LARGEURMARGES = e.PageBounds.Width * (1 - (1 - fractionDeLaPageOccupee) / 2)

        Dim margeMobile As New System.Drawing.Rectangle(New Point(e.PageBounds.Width * (1 - fractionDeLaPageOccupee) / 2, e.PageBounds.Height * (1 - fractionDeLaPageOccupee) / 2), New Size(LARGEURMARGES, h1.Height))

        ecrireRapport(e, poursuite, date1, date2, listeDeRapports(0), margeMobile, True, compte)
        margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, ESPACEAJOUTE))
        Dim idDepartementPresent As String = obtenirEmploye(listeDeRapports(0).idEmploye).idDepartement
        If Not poursuite Then
            For i As Integer = 1 To UBound(listeDeRapports)
                listeDeRapports(i - 1) = listeDeRapports(i)
            Next
            ReDim Preserve listeDeRapports(UBound(listeDeRapports) - 1)
        End If

        While listeDeRapports.Length > 0
            If listeDeRapports(0).hauteur + margeMobile.Bottom < e.PageBounds.Height / 2 * (fractionDeLaPageOccupee + 1) And idDepartementPresent = obtenirEmploye(listeDeRapports(0).idEmploye).idDepartement Then
                ecrireSansHeader(e, date1, date2, listeDeRapports(0), margeMobile)
                margeMobile.Location = Point.Add(margeMobile.Location, New Size(0, ESPACEAJOUTE))
                For i As Integer = 1 To UBound(listeDeRapports)
                    listeDeRapports(i - 1) = listeDeRapports(i)
                Next
                ReDim Preserve listeDeRapports(UBound(listeDeRapports) - 1)
            Else
                e.HasMorePages = True
                Exit Sub
            End If
        End While
        e.HasMorePages = False
    End Sub


End Module