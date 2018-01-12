''' <summary>
''' Distance en km utilisée dans Trajet
''' </summary>
Public Class Distance
    Private _d As Integer

    Sub New(d As Integer)
        _d = d
    End Sub

    Public Property laDistance As Integer
        Get
            Return _d
        End Get
        Set(value As Integer)
        End Set
    End Property
End Class
