Public Class EVENTOBITACORA

    Sub New()

        End Sub

        Sub New(pId As Integer, pFecha As DateTime, pDesc As String)
            With Me
                ._Id = pId
                ._Fecha = pFecha
                ._Desc = pDesc
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

    Private _Usuario As USUARIO
    Public Property Usuario() As USUARIO
        Get
            Return _Usuario
        End Get
        Set(ByVal value As USUARIO)
            _Usuario = value
        End Set
    End Property

    Private _Fecha As DateTime
        Public Property Fecha() As DateTime
            Get
                Return _Fecha
            End Get
            Set(ByVal value As DateTime)
                _Fecha = value
            End Set
        End Property

        Private _Desc As String
        <System.ComponentModel.DisplayName("Descripción")>
        Public Property Desc() As String
            Get
                Return _Desc
            End Get
            Set(ByVal value As String)
                _Desc = value
            End Set
        End Property

    End Class
