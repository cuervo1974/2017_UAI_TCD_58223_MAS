Public Class MP_PALABRA

    Private _DataSet As New DataSet
    Private _Listado As New List(Of BE.PALABRA)

    Public Sub New()

    End Sub

    Private Sub RellenarTablas()
        Me._DataSet.Reset()
        Servicios_DAL.Comando.RellenarDT("SELECT * FROM Palabra", Me._DataSet.Tables.Add("Palabra"))
        Me._DataSet.Tables("Palabra").DefaultView.Sort = "cadena"
        Me._DataSet.Tables("Palabra").PrimaryKey = {Me._DataSet.Tables("Palabra").Columns("id_palabra")}
    End Sub

    Public Function ConsultarTodos() As List(Of BE.PALABRA)
        Me.RellenarTablas()
        Me.ActualizarListado()
        Return Me._Listado
    End Function

    Private Sub ActualizarListado()
        Me._Listado.Clear()
        For Each DataRowView As DataRowView In Me._DataSet.Tables("Palabra").DefaultView
            Me._Listado.Add(CrearObjeto(DataRowView.Row))
        Next
    End Sub

    Public Shared Function CrearObjeto(pDataRow As DataRow) As BE.PALABRA
        Return New BE.PALABRA(
            pDataRow.Item("id_palabra"),
            pDataRow.Item("cadena")
        )
    End Function

End Class
