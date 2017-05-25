Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Public Class Comando

    Private con As SqlConnection
    Private transact As SqlTransaction
    Public Shared Sub RellenarDT(ByVal pSelectCommand As String, ByRef pDataTable As DataTable, Optional pSoloEstructura As Boolean = False)
        Dim ObjCommand As New SqlCommand(pSelectCommand, Servicios_DAL.Conexion.GetObjConnection)
        Dim DA As New SqlDataAdapter(ObjCommand)
        If pSoloEstructura Then
            DA.FillSchema(pDataTable, SchemaType.Mapped)
        Else
            DA.Fill(pDataTable)
        End If
    End Sub

    Public Shared Sub ActualizarBase(ByVal pSelectCommand As String, ByRef pDataTable As DataTable)
        Dim DA As New SqlDataAdapter(New SqlCommand(pSelectCommand, Servicios_DAL.Conexion.GetObjConnection))
        Dim CB As New SqlCommandBuilder(DA)
        DA.InsertCommand = CB.GetInsertCommand
        DA.DeleteCommand = CB.GetDeleteCommand
        DA.UpdateCommand = CB.GetUpdateCommand
        DA.Update(pDataTable)
    End Sub

    'Public Shared Function Leer(ByVal pSelectCommand As String, nombresp As String, Optional pDataTable() As SqlParameter = Nothing) As DataTable
    '    Dim DA As New SqlDataAdapter(New SqlCommand(pSelectCommand, Servicios_DAL.Conexion.GetObjConnection))
    '    Dim con As New SqlConnection
    '    Dim tabla As New DataTable
    '    Dim transact As SqlTransaction
    '    DA.SelectCommand.CommandText = nombresp
    '    DA.SelectCommand.CommandType = CommandType.StoredProcedure
    '    DA.SelectCommand.Connection = con

    '    If pDataTable IsNot Nothing Then
    '        DA.SelectCommand.Parameters.AddRange(pDataTable)

    '    End If

    '    If transact IsNot Nothing Then
    '        DA.SelectCommand.Transaction = transact
    '    End If
    '    DA.Fill(tabla)


    '    Return tabla

    'End Function
    'Private Sub abrir()
    '    con = New SqlConnection
    '    con.Open()
    'End Sub

    'Private Sub cerrar()
    '    con.Close()
    '    con = Nothing
    '    GC.Collect()
    'End Sub

    'Public Function leer(nombresp As String, Optional parametros() As SqlParameter = Nothing) As DataTable
    '    Dim tabla As New DataTable
    '    'Dim command As New SqlCommand
    '    abrir()

    '    Dim adaptador As New SqlDataAdapter
    '    adaptador.SelectCommand = New SqlCommand
    '    adaptador.SelectCommand.CommandText = nombresp
    '    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
    '    adaptador.SelectCommand.Connection = con

    '    If parametros IsNot Nothing Then
    '        adaptador.SelectCommand.Parameters.AddRange(parametros)

    '    End If



    '    If transact IsNot Nothing Then
    '        adaptador.SelectCommand.Transaction = transact


    '    End If
    '    adaptador.Fill(tabla)

    '    cerrar()

    '    Return tabla
    'End Function


    'Public Function ESCRIBIR(nombresp As String, parametros() As SqlParameter) As Integer
    '    'la funcion escribir sera integer porque devolveremos el numero de filas afectadas

    '    Dim cmd As New SqlCommand
    '    abrir()
    '    cmd.Connection = Conexion
    '    'instancio una variable con los datos de conexion
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.CommandText = nombresp
    '    cmd.Parameters.AddRange(parametros)

    '    transact = Conexion.BeginTransaction
    '    'inicio transaccion contra la bbdd
    '    cmd.Transaction = transact
    '    'el comando del tipo Transaction va a ser mi transaction

    '    Dim filas_Afectadas As Integer

    '    Try
    '        filas_Afectadas = cmd.ExecuteNonQuery
    '        'el numero de filas afectadas va a ser el numero de filas que ejecuto el comando CMD

    '        transact.Commit()
    '        'confirmo fin de la transaccion

    '        Return filas_Afectadas


    '    Catch
    '        'si hubo algun error mientras ejecutaba la transaccion

    '        filas_Afectadas = -1
    '        transact.Rollback()

    '        Return filas_Afectadas

    '    Finally
    '        cerrar()

    '    End Try


    'End Function
    'Public Function crearparametro(nombre As String, valor As String) As SqlParameter
    '    Dim p As New SqlParameter(nombre, valor)
    '    p.DbType = DbType.String
    '    Return p
    'End Function


    'Public Function crearparametro(nombre As String, valor As Integer) As SqlParameter
    '    Dim p As New SqlParameter(nombre, valor)
    '    'despues especificare el nombre del campo con este valor en el mapper
    '    p.DbType = DbType.Int32
    '    Return p
    'End Function

    'Public Function crearparametro(nombre As String, valor As Date) As SqlParameter
    '    Dim p As New SqlParameter(nombre, valor)
    '    'despues especificare el nombre del campo con este valor en el mapper
    '    p.DbType = DbType.Date
    '    Return p
    'End Function


    'Public Function crearparametro(nombre As String, valor As Single) As SqlParameter
    '    Dim p As New SqlParameter(nombre, valor)
    '    'despues especificare el nombre del campo con este valor en el mapper
    '    p.DbType = DbType.Single
    '    Return p
    'End Function



End Class