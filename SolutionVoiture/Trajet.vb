Public Class Trajet
    Private _depart As String
    Private _arrivee As String
    Private _distance As Distance

    Public Sub Saisir()
        Console.Write(My.Resources.SaisieDépart)
        _depart = Console.ReadLine
        Console.Write(My.Resources.SaisieArrivée)
        _arrivee = Console.ReadLine
    End Sub
End Class
