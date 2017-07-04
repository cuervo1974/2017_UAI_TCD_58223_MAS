Public Class USUARIO

    Private _Datos As New DAL.MP_USUARIO
    Public Function ConsultarTodos() As List(Of BE.USUARIO)
        Return Me._Datos.ConsultarTodos
    End Function

    Public Sub Guardar(pObj As BE.USUARIO)
        Me._Datos.Guardar(pObj)
    End Sub

    Public Sub Eliminar(pObj As BE.USUARIO)
        Me._Datos.Eliminar(pObj)
    End Sub

    Public Shared Sub Validar(pObj As BE.USUARIO)
        If pObj.NOMBRE = "" Then Throw New Exception("El Usuario debe tener nombre.")
        If pObj.NOMBRE.Length > 50 Then Throw New Exception("El nombre del Usuario es demasiado largo.")
        If pObj.APELLIDO = "" Then Throw New Exception("El Usuario debe tener apellido.")
        If pObj.APELLIDO.Length > 50 Then Throw New Exception("El nombre del Usuario es demasiado largo.")
        If pObj.USERNAME = "" Then Throw New Exception("El Usuario debe tener username.")
        If pObj.USERNAME.Length > 50 Then Throw New Exception("El username del Usuario es demasiado largo.")
        If pObj.ID_usuario = 0 And String.IsNullOrEmpty(pObj.PASSWORD) Then Throw New Exception("El Usuario debe tener una contraseña")
    End Sub

    Public Sub Login(pUsername As String, pPassword As String)
        Dim PasswordEncriptado As String = Seguridad.Hash.Encriptar(pPassword)
        Dim Usuario As BE.USUARIO = _Datos.ConsultarCredenciales(pUsername)
        If IsNothing(Usuario) Then
            Throw New Exception("Usuario inexistente.")
        ElseIf Not Usuario.PASSWORD = PasswordEncriptado Then
            Throw New Exception("Contraseña incorrecta.")
        Else
            Dim UsuarioSingleton As BE.Singleton = BE.Singleton.Instancia
            UsuarioSingleton.USUARIO = Usuario
            EVENTOBITACORA.RegistrarEvento("Ingresó")
        End If
    End Sub

    Public Function Filtrar(pTexto As String) As List(Of BE.USUARIO)
        Return Me._Datos.Filtrar(pTexto)
    End Function

End Class