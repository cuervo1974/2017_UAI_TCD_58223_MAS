Public Class IDIOMA

    Private _Datos As New DAL.MP_IDIOMA

    Public Function ConsultarTodos() As List(Of BE.IDIOMA)
        Return Me._Datos.ConsultarTodos
    End Function

    Public Sub Guardar(pObj As BE.IDIOMA)
        Me._Datos.Guardar(pObj)
    End Sub

    Public Sub Eliminar(pObj As BE.IDIOMA)
        Me._Datos.Eliminar(pObj)
    End Sub

    Public Shared Sub Validar(pObj As BE.IDIOMA)
        If pObj.Nombre = "" Then Throw New Exception("El Idioma debe tener nombre.")
        If pObj.Nombre.Length > 50 Then Throw New Exception("El nombre del Idioma es demasiado largo.")
    End Sub

    Public Function ConsultarPalabrasOriginales() As List(Of BE.PALABRA)
        Dim _PalabraDatos As New DAL.MP_Palabra
        Return _PalabraDatos.ConsultarTodos
    End Function

End Class
