Public Class FormMain
    Implements InterfaceObservador

    Private _Familia As New BLL.FAMILIA
    Private _Idioma As New BLL.IDIOMA
    Private _CPatentes As New CPatenteMultiple(Nothing)
    Private Shared _IdiomaObservado As New IdiomaObservado

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AgregarUsuarioTitulo()
        Me.AgregarPatentes()
        Me.AgregarBotonSalir()
        Me.AgregarIdiomas()
        _IdiomaObservado.Suscribir(Me)
    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        BLL.EVENTOBITACORA.RegistrarEvento("Salió")
    End Sub

    Private Sub AgregarUsuarioTitulo()
        Me.Text = String.Format("{0} - [{1}]", Me.Text, BE.Singleton.Instancia.USUARIO)
    End Sub

    Private Sub AgregarPatentes()
        CPatente.RellenarCPatentes(Me._CPatentes, Me._Familia.ConsultarPatentes(BE.Singleton.Instancia.USUARIO.FAMILIA), AddressOf AbrirForm)
        Me._CPatentes.Mostrar(Me.MenuStrip.Items)
    End Sub

    Private Sub AgregarIdiomas()
        Dim IdiomaMenuItem As New ToolStripMenuItem
        IdiomaMenuItem.Name = "CambiarIdioma"
        IdiomaMenuItem.Text = "Cambiar Idioma"
        IdiomaMenuItem.Image = My.Resources.Configuracion
        IdiomaMenuItem.Alignment = ToolStripItemAlignment.Right
        IdiomaMenuItem.DropDownDirection = ToolStripDropDownDirection.BelowLeft
        For Each Idioma As BE.IDIOMA In Me._Idioma.ConsultarTodos
            Dim NuevoIdioma As New ToolStripMenuItem(Idioma.ToString)
            NuevoIdioma.Tag = Idioma
            IdiomaMenuItem.DropDownItems.Add(NuevoIdioma)
        Next
        AddHandler IdiomaMenuItem.DropDownItemClicked, AddressOf Me.CambiarIdioma
        Me.MenuStrip.Items.Add(IdiomaMenuItem)
    End Sub

    Private Sub AgregarBotonSalir()
        Dim SalirMenuItem As New ToolStripMenuItem
        SalirMenuItem.Text = "Salir"
        SalirMenuItem.Image = My.Resources.Apagar
        SalirMenuItem.Alignment = ToolStripItemAlignment.Right
        AddHandler SalirMenuItem.Click, AddressOf Me.Salir
        Me.MenuStrip.Items.Add(SalirMenuItem)
    End Sub

    Private Sub Salir()
        Me.Close()
    End Sub

    Private Sub AbrirForm(sender As Object, e As EventArgs)
        Dim FormularioNombre = DirectCast(sender.Tag, BE.PATENTE).Formulario
        If FormularioNombre = "" Then Exit Sub
        Try
            Dim Form As Form = Activator.CreateInstance(Type.GetType(String.Format("{0}.{1}", "GUI", FormularioNombre)))
            With Form
                .MdiParent = Me
                .Show()
            End With
            FormMain.RegistrarForm(Form)
        Catch ex As Exception
            Alertador.Alertar(ex.Message)
        End Try
    End Sub

    Public Shared Sub RegistrarForm(pForm As Form)
        If TypeOf (pForm) Is InterfaceObservador Then _IdiomaObservado.Suscribir(pForm)
    End Sub

    Public Sub Actualizar(pIdiomaNuevo As BE.IDIOMA, pIdiomaViejo As BE.IDIOMA) Implements InterfaceObservador.Actualizar
        ServicioTraduccion.Traducir(Me, pIdiomaNuevo, pIdiomaViejo)
    End Sub

    Private Sub CambiarIdioma(sender As Object, e As ToolStripItemClickedEventArgs)
        _IdiomaObservado.CambiarIdioma(DirectCast(DirectCast(e.ClickedItem, ToolStripMenuItem).Tag, BE.IDIOMA))
    End Sub

    Private Sub CERRARCESIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class
