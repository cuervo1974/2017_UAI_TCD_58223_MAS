Public Class MP_CLIENTE

    Private _DataSet As New DataSet
    Private _Listado As New List(Of BE.CLIENTE)

    Public Sub New()
        Me.RellenarTablas()
    End Sub

    Private Sub RellenarTablas()
        Me._DataSet.Reset()
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Cliente", Me._DataSet.Tables.Add("Cliente"))
        Me._DataSet.Tables("Cliente").PrimaryKey = {Me._DataSet.Tables("Cliente").Columns("id_cliente")}
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM DigitoVerificadorVertical WHERE tabla = 'Cliente'", Me._DataSet.Tables.Add("DigitoVerificadorVertical"))
        Me._DataSet.Tables("DigitoVerificadorVertical").PrimaryKey = {Me._DataSet.Tables("DigitoVerificadorVertical").Columns("tabla")}
    End Sub

    Public Function ConsultarTodos() As List(Of BE.CLIENTE)
        Me.RellenarTablas()
        Me._DataSet.Tables("Cliente").DefaultView.Sort = "id_cliente DESC"
        Me._DataSet.Tables("Cliente").DefaultView.RowFilter = Nothing
        Me.ActualizarListado()
        Return Me._Listado
    End Function

    Private Sub ActualizarListado()
        Me._Listado.Clear()
        For Each DataRowView As DataRowView In Me._DataSet.Tables("Cliente").DefaultView
            Me._Listado.Add(CrearObjeto(DataRowView.Row))
        Next
        Me.VerificarDV()
    End Sub

    Public Sub Guardar(pObj As BE.CLIENTE)
        Dim DataRow = Me._DataSet.Tables("Cliente").Rows.Find(pObj.Id)
        If IsNothing(DataRow) Then
            DataRow = Me._DataSet.Tables("Cliente").NewRow
            RellenarDataRow(DataRow, pObj)
            Me._DataSet.Tables("Cliente").Rows.Add(DataRow)
        Else
            RellenarDataRow(DataRow, pObj)
        End If
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM Cliente", Me._DataSet.Tables("Cliente"))
        If pObj.Id = 0 Then pObj.Id = Me.GetUltimoId()
        Me.GuardarDVHorizontal(pObj)
        Me.GuardarDVVertical()
        Me.RellenarTablas()
    End Sub

    Private Function GetUltimoId() As Integer
        Dim DataTableAux As New DataTable
        Servicios_DAL.Comando.RellenarDT("SELECT TOP 1 * FROM Cliente ORDER BY id_cliente DESC", DataTableAux)
        Dim UltimoCliente As BE.CLIENTE = CrearObjeto(DataTableAux.Rows(0))
        Return UltimoCliente.Id
    End Function

    Public Shared Function CrearObjeto(pDataRow As DataRow) As BE.CLIENTE
        Return New BE.CLIENTE(
            pDataRow.Item("id_cliente"),
            pDataRow.Item("nombre"),
            pDataRow.Item("apellido"),
            pDataRow.Item("telefono"),
            pDataRow.Item("celular"),
            pDataRow.Item("email"),
            pDataRow.Item("cuit")
        )
    End Function

    Public Shared Sub RellenarDataRow(pDataRow As DataRow, pObj As BE.CLIENTE)
        With pDataRow
            .Item("id_cliente") = pObj.Id
            .Item("nombre") = pObj.Nombre
            .Item("apellido") = pObj.Apellido
            .Item("interno") = pObj.Interno
            .Item("sector") = pObj.Sector
            .Item("email") = pObj.Email
            .Item("legajo") = pObj.Legajo
        End With
    End Sub

    Public Sub Eliminar(pObj As BE.CLIENTE)
        Dim DataRow = Me._DataSet.Tables("Cliente").Rows.Find(pObj.Id)
        DataRow.Delete()
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM Cliente", Me._DataSet.Tables("Cliente"))
        Me.GuardarDVVertical()
    End Sub

    Private Sub VerificarDV()
        For Each DataRow As DataRow In Me._DataSet.Tables("Cliente").Rows
            If Not DataRow.Item("digito_verificador") = Seguridad.DigitoVerificador.CalcularDV(DataRowHelper.DataRow2ArrayList(DataRow)) Then Throw New Exception("Error en el Digito Verificador")
        Next
        If Not Me._DataSet.Tables("DigitoVerificadorVertical").Rows(0).Item("digito") = Seguridad.DigitoVerificador.CalcularDV(Me._DataSet.Tables("Cliente").Rows) Then Throw New Exception("Error en el Digito Verificador")
    End Sub

    Private Sub GuardarDVVertical()
        Dim DataTableAux As New DataTable
        Servicios_DAL.Comando.RellenarDT("SELECT digito_verificador FROM Cliente", DataTableAux)
        Me._DataSet.Tables("DigitoVerificadorVertical").Rows(0).Item("digito") = Seguridad.DigitoVerificador.CalcularDV(DataTableAux.Rows)
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM DigitoVerificadorVertical", Me._DataSet.Tables("DigitoVerificadorVertical"))
    End Sub

    Private Sub GuardarDVHorizontal(pObj As BE.CLIENTE)
        Dim DataTableAux As New DataTable
        Servicios_DAL.Comando.RellenarDT(String.Format("SELECT * FROM Cliente WHERE id_cliente = {0}", pObj.Id), DataTableAux)
        Dim DataRowAux As DataRow = DataTableAux.Rows(0)
        DataRowAux.Item("digito_verificador") = Seguridad.DigitoVerificador.CalcularDV(DataRowHelper.DataRow2ArrayList(DataRowAux))
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM Cliente", DataTableAux)
    End Sub

    Public Function Filtrar(pTexto As String) As List(Of BE.CLIENTE)
        Me.RellenarTablas()
        Me._DataSet.Tables("Cliente").DefaultView.Sort = "id_cliente DESC"
        Me._DataSet.Tables("Cliente").DefaultView.RowFilter = String.Format("nombre LIKE '%{0}%' OR apellido LIKE '%{1}%'", pTexto, pTexto)
        Me.ActualizarListado()
        Return Me._Listado
    End Function

End Class
