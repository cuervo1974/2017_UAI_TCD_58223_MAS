Public Class CLIENTE

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String, pApellido As String, pInterno As String, pSector As String, pEmail As String, pLegajo As String)
        With Me
            ._Id = pId
            ._Nombre = pNombre
            ._Apellido = pApellido
            ._Interno = pInterno
            ._Sector = pSector
            ._Email = pEmail
            ._Legajo = pLegajo
        End With
    End Sub

    Private _Id As Integer
    <System.ComponentModel.DisplayName("Número")>
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Private _Apellido As String
    Public Property Apellido() As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property

    Private _Interno As String
    Public Property Interno() As String
        Get
            Return _Interno
        End Get
        Set(ByVal value As String)
            _Interno = value
        End Set
    End Property

    Private _Sector As String
    Public Property Sector() As String
        Get
            Return _Sector
        End Get
        Set(ByVal value As String)
            _Sector = value
        End Set
    End Property

    Private _Email As String
    Public Property Email() As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    Private _Legajo As String
    Public Property Legajo() As String
        Get
            Return _Legajo
        End Get
        Set(ByVal value As String)
            _Legajo = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me._Apellido & ", " & Me._Nombre
    End Function

End Class
