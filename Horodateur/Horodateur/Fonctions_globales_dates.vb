Public Module Fonctions_globales_dates
    Public Sub etablirGroupBoxDates(ByRef GroupBoxDates As System.Windows.Forms.GroupBox, _
                                    ByRef LabelDebut As System.Windows.Forms.Label, _
                                    ByRef MonthCalendar1 As System.Windows.Forms.MonthCalendar, _
                                    ByRef LabelFin As System.Windows.Forms.Label, _
                                    ByRef MonthCalendar2 As System.Windows.Forms.MonthCalendar)
        'Positionnement seulement
        LabelDebut.Location = New Point(GroupBoxDates.Width / 2 - MonthCalendar1.Width / 2, locationYDuPremierElementDUnGrosGroupBox)
        MonthCalendar1.Location = obtenirNouvelleLocationY(LabelDebut.Location, LabelDebut.Height)
        LabelFin.Location = obtenirNouvelleLocationY(MonthCalendar1.Location, MonthCalendar1.Height + distanceXEntre2PetitsGroupBox)
        MonthCalendar2.Location = obtenirNouvelleLocationY(LabelFin.Location, LabelFin.Height)

    End Sub
End Module
