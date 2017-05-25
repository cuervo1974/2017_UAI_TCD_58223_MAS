Public Class EVENTOBITACORA

    Private _Datos As New DAL.MP_EVENTOBITACORA

    Public Function ConsultarTodos() As List(Of BE.EVENTOBITACORA)
        Return Me._Datos.ConsultarTodos
    End Function

    Public Shared Sub RegistrarEvento(pDesc As String)
        Dim EventoBitacora As New BE.EVENTOBITACORA
        With EventoBitacora
                .Fecha = Now
            .Usuario = BE.Singleton.Instancia.USUARIO
            .Desc = pDesc
            End With
        DAL.MP_EVENTOBITACORA.RegistrarEvento(EventoBitacora)
    End Sub

    Public Function Filtrar(pDesde As Date, pHasta As Date, pUsuario As BE.USUARIO) As List(Of BE.EVENTOBITACORA)
        Return Me._Datos.Filtrar(pDesde, pHasta, pUsuario)
    End Function


End Class
