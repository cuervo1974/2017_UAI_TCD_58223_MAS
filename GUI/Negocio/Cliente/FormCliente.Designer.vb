<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
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
        Me.TextBoxLegajo = New System.Windows.Forms.TextBox()
        Me.LabelCUIT = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxSector = New System.Windows.Forms.TextBox()
        Me.LabelCelular = New System.Windows.Forms.Label()
        Me.TextBoxInterno = New System.Windows.Forms.TextBox()
        Me.Interno = New System.Windows.Forms.Label()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxLegajo, 1, 5)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCUIT, 0, 5)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxEmail, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.LabelEmail, 0, 4)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxSector, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelCelular, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxInterno, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.Interno, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxApellido, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelApellido, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelNombre, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxNombre, 1, 0)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(13, 13)
        Me.TableLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(447, 225)
        Me.TableLayoutPanel.TabIndex = 5
        '
        'TextBoxLegajo
        '
        Me.TextBoxLegajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxLegajo.Location = New System.Drawing.Point(118, 191)
        Me.TextBoxLegajo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxLegajo.Name = "TextBoxLegajo"
        Me.TextBoxLegajo.Size = New System.Drawing.Size(322, 22)
        Me.TextBoxLegajo.TabIndex = 11
        '
        'LabelCUIT
        '
        Me.LabelCUIT.AutoSize = True
        Me.LabelCUIT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCUIT.Location = New System.Drawing.Point(0, 185)
        Me.LabelCUIT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCUIT.Name = "LabelCUIT"
        Me.LabelCUIT.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelCUIT.Size = New System.Drawing.Size(111, 40)
        Me.LabelCUIT.TabIndex = 10
        Me.LabelCUIT.Text = "Legajo"
        Me.LabelCUIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxEmail.Location = New System.Drawing.Point(118, 154)
        Me.TextBoxEmail.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(322, 22)
        Me.TextBoxEmail.TabIndex = 9
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelEmail.Location = New System.Drawing.Point(0, 148)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelEmail.Size = New System.Drawing.Size(111, 37)
        Me.LabelEmail.TabIndex = 8
        Me.LabelEmail.Text = "E-Mail"
        Me.LabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxSector
        '
        Me.TextBoxSector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSector.Location = New System.Drawing.Point(118, 117)
        Me.TextBoxSector.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxSector.Name = "TextBoxSector"
        Me.TextBoxSector.Size = New System.Drawing.Size(322, 22)
        Me.TextBoxSector.TabIndex = 7
        '
        'LabelCelular
        '
        Me.LabelCelular.AutoSize = True
        Me.LabelCelular.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelCelular.Location = New System.Drawing.Point(0, 111)
        Me.LabelCelular.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelCelular.Name = "LabelCelular"
        Me.LabelCelular.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelCelular.Size = New System.Drawing.Size(111, 37)
        Me.LabelCelular.TabIndex = 6
        Me.LabelCelular.Text = "Sector"
        Me.LabelCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxInterno
        '
        Me.TextBoxInterno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxInterno.Location = New System.Drawing.Point(118, 80)
        Me.TextBoxInterno.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxInterno.Name = "TextBoxInterno"
        Me.TextBoxInterno.Size = New System.Drawing.Size(322, 22)
        Me.TextBoxInterno.TabIndex = 5
        '
        'Interno
        '
        Me.Interno.AutoSize = True
        Me.Interno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Interno.Location = New System.Drawing.Point(0, 74)
        Me.Interno.Margin = New System.Windows.Forms.Padding(0)
        Me.Interno.Name = "Interno"
        Me.Interno.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Interno.Size = New System.Drawing.Size(111, 37)
        Me.Interno.TabIndex = 4
        Me.Interno.Text = "Interno"
        Me.Interno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxApellido.Location = New System.Drawing.Point(118, 43)
        Me.TextBoxApellido.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(322, 22)
        Me.TextBoxApellido.TabIndex = 3
        '
        'LabelApellido
        '
        Me.LabelApellido.AutoSize = True
        Me.LabelApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelApellido.Location = New System.Drawing.Point(0, 37)
        Me.LabelApellido.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelApellido.Name = "LabelApellido"
        Me.LabelApellido.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelApellido.Size = New System.Drawing.Size(111, 37)
        Me.LabelApellido.TabIndex = 2
        Me.LabelApellido.Text = "Apellido"
        Me.LabelApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelNombre.Location = New System.Drawing.Point(0, 0)
        Me.LabelNombre.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelNombre.Size = New System.Drawing.Size(111, 37)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNombre.Location = New System.Drawing.Point(118, 6)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(322, 22)
        Me.TextBoxNombre.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(268, 251)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 43)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 7)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancelar"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 7)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 307)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormCliente"
        Me.Text = "Cliente"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents TextBoxLegajo As TextBox
    Friend WithEvents LabelCUIT As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxSector As TextBox
    Friend WithEvents LabelCelular As Label
    Friend WithEvents TextBoxInterno As TextBox
    Friend WithEvents Interno As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
End Class
