<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEventosBitacora
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
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DateTimeHasta = New System.Windows.Forms.DateTimePicker()
        Me.LabelHasta = New System.Windows.Forms.Label()
        Me.DateTimeDesde = New System.Windows.Forms.DateTimePicker()
        Me.LabelDesde = New System.Windows.Forms.Label()
        Me.LabelEmpleado = New System.Windows.Forms.Label()
        Me.ComboBoxUsuario = New System.Windows.Forms.ComboBox()
        Me.ButtonFiltrar = New System.Windows.Forms.Button()
        Me.DataGridPrincipal = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.DataGridPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.ColumnCount = 7
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel.Controls.Add(Me.DateTimeHasta, 3, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelHasta, 2, 0)
        Me.TableLayoutPanel.Controls.Add(Me.DateTimeDesde, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelDesde, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.LabelEmpleado, 4, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ComboBoxUsuario, 5, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonFiltrar, 6, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 1
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(1425, 37)
        Me.TableLayoutPanel.TabIndex = 10
        '
        'DateTimeHasta
        '
        Me.DateTimeHasta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeHasta.Location = New System.Drawing.Point(381, 6)
        Me.DateTimeHasta.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.DateTimeHasta.Name = "DateTimeHasta"
        Me.DateTimeHasta.Size = New System.Drawing.Size(146, 22)
        Me.DateTimeHasta.TabIndex = 13
        '
        'LabelHasta
        '
        Me.LabelHasta.AutoSize = True
        Me.LabelHasta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelHasta.Location = New System.Drawing.Point(274, 6)
        Me.LabelHasta.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelHasta.Name = "LabelHasta"
        Me.LabelHasta.Size = New System.Drawing.Size(93, 25)
        Me.LabelHasta.TabIndex = 12
        Me.LabelHasta.Text = "Hasta"
        Me.LabelHasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateTimeDesde
        '
        Me.DateTimeDesde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeDesde.Location = New System.Drawing.Point(114, 6)
        Me.DateTimeDesde.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.DateTimeDesde.Name = "DateTimeDesde"
        Me.DateTimeDesde.Size = New System.Drawing.Size(146, 22)
        Me.DateTimeDesde.TabIndex = 8
        '
        'LabelDesde
        '
        Me.LabelDesde.AutoSize = True
        Me.LabelDesde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelDesde.Location = New System.Drawing.Point(7, 6)
        Me.LabelDesde.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelDesde.Name = "LabelDesde"
        Me.LabelDesde.Size = New System.Drawing.Size(93, 25)
        Me.LabelDesde.TabIndex = 7
        Me.LabelDesde.Text = "Desde"
        Me.LabelDesde.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelEmpleado
        '
        Me.LabelEmpleado.AutoSize = True
        Me.LabelEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelEmpleado.Location = New System.Drawing.Point(541, 6)
        Me.LabelEmpleado.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelEmpleado.Name = "LabelEmpleado"
        Me.LabelEmpleado.Size = New System.Drawing.Size(93, 25)
        Me.LabelEmpleado.TabIndex = 14
        Me.LabelEmpleado.Text = "Usuario"
        Me.LabelEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBoxUsuario
        '
        Me.ComboBoxUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxUsuario.FormattingEnabled = True
        Me.ComboBoxUsuario.Location = New System.Drawing.Point(648, 6)
        Me.ComboBoxUsuario.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ComboBoxUsuario.Name = "ComboBoxUsuario"
        Me.ComboBoxUsuario.Size = New System.Drawing.Size(637, 24)
        Me.ComboBoxUsuario.TabIndex = 15
        '
        'ButtonFiltrar
        '
        Me.ButtonFiltrar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonFiltrar.Location = New System.Drawing.Point(1292, 0)
        Me.ButtonFiltrar.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFiltrar.Name = "ButtonFiltrar"
        Me.ButtonFiltrar.Size = New System.Drawing.Size(133, 37)
        Me.ButtonFiltrar.TabIndex = 16
        Me.ButtonFiltrar.Text = "Filtrar"
        Me.ButtonFiltrar.UseVisualStyleBackColor = True
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
        Me.DataGridPrincipal.Location = New System.Drawing.Point(13, 62)
        Me.DataGridPrincipal.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridPrincipal.MultiSelect = False
        Me.DataGridPrincipal.Name = "DataGridPrincipal"
        Me.DataGridPrincipal.ReadOnly = True
        Me.DataGridPrincipal.RowHeadersVisible = False
        Me.DataGridPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPrincipal.Size = New System.Drawing.Size(1425, 309)
        Me.DataGridPrincipal.TabIndex = 9
        '
        'FormEventosBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 384)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.DataGridPrincipal)
        Me.Name = "FormEventosBitacora"
        Me.Text = "Eventos de la Bitacora"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.DataGridPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents DateTimeHasta As DateTimePicker
    Friend WithEvents LabelHasta As Label
    Friend WithEvents DateTimeDesde As DateTimePicker
    Friend WithEvents LabelDesde As Label
    Friend WithEvents LabelEmpleado As Label
    Friend WithEvents ComboBoxUsuario As ComboBox
    Friend WithEvents ButtonFiltrar As Button
    Friend WithEvents DataGridPrincipal As DataGridView
End Class
