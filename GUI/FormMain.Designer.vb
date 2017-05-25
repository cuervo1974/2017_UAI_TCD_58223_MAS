<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.USUARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTROToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARCESIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOPORTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABRIRSRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TECNICOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ASIGNACIONTECNICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.USUARIOToolStripMenuItem, Me.SOPORTEToolStripMenuItem, Me.INFORMESToolStripMenuItem, Me.TECNICOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(933, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'USUARIOToolStripMenuItem
        '
        Me.USUARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTROToolStripMenuItem, Me.LOGINToolStripMenuItem, Me.CERRARCESIONToolStripMenuItem})
        Me.USUARIOToolStripMenuItem.Name = "USUARIOToolStripMenuItem"
        Me.USUARIOToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.USUARIOToolStripMenuItem.Text = "USUARIO"
        '
        'REGISTROToolStripMenuItem
        '
        Me.REGISTROToolStripMenuItem.Name = "REGISTROToolStripMenuItem"
        Me.REGISTROToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.REGISTROToolStripMenuItem.Text = "REGISTRO"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.LOGINToolStripMenuItem.Text = "INICIAR SESION"
        '
        'CERRARCESIONToolStripMenuItem
        '
        Me.CERRARCESIONToolStripMenuItem.Name = "CERRARCESIONToolStripMenuItem"
        Me.CERRARCESIONToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.CERRARCESIONToolStripMenuItem.Text = "CERRAR SESION"
        '
        'SOPORTEToolStripMenuItem
        '
        Me.SOPORTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABRIRSRToolStripMenuItem})
        Me.SOPORTEToolStripMenuItem.Name = "SOPORTEToolStripMenuItem"
        Me.SOPORTEToolStripMenuItem.Size = New System.Drawing.Size(83, 24)
        Me.SOPORTEToolStripMenuItem.Text = "SOPORTE"
        '
        'ABRIRSRToolStripMenuItem
        '
        Me.ABRIRSRToolStripMenuItem.Name = "ABRIRSRToolStripMenuItem"
        Me.ABRIRSRToolStripMenuItem.Size = New System.Drawing.Size(146, 26)
        Me.ABRIRSRToolStripMenuItem.Text = "ABRIR SR"
        '
        'INFORMESToolStripMenuItem
        '
        Me.INFORMESToolStripMenuItem.Name = "INFORMESToolStripMenuItem"
        Me.INFORMESToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.INFORMESToolStripMenuItem.Text = "INFORMES"
        '
        'TECNICOSToolStripMenuItem
        '
        Me.TECNICOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASIGNACIONTECNICOToolStripMenuItem})
        Me.TECNICOSToolStripMenuItem.Name = "TECNICOSToolStripMenuItem"
        Me.TECNICOSToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.TECNICOSToolStripMenuItem.Text = "TECNICOS"
        '
        'ASIGNACIONTECNICOToolStripMenuItem
        '
        Me.ASIGNACIONTECNICOToolStripMenuItem.Name = "ASIGNACIONTECNICOToolStripMenuItem"
        Me.ASIGNACIONTECNICOToolStripMenuItem.Size = New System.Drawing.Size(236, 26)
        Me.ASIGNACIONTECNICOToolStripMenuItem.Text = "ASIGNACION TECNICO"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 392)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "S.G.I.S.I."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents USUARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REGISTROToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARCESIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SOPORTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABRIRSRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents INFORMESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TECNICOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASIGNACIONTECNICOToolStripMenuItem As ToolStripMenuItem
End Class
