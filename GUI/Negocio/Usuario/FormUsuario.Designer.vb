<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuario
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
        Me.LabelLeyendaPassword = New System.Windows.Forms.Label()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxSector = New System.Windows.Forms.ComboBox()
        Me.LabelSucursal = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.LabelApellido = New System.Windows.Forms.Label()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ComboBoxFamilia = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelLeyendaPassword
        '
        Me.LabelLeyendaPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeyendaPassword.Location = New System.Drawing.Point(23, 252)
        Me.LabelLeyendaPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLeyendaPassword.Name = "LabelLeyendaPassword"
        Me.LabelLeyendaPassword.Size = New System.Drawing.Size(255, 36)
        Me.LabelLeyendaPassword.TabIndex = 6
        Me.LabelLeyendaPassword.Text = "Dejar el campo ""Contraseña"" vacío si no se desea modificar."
        Me.LabelLeyendaPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel.Controls.Add(Me.ComboBoxSector, 1, 5)
        Me.TableLayoutPanel.Controls.Add(Me.LabelSucursal, 0, 5)
        Me.TableLayoutPanel.Controls.Add(Me.LabelEmail, 0, 4)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxPassword, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.LabelPassword, 0, 3)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxUsuario, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.LabelUsuario, 0, 2)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxApellido, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelApellido, 0, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelNombre, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.TextBoxNombre, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ComboBoxFamilia, 1, 4)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(20, 15)
        Me.TableLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(456, 226)
        Me.TableLayoutPanel.TabIndex = 5
        '
        'ComboBoxSector
        '
        Me.ComboBoxSector.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxSector.FormattingEnabled = True
        Me.ComboBoxSector.Location = New System.Drawing.Point(121, 193)
        Me.ComboBoxSector.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ComboBoxSector.Name = "ComboBoxSector"
        Me.ComboBoxSector.Size = New System.Drawing.Size(328, 24)
        Me.ComboBoxSector.TabIndex = 11
        '
        'LabelSucursal
        '
        Me.LabelSucursal.AutoSize = True
        Me.LabelSucursal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelSucursal.Location = New System.Drawing.Point(0, 187)
        Me.LabelSucursal.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSucursal.Name = "LabelSucursal"
        Me.LabelSucursal.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelSucursal.Size = New System.Drawing.Size(114, 39)
        Me.LabelSucursal.TabIndex = 10
        Me.LabelSucursal.Text = "Sector"
        Me.LabelSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelEmail.Location = New System.Drawing.Point(0, 148)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelEmail.Size = New System.Drawing.Size(114, 39)
        Me.LabelEmail.TabIndex = 8
        Me.LabelEmail.Text = "Familia"
        Me.LabelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxPassword.Location = New System.Drawing.Point(121, 117)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(328, 22)
        Me.TextBoxPassword.TabIndex = 7
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelPassword.Location = New System.Drawing.Point(0, 111)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelPassword.Size = New System.Drawing.Size(114, 37)
        Me.LabelPassword.TabIndex = 6
        Me.LabelPassword.Text = "Contraseña"
        Me.LabelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxUsuario.Location = New System.Drawing.Point(121, 80)
        Me.TextBoxUsuario.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(328, 22)
        Me.TextBoxUsuario.TabIndex = 5
        '
        'LabelUsuario
        '
        Me.LabelUsuario.AutoSize = True
        Me.LabelUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelUsuario.Location = New System.Drawing.Point(0, 74)
        Me.LabelUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.LabelUsuario.Size = New System.Drawing.Size(114, 37)
        Me.LabelUsuario.TabIndex = 4
        Me.LabelUsuario.Text = "Usuario"
        Me.LabelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxApellido.Location = New System.Drawing.Point(121, 43)
        Me.TextBoxApellido.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(328, 22)
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
        Me.LabelApellido.Size = New System.Drawing.Size(114, 37)
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
        Me.LabelNombre.Size = New System.Drawing.Size(114, 37)
        Me.LabelNombre.TabIndex = 0
        Me.LabelNombre.Text = "Nombre"
        Me.LabelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxNombre.Location = New System.Drawing.Point(121, 6)
        Me.TextBoxNombre.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(328, 22)
        Me.TextBoxNombre.TabIndex = 1
        '
        'ComboBoxFamilia
        '
        Me.ComboBoxFamilia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxFamilia.FormattingEnabled = True
        Me.ComboBoxFamilia.Location = New System.Drawing.Point(121, 154)
        Me.ComboBoxFamilia.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ComboBoxFamilia.Name = "ComboBoxFamilia"
        Me.ComboBoxFamilia.Size = New System.Drawing.Size(328, 24)
        Me.ComboBoxFamilia.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(282, 252)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aceptar"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'FormUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 303)
        Me.Controls.Add(Me.LabelLeyendaPassword)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FormUsuario"
        Me.Text = "Usuario"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelLeyendaPassword As Label
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents ComboBoxSector As ComboBox
    Friend WithEvents LabelSucursal As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents LabelUsuario As Label
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents LabelApellido As Label
    Friend WithEvents LabelNombre As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ComboBoxFamilia As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
End Class
