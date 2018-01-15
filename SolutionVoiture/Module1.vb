Option Explicit On
Option Strict On

''' <summary>
''' module principal
''' </summary>
Module Module1
    Dim maClio As New Voiture
    Dim monTrajet As New Trajet("Nantes", "Bordeaux", 352)

    Sub Main()
        Dim ville1 As String = CStr(Saisir("ville départ", "String"))
        Dim ville2 As String = CType(Saisir("ville arrivée", "String"), String)
        Dim distV1V2 As Integer = CInt(Saisir("distance", "Integer"))
        Dim monTrajet2 As New Trajet(ville1, ville2, distV1V2)

        Dim monTrajet3 As New Trajet(CStr(Saisir("ville départ", "String")), CType(Saisir("ville arrivée", "String"), String), CInt(Saisir("distance", "Integer")))

        Dim uneDistance As New Distance(67)

        Console.WriteLine(monTrajet)
        Console.WriteLine(monTrajet2)
        Console.WriteLine(monTrajet3)

        If NeedHelp() Then
            Help()
            Environment.Exit(99)
        End If
        System.Console.ReadKey()
    End Sub

End Module
