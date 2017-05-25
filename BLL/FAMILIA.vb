Public Class FAMILIA

    Private _Datos As New DAL.MP_FAMILIA

    Public Function ConsultarTodos() As List(Of BE.FAMILIA)
        Return Me._Datos.ConsultarTodos
    End Function

    Public Sub Guardar(pObj As BE.FAMILIA)
        Me._Datos.Guardar(pObj)
    End Sub

    Public Sub Eliminar(pObj As BE.FAMILIA)
        Me._Datos.Eliminar(pObj)
    End Sub

    Public Shared Sub Validar(pObj As BE.FAMILIA)
        If pObj.Nombre = "" Then Throw New Exception("La Familia debe tener nombre.")
        If pObj.Nombre.Length > 50 Then Throw New Exception("El nombre de la Familia es demasiado largo.")
    End Sub

    Private Function TieneAcceso(pObj As BE.FAMILIA, pPatente As BE.PATENTE) As Boolean
        For Each Patente As BE.PATENTE In pObj.Patentes
            If Patente.Id = pPatente.Id Then Return True
        Next
        Return False
    End Function

    Public Function ConsultarPatentes(pObj As BE.FAMILIA) As List(Of BE.PATENTE)
        Dim PatenteLogica As New BLL.PATENTE
        Dim Patentes As List(Of BE.PATENTE) = PatenteLogica.ConsultarTodos
        Dim PatentesAux As New List(Of BE.PATENTE)
        For Each Patente As BE.PATENTE In Patentes
            If TieneAcceso(pObj, Patente) Then
                PatentesAux.Add(Me.ConsultarPatente(pObj, Patente))
            End If
        Next
        Return PatentesAux
    End Function

    Private Function ConsultarPatente(pObj As BE.FAMILIA, pPatente As BE.PATENTE) As BE.PATENTE
        Dim PatentesAux As New List(Of BE.PATENTE)
        If Not IsNothing(pPatente.Hijos) Then
            For Each Patente As BE.PATENTE In pPatente.Hijos
                If TieneAcceso(pObj, Patente) Then
                    PatentesAux.Add(Me.ConsultarPatente(pObj, Patente))
                End If
            Next
            pPatente.Hijos = PatentesAux
        End If
        Return pPatente
    End Function

End Class
