Public MustInherit Class CPatente

    Public MustOverride Sub Mostrar(ByRef pToolStripItemCollection As ToolStripItemCollection)
    Public MustOverride Sub Mostrar(ByRef pTreeNodeCollection As TreeNodeCollection)

    Private _Patente As BE.PATENTE
    Public Property Patente() As BE.PATENTE
        Get
            Return _Patente
        End Get
        Set(ByVal value As BE.PATENTE)
            _Patente = value
        End Set
    End Property

    Public Sub New(pPatente As BE.PATENTE)
        With Me
            .Patente = pPatente
        End With
    End Sub

    Public Shared Sub RellenarCPatentes(pCPatenteMultiple As CPatenteMultiple, pPatentes As List(Of BE.PATENTE), Optional pItemClickHandler As EventHandler = Nothing)
        Dim CPatente As CPatente
        For Each Patente As BE.PATENTE In pPatentes
            If IsNothing(Patente.Hijos) Then
                CPatente = New CPatenteSimple(Patente, pItemClickHandler)
            Else
                CPatente = New CPatenteMultiple(Patente)
                CPatente.RellenarCPatentes(CPatente, Patente.Hijos, pItemClickHandler)
            End If
            pCPatenteMultiple.Opciones.Add(CPatente)
        Next
    End Sub

End Class