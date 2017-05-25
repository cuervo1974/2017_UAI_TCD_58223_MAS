Public Class Singleton

    Private Sub New()

    End Sub

    Private Shared _Instancia As Singleton
    Public Shared ReadOnly Property Instancia() As Singleton
        Get
            If _Instancia Is Nothing Then
                _Instancia = New Singleton
            End If
            Return _Instancia
        End Get
    End Property

    Private _USUARIO As USUARIO
    Public Property USUARIO() As USUARIO
        Get
            If _USUARIO Is Nothing Then
                USUARIO = New USUARIO
            End If
            Return _USUARIO
        End Get
        Set(ByVal value As USUARIO)
            _USUARIO = value
        End Set
    End Property

End Class