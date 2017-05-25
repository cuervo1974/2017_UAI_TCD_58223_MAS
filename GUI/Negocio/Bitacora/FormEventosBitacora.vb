Public Class FormEventosBitacora
    Implements InterfaceObservador

    Private _Logica As New BLL.EVENTOBITACORA
    Private _Obj As BE.EVENTOBITACORA

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RellenarDataGrid(Me._Logica.ConsultarTodos)
        Dim Usuario As New BLL.USUARIO
        Me.ComboBoxUsuario.DataSource = Usuario.ConsultarTodos
    End Sub

    Private Sub RellenarDataGrid(pListado As List(Of BE.EVENTOBITACORA))
        With Me.DataGridPrincipal
            .DataSource = Nothing
            .Columns.Clear()
            .Rows.Clear()
            .DataSource = pListado
            .AutoResizeColumns()
        End With
    End Sub

    Private Sub ButtonFiltrar_Click(sender As Object, e As EventArgs) Handles ButtonFiltrar.Click
        Me.RellenarDataGrid(Me._Logica.Filtrar(Me.DateTimeDesde.Text, Me.DateTimeHasta.Text, Me.ComboBoxUsuario.SelectedValue))
        Me.DataGridPrincipal.AutoResizeColumns()
    End Sub

    Public Sub Actualizar(pIdiomaNuevo As BE.IDIOMA, pIdiomaViejo As BE.IDIOMA) Implements InterfaceObservador.Actualizar
        ServicioTraduccion.Traducir(Me, pIdiomaNuevo, pIdiomaViejo)
    End Sub

End Class