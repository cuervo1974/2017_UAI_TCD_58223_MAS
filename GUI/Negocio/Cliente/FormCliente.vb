Public Class FormCliente
    Implements InterfaceObservador

    Private _Obj As BE.Cliente

    Sub New(ByRef pObj As BE.Cliente)
        InitializeComponent()
        Me._Obj = pObj
    End Sub

    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .TextBoxNombre.Text = ._Obj.Nombre
            .TextBoxApellido.Text = ._Obj.Apellido
            .TextBoxInterno.Text = ._Obj.Interno
            .TextBoxSector.Text = ._Obj.Sector
            .TextBoxEmail.Text = ._Obj.Email
            .TextBoxLegajo.Text = ._Obj.Legajo
        End With
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            With Me
                ._Obj.Nombre = .TextBoxNombre.Text
                ._Obj.Apellido = .TextBoxApellido.Text
                ._Obj.Interno = .TextBoxInterno.Text
                ._Obj.Sector = .TextBoxSector.Text
                ._Obj.Email = .TextBoxEmail.Text
                ._Obj.Legajo = .TextBoxLegajo.Text
            End With
            BLL.Cliente.Validar(Me._Obj)
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Alertador.Alertar(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        If Alertador.Alertar("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub Actualizar(pIdiomaNuevo As BE.IDIOMA, pIdiomaViejo As BE.IDIOMA) Implements InterfaceObservador.Actualizar
        ServicioTraduccion.Traducir(Me, pIdiomaNuevo, pIdiomaViejo)
    End Sub
End Class
