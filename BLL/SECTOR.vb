Public Class SECTOR

    Private _Datos As New DAL.MP_SECTOR

    Public Function ConsultarTodos() As List(Of BE.SECTOR)
        Return Me._Datos.ConsultarTodos
    End Function

    Public Sub Guardar(pObj As BE.SECTOR)
        Me._Datos.Guardar(pObj)
    End Sub

    Public Sub Eliminar(pObj As BE.SECTOR)
        Me._Datos.Eliminar(pObj)
    End Sub

    Public Shared Sub Validar(pObj As BE.SECTOR)
        If pObj.Nombre = "" Then Throw New Exception("La Sector debe tener nombre.")
        If pObj.Nombre.Length > 50 Then Throw New Exception("El nombre del Sector es demasiado largo.")
        If pObj.Gerencia = "" Then Throw New Exception("El Sector debe pertener a una Gerencia.")
        If pObj.Gerencia.Length > 50 Then Throw New Exception("El nombre de la Gerencia es demasiado larga.")

    End Sub

End Class
