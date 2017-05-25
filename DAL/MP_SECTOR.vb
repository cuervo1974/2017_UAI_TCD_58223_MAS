Public Class MP_SECTOR

    Private _DataSet As New DataSet
    Private _Listado As New List(Of BE.SECTOR)

    Public Sub New()

    End Sub

    Private Sub RellenarTablas()
        Me._DataSet.Reset()
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM SECTOR", Me._DataSet.Tables.Add("SECTOR"))
        Me._DataSet.Tables("SECTOR").PrimaryKey = {Me._DataSet.Tables("SECTOR").Columns("id_SECTOR")}
    End Sub

    Public Function ConsultarTodos() As List(Of BE.SECTOR)
        Me.RellenarTablas()
        Me._DataSet.Tables("SECTOR").DefaultView.Sort = "id_SECTOR DESC"
        Me._DataSet.Tables("SECTOR").DefaultView.RowFilter = Nothing
        Me.ActualizarListado()
        Return Me._Listado
    End Function

    Private Sub ActualizarListado()
        Me._Listado.Clear()
        For Each DataRowView As DataRowView In Me._DataSet.Tables("SECTOR").DefaultView
            Me._Listado.Add(CrearObjeto(DataRowView.Row))
        Next
    End Sub

    Public Sub Guardar(pObj As BE.SECTOR)
        Dim DataRow = Me._DataSet.Tables("SECTOR").Rows.Find(pObj.Id)
        If IsNothing(DataRow) Then
            DataRow = Me._DataSet.Tables("SECTOR").NewRow
            RellenarDataRow(DataRow, pObj)
            Me._DataSet.Tables("SECTOR").Rows.Add(DataRow)
        Else
            RellenarDataRow(DataRow, pObj)
        End If
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM SECTOR", Me._DataSet.Tables("SECTOR"))
    End Sub

    Public Shared Function CrearObjeto(pDataRow As DataRow) As BE.SECTOR
        Return New BE.SECTOR(
            pDataRow.Item("id_sector"),
            pDataRow.Item("nombre"),
            pDataRow.Item("Gerencia")
            )
    End Function

    Public Shared Sub RellenarDataRow(pDataRow As DataRow, pObj As BE.SECTOR)
        With pDataRow
            .Item("id_sucursal") = pObj.Id
            .Item("nombre") = pObj.Nombre
            .Item("Gerencia") = pObj.Gerencia
        End With
    End Sub

    Public Sub Eliminar(pObj As BE.SECTOR)
        Dim DataRow = Me._DataSet.Tables("SECTOR").Rows.Find(pObj.Id)
        DataRow.Delete()
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM SECTOR", Me._DataSet.Tables("SECTOR"))
    End Sub

End Class