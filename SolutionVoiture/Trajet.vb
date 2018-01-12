''' <summary>
''' La classe trajet permet de décrire une ville de départ
''' une ville d'arrivée
''' et une distance en km
''' </summary>
Public Class Trajet
    Private _depart As String
    Private _arrivee As String
    'TODO: vérifier que la distance est en kilomètres
    Private _distance As Distance

    Sub New(dep As String, arr As String, dist As Integer)
        _depart = dep
        _arrivee = arr
        _distance = New Distance(dist)
    End Sub

    Public Sub Saisir()
        Console.Write(My.Resources.SaisieDépart)
        _depart = Console.ReadLine
        Console.Write(My.Resources.SaisieArrivée)
        _arrivee = Console.ReadLine
        'FIXME: saisir la distance
    End Sub

    Friend Sub Afficher()
        Console.WriteLine(_depart & " -> " & _arrivee & " : " & _distance.laDistance)
    End Sub
End Class
