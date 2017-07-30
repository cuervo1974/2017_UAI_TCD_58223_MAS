Public Class CLIENTE

    Private _Datos As New DAL.MP_Cliente

    Public Function ConsultarTodos() As List(Of BE.Cliente)
        Return Me._Datos.ConsultarTodos
    End Function

    Public Sub Guardar(pObj As BE.Cliente)
        Me._Datos.Guardar(pObj)
        EVENTOBITACORA.RegistrarEvento(String.Format("Guardó el Cliente #{0}", pObj.Id))
    End Sub

    Public Sub Eliminar(pObj As BE.Cliente)
        Me._Datos.Eliminar(pObj)
        EVENTOBITACORA.RegistrarEvento(String.Format("Eliminó el Cliente #{0}", pObj.Id))
    End Sub

    Public Shared Sub Validar(pObj As BE.Cliente)
        If pObj.Nombre = "" Then Throw New Exception("El Cliente debe tener nombre.")
        If pObj.Nombre.Length > 50 Then Throw New Exception("El nombre del Cliente es demasiado largo.")
        If pObj.Apellido = "" Then Throw New Exception("El Cliente debe tener apellido.")
        If pObj.Apellido.Length > 50 Then Throw New Exception("El nombre del Cliente es demasiado largo.")
        If pObj.Interno.Length > 50 Then Throw New Exception("El Interno del Cliente es demasiado largo.")
        If pObj.Sector.Length > 50 Then Throw New Exception("El Sector del Cliente es demasiado largo.")
        If pObj.Email.Length > 50 Then Throw New Exception("El e-mail del Cliente es demasiado largo.")
        If pObj.Email.Length > 0 And Not ServicioValidacion.IsEmail(pObj.Email) Then Throw New Exception("El e-mail es inválido.")
        If pObj.Legajo.Length > 0 And Not ServicioValidacion.IsLegajo(pObj.Legajo) Then Throw New Exception("El Legajo es inválido. Formato:####")
    End Sub

    Public Function Filtrar(pTexto As String) As List(Of BE.Cliente)
        Return Me._Datos.Filtrar(pTexto)
    End Function

End Class

