<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BotoneraFiltrador = New GUI.BotoneraFiltrador()
        Me.DataGridPrincipal = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BotoneraFiltrador
        '
        Me.BotoneraFiltrador.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotoneraFiltrador.Location = New System.Drawing.Point(0, 0)
        Me.BotoneraFiltrador.Margin = New System.Windows.Forms.Padding(5)
        Me.BotoneraFiltrador.Name = "BotoneraFiltrador"
        Me.BotoneraFiltrador.Size = New System.Drawing.Size(949, 43)
        Me.BotoneraFiltrador.TabIndex = 3
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
        Me.DataGridPrincipal.Location = New System.Drawing.Point(0, 55)
        Me.DataGridPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridPrincipal.MultiSelect = False
        Me.DataGridPrincipal.Name = "DataGridPrincipal"
        Me.DataGridPrincipal.ReadOnly = True
        Me.DataGridPrincipal.RowHeadersVisible = False
        Me.DataGridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPrincipal.Size = New System.Drawing.Size(949, 338)
        Me.DataGridPrincipal.TabIndex = 2
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 404)
        Me.Controls.Add(Me.BotoneraFiltrador)
        Me.Controls.Add(Me.DataGridPrincipal)
        Me.Name = "FormClientes"
        Me.Text = "Clientes"
        CType(Me.DataGridPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BotoneraFiltrador As BotoneraFiltrador
    Friend WithEvents DataGridPrincipal As DataGridView
End Class
