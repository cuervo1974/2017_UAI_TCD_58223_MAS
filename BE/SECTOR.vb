Public Class SECTOR

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String, pGerencia As String)
        With Me
            ._Id = pId
            ._Nombre = pNombre
            ._Gerencia = pGerencia
        End With
    End Sub

    Private _Id As Integer
    <System.ComponentModel.DisplayName("Número")>
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
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

    Private _Gerencia As String
    <System.ComponentModel.DisplayName("Gerencia")>
    Public Property Gerencia() As String
        Get
            Return _Gerencia
        End Get
        Set(ByVal value As String)
            _Gerencia = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class
