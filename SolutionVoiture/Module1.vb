Option Explicit On
Option Strict On

''' <summary>
''' module principal
''' </summary>
Module Module1
    Dim maClio As New Voiture
    Dim monTrajet As New Trajet("Nantes", "Bordeaux", 352)

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

    Sub Main()
        'System.Console.WriteLine(maClio)
        'System.Console.WriteLine(maClio.leMoteur)
        'System.Console.WriteLine(maClio.GetMoteur)
        'monTrajet.Saisir()
        monTrajet.Afficher()

        If NeedHelp() Then
            Help()
            Environment.Exit(99)
        End If
        System.Console.ReadKey()
    End Sub

End Module
