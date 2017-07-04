Public Class FormUsuarios
    Implements InterfaceObservador

    Private _Logica As BLL.USUARIO = New BLL.USUARIO
    Private _Obj As BE.USUARIO

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            '_Logica = New BLL.USUARIO
            Me.RellenarDataGrid(Me._Logica.ConsultarTodos)
        Catch ex As Exception
            Alertador.Alertar(ex.Message)
        End Try
    End Sub

    Private Sub RellenarDataGrid(pListado As List(Of BE.USUARIO))
        With Me.DataGridPrincipal
            .DataSource = Nothing
            .Columns.Clear()
            .Rows.Clear()
            .DataSource = pListado
            .AutoResizeColumns()
        End With
    End Sub

    Private Sub BotoneraFiltrador_Load(sender As Object, e As EventArgs) Handles BotoneraFiltrador.Load
        With Me.BotoneraFiltrador
            .AgregarBotonAgregar(AddressOf Agregar)
            .AgregarBotonEditar(AddressOf Editar)
            .AgregarBotonEliminar(AddressOf Eliminar, False)
            .AgregarManejadorFiltro(AddressOf Me.Filtrar)
        End With
    End Sub

    Private Sub Filtrar()
        Try
            Me.RellenarDataGrid(Me._Logica.Filtrar(Me.BotoneraFiltrador.GetTextoFiltro))
        Catch ex As Exception
            Alertador.Alertar(ex.Message)
        End Try
    End Sub
    Private Sub GetObjSeleccionado()
        Me._Obj = Me.DataGridPrincipal.Rows(Me.DataGridPrincipal.SelectedCells(0).RowIndex).DataBoundItem
        If IsNothing(Me._Obj) Then Throw New Exception("No se ha seleccionado ningún Usuario.")
    End Sub

    Private Sub AbrirDialogo()
        Dim Dialogo As New FormUsuario(Me._Obj)
        With Dialogo
            .TopMost = True
            .Show()
        End With
        FormMain.RegistrarForm(Dialogo)
        AddHandler Dialogo.FormClosed, AddressOf Me.Dialog_FormClosed
    End Sub

    Private Sub Agregar()
        Me._Obj = New BE.USUARIO
        Me.AbrirDialogo()
    End Sub

    Private Sub Editar()
        Try
            Me.GetObjSeleccionado()
            Me.AbrirDialogo()
        Catch ex As Exception
            Alertador.Alertar(ex.Message)
        End Try
    End Sub

    Private Sub Eliminar()
        If Not Alertador.Alertar("¿Está seguro que desea eliminar el Empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then Exit Sub
        Try
            Me.GetObjSeleccionado()
            Me._Logica.Eliminar(Me._Obj)
        Catch ex As Exception
            Alertador.Alertar(ex.Message)
        End Try
        Me.RellenarDataGrid(Me._Logica.ConsultarTodos)
    End Sub

    Private Sub Dialog_FormClosed(sender As Object, e As FormClosedEventArgs)
        If DirectCast(sender, Form).DialogResult = Windows.Forms.DialogResult.OK Then
            Try
                Me._Logica.Guardar(Me._Obj)
            Catch ex As Exception
                Alertador.Alertar(ex.Message)
            End Try
            Me.RellenarDataGrid(Me._Logica.ConsultarTodos)
        End If
    End Sub

    Public Sub Actualizar(pIdiomaNuevo As BE.IDIOMA, pIdiomaViejo As BE.IDIOMA) Implements InterfaceObservador.Actualizar
        ServicioTraduccion.Traducir(Me, pIdiomaNuevo, pIdiomaViejo)
    End Sub
End Class