''' <summary>
''' Distance en km utilisée dans Trajet
''' </summary>
Public Class Distance
    Private _d As Integer
    Private _unité As String = "km"

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

    Public Overrides Function ToString() As String
        Return "(" & _d & _unité & ")"
    End Function

End Class
