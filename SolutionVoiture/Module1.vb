Option Explicit On
Option Strict On

Module Module1
    Dim maClio As New Voiture
    Dim monTrajet As New Trajet

    Sub Main()
        System.Console.WriteLine(maClio)
        System.Console.WriteLine(maClio.leMoteur)
        System.Console.WriteLine(maClio.GetMoteur)
        monTrajet.Saisir()
        System.Console.ReadKey()
    End Sub

End Module
