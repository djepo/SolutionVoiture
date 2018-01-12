''' <summary>
''' classe Véhicule cf. diapo 42
''' </summary>
Public Class Vehicule
    Protected _moteur As String = "V6"
    Private _chassis As String = "4 RS"
    Private _carrosserie As String = "Rouge"

    Public Property leMoteur As String
        Get
            Return _moteur
        End Get
        Set(value As String)
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "> " & _chassis & ":" & _carrosserie
    End Function
End Class
