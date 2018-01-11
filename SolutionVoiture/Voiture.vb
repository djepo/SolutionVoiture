Public Class Voiture
    Inherits Vehicule
    Private _roues As String = "4x195/55R16"

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

    Public Overrides Function ToString() As String
        Return MyBase.ToString & " " & _roues
    End Function
End Class
