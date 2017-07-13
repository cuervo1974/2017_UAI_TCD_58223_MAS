Public Class BotoneraFiltrador

    Implements InterfaceObservador

    Private _Idioma As New BLL.IDIOMA
    Private Shared _IdiomaObservado As New IdiomaObservado

    'Public Sub AgregarBoton(pLabel As String, pImage As Image, pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)

    '    Me.ToolStrip.Items.Add(pLabel, pImage, pHandler).Margin = New Padding(0, 0, 5, 0)

    '    If (pAgregarSeparador) Then
    '        Dim Separator As New ToolStripSeparator
    '        Separator.Margin = New Padding(0, 0, 5, 0)
    '        Me.ToolStrip.Items.Add(Separator)
    '    End If

    'End Sub

    'Public Sub AgregarBotonAgregar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
    '    Me.AgregarBoton("Agregar", My.Resources.Crear, pHandler, pAgregarSeparador)
    'End Sub

    'Public Sub AgregarBotonEditar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
    '    Me.AgregarBoton("Editar", My.Resources.Editar, pHandler, pAgregarSeparador)
    'End Sub

    'Public Sub AgregarBotonEliminar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
    '    Me.AgregarBoton("Eliminar", My.Resources.Eliminar, pHandler, pAgregarSeparador)
    'End Sub

    'Private Sub ButtonLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarFiltro.Click
    '    Me.TextFiltroTexto.Text = ""
    'End Sub

    'Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    'End Sub

    'Public Sub AgregarBoton(pLabel As String, pImage As Image, pHandler As EventHandler, Optional pAgrgarSeparador As Boolean = True)

    '    Me.ToolStrip.Items.Add(pLabel, pImage, pHandler).Margin = New Padding(0, 0, 5, 0)

    '    If (pAgrgarSeparador) Then
    '        Dim Separator As New ToolStripSeparator
    '        Separator.Margin = New Padding(0, 0, 5, 0)
    '        Me.ToolStrip.Items.Add(Separator)
    '    End If

    'End Sub

    'Public Sub AgregarBotonAgregar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
    '    Me.AgregarBoton("Agregar", My.Resources.Crear, pHandler, pAgregarSeparador)
    'End Sub

    'Public Sub AgregarBotonEditar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
    '    Me.AgregarBoton("Editar", My.Resources.Editar, pHandler, pAgregarSeparador)
    'End Sub

    'Public Sub AgregarBotonEliminar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
    '    Me.AgregarBoton("Eliminar", My.Resources.Eliminar, pHandler, pAgregarSeparador)
    'End Sub

    'Private Sub ButtonLimpiarFiltro_Click(sender As Object, e As EventArgs)
    '    Me.TextFiltroTexto.Text = ""
    '    ButtonFiltrar.PerformClick()
    'End Sub

    'Public Sub AgregarManejadorFiltro(pHandler As EventHandler)
    '    AddHandler Me.ButtonFiltrar.Click, pHandler
    'End Sub

    'Public Function GetTextoFiltro() As String
    '    Return Me.TextFiltroTexto.Text
    'End Function

    'Public Sub Actualizar(pIdiomaNuevo As BE.IDIOMA, pIdiomaViejo As BE.IDIOMA) Implements InterfaceObservador.Actualizar
    '    ServicioTraduccion.Traducir(Me, pIdiomaNuevo, pIdiomaViejo)
    'End Sub

    'Private Sub CambiarIdioma(sender As Object, e As ToolStripItemClickedEventArgs)
    '    _IdiomaObservado.CambiarIdioma(DirectCast(DirectCast(e.ClickedItem, ToolStripMenuItem).Tag, BE.IDIOMA))
    'End Sub

    'Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    'End Sub

    Public Sub AgregarBoton(pLabel As String, pImage As Image, pHandler As EventHandler, Optional pAgrgarSeparador As Boolean = True)

        Me.ToolStrip.Items.Add(pLabel, pImage, pHandler).Margin = New Padding(0, 0, 5, 0)

        If (pAgrgarSeparador) Then
            Dim Separator As New ToolStripSeparator
            Separator.Margin = New Padding(0, 0, 5, 0)
            Me.ToolStrip.Items.Add(Separator)
        End If

    End Sub

    Public Sub AgregarBotonAgregar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
        Me.AgregarBoton("Agregar", My.Resources.Crear, pHandler, pAgregarSeparador)
    End Sub

    Public Sub AgregarBotonEditar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
        Me.AgregarBoton("Editar", My.Resources.Editar, pHandler, pAgregarSeparador)
    End Sub

    Public Sub AgregarBotonEliminar(pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)
        Me.AgregarBoton("Eliminar", My.Resources.Eliminar, pHandler, pAgregarSeparador)
    End Sub

    Private Sub ButtonLimpiarFiltro_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarFiltro.Click
        Me.TextFiltroTexto.Text = ""
        ButtonFiltrar.PerformClick()
    End Sub

    Public Sub AgregarManejadorFiltro(pHandler As EventHandler)
        AddHandler Me.ButtonFiltrar.Click, pHandler
    End Sub

    Public Function GetTextoFiltro() As String
        Return Me.TextFiltroTexto.Text
    End Function

    Public Sub Actualizar(pIdiomaNuevo As BE.IDIOMA, pIdiomaViejo As BE.IDIOMA) Implements InterfaceObservador.Actualizar
        ServicioTraduccion.Traducir(Me, pIdiomaNuevo, pIdiomaViejo)
    End Sub

    Private Sub CambiarIdioma(sender As Object, e As ToolStripItemClickedEventArgs)
        _IdiomaObservado.CambiarIdioma(DirectCast(DirectCast(e.ClickedItem, ToolStripMenuItem).Tag, BE.IDIOMA))
    End Sub

End Class
