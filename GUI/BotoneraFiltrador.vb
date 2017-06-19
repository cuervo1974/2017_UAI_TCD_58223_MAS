Public Class BotoneraFiltrador

    Public Sub AgregarBoton(pLabel As String, pImage As Image, pHandler As EventHandler, Optional pAgregarSeparador As Boolean = True)

        Me.ToolStrip.Items.Add(pLabel, pImage, pHandler).Margin = New Padding(0, 0, 5, 0)

        If (pAgregarSeparador) Then
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
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub
End Class
