Public Class Decompte
    Private Shared _compte As Integer = 0
    ' Private Shared _instance As Decompte = Nothing

    ' Private Sub New()

    ' End Sub

    '  Public Shared Function Instance() As Decompte
    '  If IsNothing(_instance) Then
    '         _instance = New Decompte()
    'End If
    'Return _instance
    'End Function

    Private Shared Sub Compte(valeur As Integer)
        _compte += valeur
        Console.WriteLine("comptage objet(" & valeur & ") " & _compte)
    End Sub

    Public Shared Sub Plus()
        Compte(1)
    End Sub

    Public Shared Sub Moins()
        Compte(-1)
    End Sub
End Class
