Imports System.Data.SqlClient


Public Module VarFonctGlobales

    

    Public FERMETUREDESACTIVEE As Boolean = True

    Public thread As New Threading.Thread(AddressOf block)
    Sub block()
        While True
            For Each process As Process In process.GetProcessesByName("TaskMgr")
                Try
                    process.Kill()

                Catch ex As Exception
                    If CONNEXION.State = ConnectionState.Open Then
                        CONNEXION.Close()
                    End If
                End Try
            Next
        End While
    End Sub


    Public Function idEstNumérique(ByVal id As String) As Boolean
        If id Like "###" Then
            Return True
        End If

        'MsgBox(ERREURID3CHIFFRES, MsgBoxStyle.Critical, ERREURID3CHIFFRES)
        Return False
    End Function

   
    
    
End Module