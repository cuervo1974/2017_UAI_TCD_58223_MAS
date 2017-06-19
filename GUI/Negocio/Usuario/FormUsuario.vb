Public Class FormUsuario
    Implements InterfaceObservador

    Private _Obj As BE.USUARIO
    Private _FamiliaLogica As New BLL.FAMILIA
    Private _SectorLogica As New BLL.SECTOR

    Sub New(ByRef pObj As BE.USUARIO)
        InitializeComponent()
        Me._Obj = pObj
    End Sub

    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.ComboBoxFamilia.DataSource = Me._FamiliaLogica.ConsultarTodos()
        Me.ComboBoxSector.DataSource = Me._SectorLogica.ConsultarTodos()
        With Me
                .TextBoxNombre.Text = ._Obj.Nombre
                .TextBoxApellido.Text = ._Obj.Apellido
                .TextBoxUsuario.Text = ._Obj.Username
            End With
            If Not Me._Obj.Familia Is Nothing Then Me.ComboBoxFamilia.Text = Me._Obj.Familia.ToString
        If Not Me._Obj.SECTOR Is Nothing Then Me.ComboBoxSector.Text = Me._Obj.SECTOR.ToString
        Me.LabelLeyendaPassword.Visible = IIf(Me._Obj.ID_usuario > 0, True, False)
    End Sub

        Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
            Try
                With Me
                    ._Obj.Nombre = .TextBoxNombre.Text
                    ._Obj.Apellido = .TextBoxApellido.Text
                    ._Obj.Username = .TextBoxUsuario.Text
                    ._Obj.Password = .TextBoxPassword.Text
                    ._Obj.Familia = .ComboBoxFamilia.SelectedValue
                ._Obj.SECTOR = .ComboBoxSector.SelectedValue
            End With
            BLL.USUARIO.Validar(Me._Obj)
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