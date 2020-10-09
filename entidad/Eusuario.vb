
Public Class Eusuario
    Private usuario As String
    Private pass As String
    Private tipo As String

    Public Property _usuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property
    Public Property _pass
        Get
            Return pass
        End Get
        Set(value)
            pass = value
        End Set
    End Property
    Public Property _tipo
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property
    Public Sub New()

    End Sub
End Class
