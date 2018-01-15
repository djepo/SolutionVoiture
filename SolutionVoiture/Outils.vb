Module Outils
    Sub Help()
        Console.WriteLine(My.Resources.Aide)

    End Sub

    Function NeedHelp() As Boolean
        For Each argument As String In My.Application.CommandLineArgs
            Select Case argument
                Case "--help", "-help", "-h", "/?"
                    Return True
            End Select
        Next
        Return False
    End Function

    Function Saisir(nom As String, type As String) As Object
        Console.Write("Saisie " & nom & ": ")
        Dim valeur As String = Console.ReadLine
        If type.ToUpper.Equals("STRING") Then
            Return valeur
        ElseIf UCase(type).Equals("INTEGER") And IsNumeric(valeur) Then
            Return CInt(valeur)
        Else
            Return Nothing
        End If
    End Function

    Function TestSaisir() As Boolean
        Dim OK As Boolean = True
        Dim valeur As Object

        valeur = Saisir("chaîne", "String")
        If TypeOf valeur Is String Then
            OK = OK And True
        Else
            OK = OK And False
        End If
        valeur = Saisir("entier", "Integer")
        If TypeOf valeur Is Integer Then
            OK = OK And True
        Else
            OK = OK And False
        End If
        valeur = Saisir("truc", "Autre Chose")
        If valeur Is Nothing Then
            OK = OK And True
        Else
            OK = OK And False
        End If

        Return OK
    End Function

End Module
