Public Class PATENTE

    Private _Datos As New DAL.MP_PATENTE

    Public Function ConsultarTodos() As List(Of BE.PATENTE)
        Return Me._Datos.ConsultarTodos
    End Function

End Class