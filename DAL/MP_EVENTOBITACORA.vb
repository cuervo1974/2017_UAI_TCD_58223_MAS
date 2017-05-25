Public Class MP_EVENTOBITACORA

    Private _DataSet As New DataSet
    Private _Listado As New List(Of BE.EVENTOBITACORA)

    Public Sub New()

        End Sub

        Private Sub RellenarTablas()
            Me._DataSet.Reset()
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM EventoBitacora", Me._DataSet.Tables.Add("EventoBitacora"))
        Me._DataSet.Tables("EventoBitacora").PrimaryKey = {Me._DataSet.Tables("EventoBitacora").Columns("id_evento_bitacora")}
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Usuario", Me._DataSet.Tables.Add("Usuario"))
        Me._DataSet.Tables("Usuario").PrimaryKey = {Me._DataSet.Tables("Usuario").Columns("ID_USUARIO")}
        Me._DataSet.Relations.Add("Usuario", Me._DataSet.Tables("Usuario").Columns("ID?USUARIO"), Me._DataSet.Tables("EventoBitacora").Columns("id_usuario"))
    End Sub

    Public Function ConsultarTodos() As List(Of BE.EVENTOBITACORA)
        Me.RellenarTablas()
        Me._DataSet.Tables("EventoBitacora").DefaultView.Sort = "id_evento_bitacora DESC"
        Me._DataSet.Tables("EventoBitacora").DefaultView.RowFilter = Nothing
        Me.ActualizarListado()
        Return Me._Listado
    End Function

    Private Sub ActualizarListado()
            Me._Listado.Clear()
            For Each DataRowView As DataRowView In Me._DataSet.Tables("EventoBitacora").DefaultView
            Dim EventoBitacora As BE.EVENTOBITACORA = CrearObjeto(DataRowView.Row)
            EventoBitacora.Usuario = MP_USUARIO.CrearObjeto(DataRowView.Row.GetParentRow("Usuario"))
            Me._Listado.Add(EventoBitacora)
            Next
        End Sub

    Public Sub Guardar(pObj As BE.EVENTOBITACORA)
        Dim DataRow = Me._DataSet.Tables("EventoBitacora").Rows.Find(pObj.Id)
        If IsNothing(DataRow) Then
            DataRow = Me._DataSet.Tables("EventoBitacora").NewRow
            RellenarDataRow(DataRow, pObj)
            Me._DataSet.Tables("EventoBitacora").Rows.Add(DataRow)
        Else
            RellenarDataRow(DataRow, pObj)
        End If
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM EventoBitacora", Me._DataSet.Tables("EventoBitacora"))
    End Sub

    Public Shared Function CrearObjeto(pDataRow As DataRow) As BE.EVENTOBITACORA
        Return New BE.EVENTOBITACORA(
            pDataRow.Item("id_evento_bitacora"),
            pDataRow.Item("fecha"),
            pDataRow.Item("descripcion")
        )
    End Function

    Public Shared Sub RellenarDataRow(pDataRow As DataRow, pObj As BE.EVENTOBITACORA)
        With pDataRow
            .Item("id_evento_bitacora") = pObj.Id
            .Item("ID_USUARIO") = pObj.Usuario.ID_usuario
            .Item("fecha") = pObj.Fecha
            .Item("descripcion") = pObj.Desc
        End With
    End Sub

    Public Shared Sub RegistrarEvento(pObj As BE.EVENTOBITACORA)
        Dim DataTableAux As New DataTable
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM EventoBitacora", DataTableAux, True)
        Dim DataRowAux As DataRow = DataTableAux.NewRow
        RellenarDataRow(DataRowAux, pObj)
        DataTableAux.Rows.Add(DataRowAux)
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM EventoBitacora", DataTableAux)
    End Sub

    Public Function Filtrar(pDesde As Date, pHasta As Date, pObj As BE.USUARIO) As List(Of BE.EVENTOBITACORA)
        Me.RellenarTablas()
        Me._DataSet.Tables("EventoBitacora").DefaultView.Sort = "id_evento_bitacora DESC"
        Me._DataSet.Tables("EventoBitacora").DefaultView.RowFilter = String.Format("fecha >= '{0}' AND fecha <= '{1}'", pDesde, pHasta)
        If Not IsNothing(pObj) Then Me._DataSet.Tables("EventoBitacora").DefaultView.RowFilter &= String.Format(" AND id_usuario = {0}", pObj.ID_usuario)
        Me.ActualizarListado()
        Return Me._Listado
    End Function

End Class
