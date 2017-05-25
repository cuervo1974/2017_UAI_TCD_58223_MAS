Public Class IdiomaObservado

    Private _IdiomaViejo As BE.IDIOMA = New BE.IDIOMA(Nothing, "Español", True)
    Private _IdiomaNuevo As BE.IDIOMA = New BE.IDIOMA(Nothing, "Español", True)
    Private _FormulariosObservadores As New List(Of InterfaceObservador)

    Public Sub CambiarIdioma(pIdioma As BE.IDIOMA)
        Me._IdiomaViejo = Me._IdiomaNuevo
        Me._IdiomaNuevo = pIdioma
        Me.Notificar()
        Alertador.ActualizarIdiomas(Me._IdiomaNuevo, Me._IdiomaViejo)
    End Sub

    Public Sub Suscribir(pForm As InterfaceObservador)
        Me._FormulariosObservadores.Add(pForm)
        pForm.Actualizar(Me._IdiomaNuevo, Me._IdiomaViejo)
    End Sub

    Private Sub Notificar()
        For Each Form As InterfaceObservador In Me._FormulariosObservadores
            Form.Actualizar(Me._IdiomaNuevo, Me._IdiomaViejo)
        Next
    End Sub

End Class
