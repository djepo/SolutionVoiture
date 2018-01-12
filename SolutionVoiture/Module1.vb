Option Explicit On
Option Strict On

''' <summary>
''' module principal
''' </summary>
Module Module1
    Dim maClio As New Voiture
    Dim monTrajet As New Trajet

    Sub Help()
        Console.WriteLine(My.Resources.Aide)
    End Sub
    Sub NeedHelp()
        For Each argument As String In My.Application.CommandLineArgs
            Select Case argument
                Case "--help", "-help", "-h", "/?" : Help()
            End Select
        Next
    End Sub


    Sub Main()
        'System.Console.WriteLine(maClio)
        'System.Console.WriteLine(maClio.leMoteur)
        'System.Console.WriteLine(maClio.GetMoteur)
        'monTrajet.Saisir()
        NeedHelp()
        System.Console.ReadKey()
    End Sub

End Module
