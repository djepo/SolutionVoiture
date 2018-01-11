Public Class Trajet
    Private _depart As String
    Private _arrivee As String
    Private _distance As Distance

    Public Sub Saisir()
        Console.Write("saisir Départ : ")
        _depart = Console.ReadLine
        Console.Write("saisir Arrivée : ")
        _arrivee = Console.ReadLine
    End Sub
End Class
