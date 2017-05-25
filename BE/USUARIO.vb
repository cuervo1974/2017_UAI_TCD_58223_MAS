Public Class USUARIO

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String, pApellido As String, pUsername As String, pPassword As String)
        With Me
            ._ID_usuario = pId
            ._NOMBRE = pNombre
            ._APELLIDO = pApellido
            ._USERNAME = pUsername
            ._PASSWORD = pPassword
        End With
    End Sub

    Public Event mover()
    Private _ID_usuario As Integer
    <System.ComponentModel.DisplayName("Número")>
    Public Property ID_usuario() As Integer
        Get
            Return _ID_usuario
        End Get
        Set(ByVal value As Integer)
            _ID_usuario = value
        End Set
    End Property

    Private _NOMBRE As String
    Public Property NOMBRE() As String
        Get
            Return _NOMBRE
        End Get
        Set(ByVal value As String)
            _NOMBRE = value
        End Set
    End Property

    Private _APELLIDO As String
    Public Property APELLIDO() As String
        Get
            Return _APELLIDO
        End Get
        Set(ByVal value As String)
            _APELLIDO = value
        End Set
    End Property

    Private _USERNAME As String
    Public Property USERNAME() As String
        Get
            Return _USERNAME
        End Get
        Set(ByVal value As String)
            _USERNAME = value
        End Set
    End Property
    Private _PASSWORD As String
    <System.ComponentModel.Browsable(False)>
    Public Property PASSWORD() As String
        Get
            Return _PASSWORD
        End Get
        Set(ByVal value As String)
            _PASSWORD = value
        End Set
    End Property

    Private _FAMILIA As FAMILIA
    Public Property FAMILIA() As FAMILIA
        Get
            Return _FAMILIA
        End Get
        Set(ByVal value As FAMILIA)
            _FAMILIA = value
        End Set
    End Property

    Private _SECTOR As SECTOR
    Public Property SECTOR() As SECTOR
        Get
            Return _SECTOR
        End Get
        Set(ByVal value As SECTOR)
            _SECTOR = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me._APELLIDO & ", " & Me._NOMBRE
    End Function

    'Public Sub _mover()
    '    RaiseEvent mover()
    'End Sub
    'Private _ESTADISTICA As BE.ESTADISTICA
    'Public Property ESTADISTICA As ESTADISTICA
    '    Get
    '        Return _ESTADISTICA
    '    End Get
    '    Set(value As ESTADISTICA)
    '        _ESTADISTICA = value

    '    End Set
    'End Property
End Class
