Imports System.Collections.Generic

Public Class FAMILIA

    Sub New()

    End Sub

    Sub New(pId As Integer, pNombre As String)
        With Me
            ._Id = pId
            ._Nombre = pNombre
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

    Private _Patentes As New List(Of PATENTE)
    Public Property Patentes() As List(Of PATENTE)
        Get
            Return _Patentes
        End Get
        Set(ByVal value As List(Of PATENTE))
            _Patentes = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.Nombre
    End Function

End Class

