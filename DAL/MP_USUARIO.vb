Public Class MP_USUARIO

    Private _DataSet As New DataSet
    Private _Listado As New List(Of BE.USUARIO)

    Public Sub New()

    End Sub

    Private Sub RellenarTablas()
        Me._DataSet.Reset()
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Usuario", Me._DataSet.Tables.Add("Usuario"))
        Me._DataSet.Tables("Usuario").PrimaryKey = {Me._DataSet.Tables("Usuario").Columns("id_Usuario")}
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Familia", Me._DataSet.Tables.Add("Familia"))
        Me._DataSet.Tables("Familia").PrimaryKey = {Me._DataSet.Tables("Familia").Columns("id_familia")}
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM FamiliaPatente", Me._DataSet.Tables.Add("FamiliaPatente"))
        Me._DataSet.Tables("FamiliaPatente").PrimaryKey = {Me._DataSet.Tables("FamiliaPatente").Columns("id_familia"), Me._DataSet.Tables("FamiliaPatente").Columns("id_patente")}
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Patente", Me._DataSet.Tables.Add("Patente"))
        Me._DataSet.Tables("Patente").PrimaryKey = {Me._DataSet.Tables("Patente").Columns("id_patente")}
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Sector", Me._DataSet.Tables.Add("Sector"))
        Me._DataSet.Tables("Sector").PrimaryKey = {Me._DataSet.Tables("Sector").Columns("id_sector")}
        Me._DataSet.Relations.Add("Familia", Me._DataSet.Tables("Familia").Columns("id_familia"), Me._DataSet.Tables("Usuario").Columns("id_familia"))
        Me._DataSet.Relations.Add("FamiliaPatente", Me._DataSet.Tables("Familia").Columns("id_familia"), Me._DataSet.Tables("FamiliaPatente").Columns("id_familia"))
        Me._DataSet.Relations.Add("Patente", Me._DataSet.Tables("Patente").Columns("id_patente"), Me._DataSet.Tables("FamiliaPatente").Columns("id_patente"))
        Me._DataSet.Relations.Add("Sector", Me._DataSet.Tables("Sector").Columns("id_sector"), Me._DataSet.Tables("Usuario").Columns("id_sector"))
    End Sub

    Public Function ConsultarTodos() As List(Of BE.USUARIO)
        Me.RellenarTablas()
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Usuario", Me._DataSet.Tables("Usuario"))
        Me._DataSet.Tables("Usuario").DefaultView.RowFilter = Nothing
        Me.ActualizarListado()
        Return Me._Listado
    End Function

    Private Sub ActualizarListado()
        Me._Listado.Clear()
        For Each DataRowView As DataRowView In Me._DataSet.Tables("Usuario").DefaultView
            Dim Usuario As BE.USUARIO = CrearObjeto(DataRowView.Row)
            Dim Familia As BE.FAMILIA = MP_FAMILIA.CrearObjeto(DataRowView.Row.GetParentRow("Familia"))
            Familia.Patentes = New List(Of BE.PATENTE)
            For Each DataRowFamiliaPatente As DataRow In DataRowView.Row.GetParentRow("Familia").GetChildRows("FamiliaPatente")
                Familia.Patentes.Add(MP_PATENTE.CrearObjeto(DataRowFamiliaPatente.GetParentRow("Patente")))
            Next
            Usuario.FAMILIA = Familia
            Dim DataRowSector = DataRowView.Row.GetParentRow("Sector")
            If Not (IsNothing(DataRowSector)) Then Usuario.SECTOR = MP_SECTOR.CrearObjeto(DataRowSector)
            Me._Listado.Add(Usuario)
        Next
    End Sub

    Public Sub Guardar(pObj As BE.USUARIO)
        Dim DataRow = Me._DataSet.Tables("USUARIO").Rows.Find(pObj.ID_usuario)
        If IsNothing(DataRow) Then
            DataRow = Me._DataSet.Tables("USUARIO").NewRow
            RellenarDataRow(DataRow, pObj)
            Me._DataSet.Tables("USUARIO").Rows.Add(DataRow)
        Else
            RellenarDataRow(DataRow, pObj)
        End If
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM USUARIO", Me._DataSet.Tables("USUARIO"))
    End Sub

    Public Shared Function CrearObjeto(pDataRow As DataRow) As BE.USUARIO
        Return New BE.USUARIO(
            pDataRow.Item("id_usuario"),
            pDataRow.Item("nombre"),
            pDataRow.Item("apellido"),
            pDataRow.Item("username"),
            pDataRow.Item("password")
        )
    End Function

    Public Shared Sub RellenarDataRow(pDataRow As DataRow, pObj As BE.USUARIO)
        With pDataRow
            .Item("id_usuario") = pObj.ID_usuario
            .Item("id_familia") = pObj.FAMILIA.Id
            .Item("id_sector") = pObj.SECTOR.Id
            .Item("nombre") = pObj.NOMBRE
            .Item("apellido") = pObj.APELLIDO
            .Item("username") = pObj.USERNAME
        End With
        If pObj.PASSWORD = "" Then
            pDataRow.Item("password") = GetPasswordViejo(pObj)
        Else
            pDataRow.Item("password") = Seguridad.Hash.Encriptar(pObj.PASSWORD)
        End If
    End Sub

    Private Shared Function GetPasswordViejo(pObj As BE.USUARIO)
        Dim DataTableAux As New DataTable
        Servicios_DAL.Comando.RellenarDT(String.Format("SELECT password FROM USUARIO WHERE id_usuario = {0}", pObj.ID_usuario), DataTableAux)
        Return DataTableAux.Rows(0).Item("password")
    End Function

    Public Sub Eliminar(pObj As BE.USUARIO)
        Dim DataRow = Me._DataSet.Tables("Usuario").Rows.Find(pObj.ID_usuario)
        DataRow.Delete()
        Servicios_DAL.Comando.ActualizarBase("SELECT * FROM USUARIO", Me._DataSet.Tables("USUARIO"))
    End Sub

    Public Function ConsultarCredenciales(pUsername As String) As BE.USUARIO
        Me.RellenarTablas()
        Me._DataSet.Tables("USUARIO").DefaultView.RowFilter = String.Format("Username = '{0}'", pUsername)
        Me.ActualizarListado()
        If Me._Listado.Count > 0 Then
            Return DirectCast(Me._Listado.Item(0), BE.USUARIO)
        Else
            Return Nothing
        End If
    End Function

End Class