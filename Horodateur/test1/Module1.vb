Imports System
Imports System.Xml

Module Module1

    Sub Main()
        If IO.File.Exists("MyXML.xml") = False Then

            'declare our xmlwritersettings object
            Dim settings As New XmlWriterSettings()

            'lets tell to our xmlwritersettings that it must use indention for our xml
            settings.Indent = True

            'lets create the MyXML.xml document, the first parameter was the Path/filename of xml file
            ' the second parameter was our xml settings
            Dim XmlWrt As XmlWriter = XmlWriter.Create("MyXML.xml", settings)

            With XmlWrt

                ' Write the Xml declaration.
                .WriteStartDocument()

                ' Write a comment.
                .WriteComment("XML Database.")

                ' Write the root element.
                .WriteStartElement("Data")

                ' Start our first person.
                .WriteStartElement("Person")

                ' The person nodes.

                .WriteStartElement("FirstName")
                .WriteString("Alleo")
                .WriteEndElement()

                .WriteStartElement("LastName")
                .WriteString("Indong")
                .WriteEndElement()


                ' The end of this person.
                .WriteEndElement()

                ' Close the XmlTextWriter.
                .WriteEndDocument()
                .Close()

            End With

            MsgBox("XML file saved.")
        End If
    End Sub

End Module
