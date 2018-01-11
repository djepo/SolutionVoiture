Option Explicit On
Option Strict On

Module Module1
    Dim maClio As New Voiture

    Sub Main()
        System.Console.WriteLine(maClio)
        System.Console.WriteLine(maClio.leMoteur)
        System.Console.ReadKey()
    End Sub

End Module
