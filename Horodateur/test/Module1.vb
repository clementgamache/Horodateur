Public Module Module1
    Public Class Personne
        Public nom As String
        Public prenom As String

        Public Sub New()
            nom = ""
            prenom = ""
        End Sub
        Public Sub New(ByVal tnom As String, ByVal tprenom As String)
            nom = tnom
            prenom = tprenom
        End Sub
    End Class
    Sub main()
        Dim pm As New Personne("Gamache", "Christina")
        Dim objStreamWriter As New System.IO.StreamWriter("F:\BackUp\Product.xml")
        Dim x As New System.Xml.Serialization.XmlSerializer(pm.GetType)
        x.Serialize(objStreamWriter, pm)
        objStreamWriter.Close()
    End Sub

End Module
