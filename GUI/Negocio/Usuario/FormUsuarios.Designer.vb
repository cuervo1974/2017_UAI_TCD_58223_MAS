<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.DataGridPrincipal = New System.Windows.Forms.DataGridView()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ButtonLimpiarFiltro = New System.Windows.Forms.ToolStripButton()
        Me.ButtonFiltrar = New System.Windows.Forms.ToolStripButton()
        Me.TextFiltroTexto = New System.Windows.Forms.ToolStripTextBox()
        Me.ComboFiltroColumnas = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabelFiltrar = New System.Windows.Forms.ToolStripLabel()
        Me.BotoneraFiltrador = New GUI.BotoneraFiltrador()
        CType(Me.DataGridPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridPrincipal
        '
        Me.DataGridPrincipal.AllowUserToAddRows = False
        Me.DataGridPrincipal.AllowUserToDeleteRows = False
        Me.DataGridPrincipal.AllowUserToResizeRows = False
        Me.DataGridPrincipal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPrincipal.Location = New System.Drawing.Point(4, 44)
        Me.DataGridPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridPrincipal.MultiSelect = False
        Me.DataGridPrincipal.Name = "DataGridPrincipal"
        Me.DataGridPrincipal.ReadOnly = True
        Me.DataGridPrincipal.RowHeadersVisible = False
        Me.DataGridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPrincipal.Size = New System.Drawing.Size(941, 326)
        Me.DataGridPrincipal.TabIndex = 3
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonLimpiarFiltro, Me.ButtonFiltrar, Me.TextFiltroTexto, Me.ComboFiltroColumnas, Me.ToolStripLabelFiltrar})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(13, 6, 13, 6)
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(945, 40)
        Me.ToolStrip.TabIndex = 4
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ButtonLimpiarFiltro
        '
        Me.ButtonLimpiarFiltro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ButtonLimpiarFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonLimpiarFiltro.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLimpiarFiltro.Name = "ButtonLimpiarFiltro"
        Me.ButtonLimpiarFiltro.Size = New System.Drawing.Size(114, 28)
        Me.ButtonLimpiarFiltro.Text = "Limpiar Filtro"
        '
        'ButtonFiltrar
        '
        Me.ButtonFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ButtonFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButtonFiltrar.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ButtonFiltrar.Name = "ButtonFiltrar"
        Me.ButtonFiltrar.Size = New System.Drawing.Size(58, 28)
        Me.ButtonFiltrar.Text = "Filtrar"
        '
        'TextFiltroTexto
        '
        Me.TextFiltroTexto.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TextFiltroTexto.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.TextFiltroTexto.Name = "TextFiltroTexto"
        Me.TextFiltroTexto.Size = New System.Drawing.Size(199, 28)
        '
        'ComboFiltroColumnas
        '
        Me.ComboFiltroColumnas.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ComboFiltroColumnas.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ComboFiltroColumnas.Name = "ComboFiltroColumnas"
        Me.ComboFiltroColumnas.Size = New System.Drawing.Size(160, 28)
        Me.ComboFiltroColumnas.Text = "Columnas"
        '
        'ToolStripLabelFiltrar
        '
        Me.ToolStripLabelFiltrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabelFiltrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabelFiltrar.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.ToolStripLabelFiltrar.Name = "ToolStripLabelFiltrar"
        Me.ToolStripLabelFiltrar.Size = New System.Drawing.Size(53, 28)
        Me.ToolStripLabelFiltrar.Text = "Filtrar"
        '
        'BotoneraFiltrador
        '
        Me.BotoneraFiltrador.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotoneraFiltrador.Location = New System.Drawing.Point(0, 0)
        Me.BotoneraFiltrador.Name = "BotoneraFiltrador"
        Me.BotoneraFiltrador.Size = New System.Drawing.Size(984, 35)
        Me.BotoneraFiltrador.TabIndex = 3
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 383)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.DataGridPrincipal)
        Me.Name = "FormUsuarios"
        Me.Text = "Usuarios"
        CType(Me.DataGridPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridPrincipal As DataGridView
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ButtonLimpiarFiltro As ToolStripButton
    Friend WithEvents ButtonFiltrar As ToolStripButton
    Friend WithEvents TextFiltroTexto As ToolStripTextBox
    Friend WithEvents ComboFiltroColumnas As ToolStripComboBox
    Friend WithEvents ToolStripLabelFiltrar As ToolStripLabel
    Friend WithEvents BotoneraFiltrador As GUI.BotoneraFiltrador
End Class
