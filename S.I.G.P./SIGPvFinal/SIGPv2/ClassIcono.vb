Public Class ClassIcono
    Inherits PictureBox
    Protected _tipo As String
    Protected _ruta As String
    Protected _id As String
    Protected _eliminar As Boolean
    Property tipo As String
        Get
            Return (_tipo)
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property
    Property ruta As String
        Get
            Return (_ruta)
        End Get
        Set(ByVal value As String)
            _ruta = value
        End Set
    End Property
    Property id As String
        Get
            Return (_id)
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    Property eliminar As Boolean
        Get
            Return (_eliminar)
        End Get
        Set(ByVal value As Boolean)
            _eliminar = value
        End Set
    End Property
End Class
