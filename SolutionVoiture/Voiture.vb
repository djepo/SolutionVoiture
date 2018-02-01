''' <summary>
''' classe Voiture qui hérite de Véhicule
''' </summary>
Public Class Voiture
    Inherits Vehicule
    Private _roues As String = "4x195/55R16"

    Sub New()
        Decompte.Plus()
    End Sub
    Public Property lesRoues As String
        Get
            Return _roues
        End Get
        Set(value As String)
            If value <> "inconnu" Then
                _roues = value
            End If
        End Set
    End Property

    Public Function GetMoteur()
        Return _moteur
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString & " " & _roues
    End Function

    Protected Overrides Sub Finalize()
        Decompte.Moins()
    End Sub
End Class
