<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BotoneraFiltrador
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ButtonLimpiarFiltro = New System.Windows.Forms.ToolStripButton()
        Me.ButtonFiltrar = New System.Windows.Forms.ToolStripButton()
        Me.TextFiltroTexto = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabelFiltrar = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonLimpiarFiltro, Me.ButtonFiltrar, Me.TextFiltroTexto, Me.ToolStripLabelFiltrar})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(13, 6, 13, 6)
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(1401, 58)
        Me.ToolStrip.TabIndex = 3
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ButtonLimpiarFiltro
        '
        Me.ButtonLimpiarFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ButtonLimpiarFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonLimpiarFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLimpiarFiltro.Name = "ButtonLimpiarFiltro"
        Me.ButtonLimpiarFiltro.Size = New System.Drawing.Size(114, 46)
        Me.ButtonLimpiarFiltro.Text = "Limpiar Filtro"
        '
        'ButtonFiltrar
        '
        Me.ButtonFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ButtonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonFiltrar.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ButtonFiltrar.Name = "ButtonFiltrar"
        Me.ButtonFiltrar.Size = New System.Drawing.Size(58, 46)
        Me.ButtonFiltrar.Text = "Filtrar"
        '
        'TextFiltroTexto
        '
        Me.TextFiltroTexto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TextFiltroTexto.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.TextFiltroTexto.Name = "TextFiltroTexto"
        Me.TextFiltroTexto.Size = New System.Drawing.Size(199, 46)
        '
        'ToolStripLabelFiltrar
        '
        Me.ToolStripLabelFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabelFiltrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabelFiltrar.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ToolStripLabelFiltrar.Name = "ToolStripLabelFiltrar"
        Me.ToolStripLabelFiltrar.Size = New System.Drawing.Size(60, 46)
        Me.ToolStripLabelFiltrar.Text = "Buscar"
        '
        'BotoneraFiltrador
        '
        Me.Controls.Add(Me.ToolStrip)
        Me.Name = "BotoneraFiltrador"
        Me.Size = New System.Drawing.Size(1401, 58)
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ButtonLimpiarFiltro As ToolStripButton
    Friend WithEvents ButtonFiltrar As ToolStripButton
    Friend WithEvents TextFiltroTexto As ToolStripTextBox
    Friend WithEvents ToolStripLabelFiltrar As ToolStripLabel
End Class
