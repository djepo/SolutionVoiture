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

    Public Shared Operator &(c1 As String, d1 As Distance) As String
        Return c1 & d1.ToString
    End Operator

    Public Shared Operator &(d1 As Distance, c1 As String) As String
        Return d1.ToString & c1
    End Operator

End Class
