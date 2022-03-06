<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTRADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GBdatos = New System.Windows.Forms.GroupBox()
        Me.Lnombre = New System.Windows.Forms.Label()
        Me.TBnombre = New System.Windows.Forms.TextBox()
        Me.GBservicios = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBservicio = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LBnombre = New System.Windows.Forms.ListBox()
        Me.LBnit = New System.Windows.Forms.ListBox()
        Me.LBdias = New System.Windows.Forms.ListBox()
        Me.LBhonorarios = New System.Windows.Forms.ListBox()
        Me.LBservicio = New System.Windows.Forms.ListBox()
        Me.LBrecargo = New System.Windows.Forms.ListBox()
        Me.LBpagoParcial = New System.Windows.Forms.ListBox()
        Me.LBdescuento = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.LBtotal = New System.Windows.Forms.ListBox()
        Me.CBhabitacion = New System.Windows.Forms.ComboBox()
        Me.CBservicio = New System.Windows.Forms.ComboBox()
        Me.Lservicio = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GBdatos.SuspendLayout()
        Me.GBservicios.SuspendLayout()
        Me.GBservicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1078, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRADAToolStripMenuItem, Me.VECTORESToolStripMenuItem})
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR "
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'ENTRADAToolStripMenuItem
        '
        Me.ENTRADAToolStripMenuItem.Name = "ENTRADAToolStripMenuItem"
        Me.ENTRADAToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ENTRADAToolStripMenuItem.Text = "ENTRADA "
        '
        'VECTORESToolStripMenuItem
        '
        Me.VECTORESToolStripMenuItem.Name = "VECTORESToolStripMenuItem"
        Me.VECTORESToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VECTORESToolStripMenuItem.Text = "VECTORES"
        '
        'GBdatos
        '
        Me.GBdatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GBdatos.Controls.Add(Me.ComboBox1)
        Me.GBdatos.Controls.Add(Me.Label2)
        Me.GBdatos.Controls.Add(Me.TBnombre)
        Me.GBdatos.Controls.Add(Me.Lnombre)
        Me.GBdatos.Location = New System.Drawing.Point(12, 43)
        Me.GBdatos.Name = "GBdatos"
        Me.GBdatos.Size = New System.Drawing.Size(332, 112)
        Me.GBdatos.TabIndex = 1
        Me.GBdatos.TabStop = False
        Me.GBdatos.Text = "INGRESAR DATOS"
        '
        'Lnombre
        '
        Me.Lnombre.AutoSize = True
        Me.Lnombre.Location = New System.Drawing.Point(20, 41)
        Me.Lnombre.Name = "Lnombre"
        Me.Lnombre.Size = New System.Drawing.Size(105, 13)
        Me.Lnombre.TabIndex = 0
        Me.Lnombre.Text = "Nombre del paciente"
        '
        'TBnombre
        '
        Me.TBnombre.Location = New System.Drawing.Point(171, 38)
        Me.TBnombre.Name = "TBnombre"
        Me.TBnombre.Size = New System.Drawing.Size(100, 20)
        Me.TBnombre.TabIndex = 1
        '
        'GBservicios
        '
        Me.GBservicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GBservicios.Controls.Add(Me.CBhabitacion)
        Me.GBservicios.Controls.Add(Me.Label1)
        Me.GBservicios.Location = New System.Drawing.Point(366, 43)
        Me.GBservicios.Name = "GBservicios"
        Me.GBservicios.Size = New System.Drawing.Size(156, 156)
        Me.GBservicios.TabIndex = 8
        Me.GBservicios.TabStop = False
        Me.GBservicios.Text = "Habitacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Habitacion"
        '
        'GBservicio
        '
        Me.GBservicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBservicio.Controls.Add(Me.Lservicio)
        Me.GBservicio.Controls.Add(Me.CBservicio)
        Me.GBservicio.Location = New System.Drawing.Point(537, 43)
        Me.GBservicio.Name = "GBservicio"
        Me.GBservicio.Size = New System.Drawing.Size(160, 149)
        Me.GBservicio.TabIndex = 9
        Me.GBservicio.TabStop = False
        Me.GBservicio.Text = "Servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de pago"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"EFECTIVO", "CHEQUE", "TARJETA_CREDITO", "TARJETA_DEBITO"})
        Me.ComboBox1.Location = New System.Drawing.Point(171, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'LBnombre
        '
        Me.LBnombre.FormattingEnabled = True
        Me.LBnombre.Location = New System.Drawing.Point(17, 244)
        Me.LBnombre.Name = "LBnombre"
        Me.LBnombre.Size = New System.Drawing.Size(85, 95)
        Me.LBnombre.TabIndex = 11
        '
        'LBnit
        '
        Me.LBnit.FormattingEnabled = True
        Me.LBnit.Location = New System.Drawing.Point(108, 244)
        Me.LBnit.Name = "LBnit"
        Me.LBnit.Size = New System.Drawing.Size(85, 95)
        Me.LBnit.TabIndex = 12
        '
        'LBdias
        '
        Me.LBdias.FormattingEnabled = True
        Me.LBdias.Location = New System.Drawing.Point(199, 244)
        Me.LBdias.Name = "LBdias"
        Me.LBdias.Size = New System.Drawing.Size(85, 95)
        Me.LBdias.TabIndex = 13
        '
        'LBhonorarios
        '
        Me.LBhonorarios.FormattingEnabled = True
        Me.LBhonorarios.Location = New System.Drawing.Point(290, 244)
        Me.LBhonorarios.Name = "LBhonorarios"
        Me.LBhonorarios.Size = New System.Drawing.Size(85, 95)
        Me.LBhonorarios.TabIndex = 13
        '
        'LBservicio
        '
        Me.LBservicio.FormattingEnabled = True
        Me.LBservicio.Location = New System.Drawing.Point(381, 244)
        Me.LBservicio.Name = "LBservicio"
        Me.LBservicio.Size = New System.Drawing.Size(85, 95)
        Me.LBservicio.TabIndex = 14
        '
        'LBrecargo
        '
        Me.LBrecargo.FormattingEnabled = True
        Me.LBrecargo.Location = New System.Drawing.Point(654, 244)
        Me.LBrecargo.Name = "LBrecargo"
        Me.LBrecargo.Size = New System.Drawing.Size(85, 95)
        Me.LBrecargo.TabIndex = 15
        '
        'LBpagoParcial
        '
        Me.LBpagoParcial.FormattingEnabled = True
        Me.LBpagoParcial.Location = New System.Drawing.Point(472, 244)
        Me.LBpagoParcial.Name = "LBpagoParcial"
        Me.LBpagoParcial.Size = New System.Drawing.Size(85, 95)
        Me.LBpagoParcial.TabIndex = 15
        '
        'LBdescuento
        '
        Me.LBdescuento.FormattingEnabled = True
        Me.LBdescuento.Location = New System.Drawing.Point(563, 244)
        Me.LBdescuento.Name = "LBdescuento"
        Me.LBdescuento.Size = New System.Drawing.Size(85, 95)
        Me.LBdescuento.TabIndex = 16
        '
        'ListBox9
        '
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.Location = New System.Drawing.Point(968, 244)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(85, 95)
        Me.ListBox9.TabIndex = 17
        '
        'LBtotal
        '
        Me.LBtotal.FormattingEnabled = True
        Me.LBtotal.Location = New System.Drawing.Point(745, 244)
        Me.LBtotal.Name = "LBtotal"
        Me.LBtotal.Size = New System.Drawing.Size(85, 95)
        Me.LBtotal.TabIndex = 18
        '
        'CBhabitacion
        '
        Me.CBhabitacion.FormattingEnabled = True
        Me.CBhabitacion.Items.AddRange(New Object() {"PRIVADA", "SEMI_PRIVADA", "NO_PRIVADA"})
        Me.CBhabitacion.Location = New System.Drawing.Point(25, 75)
        Me.CBhabitacion.Name = "CBhabitacion"
        Me.CBhabitacion.Size = New System.Drawing.Size(121, 21)
        Me.CBhabitacion.TabIndex = 1
        '
        'CBservicio
        '
        Me.CBservicio.FormattingEnabled = True
        Me.CBservicio.Items.AddRange(New Object() {"ENCAMAMIENTO", "OPERACION", "MATERNIDAD"})
        Me.CBservicio.Location = New System.Drawing.Point(17, 75)
        Me.CBservicio.Name = "CBservicio"
        Me.CBservicio.Size = New System.Drawing.Size(121, 21)
        Me.CBservicio.TabIndex = 0
        '
        'Lservicio
        '
        Me.Lservicio.AutoSize = True
        Me.Lservicio.Location = New System.Drawing.Point(14, 41)
        Me.Lservicio.Name = "Lservicio"
        Me.Lservicio.Size = New System.Drawing.Size(110, 13)
        Me.Lservicio.TabIndex = 1
        Me.Lservicio.Text = "Seleccione el servicio"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201801457_HOSPITAL.My.Resources.Resources.infraestructura_en_salud
        Me.ClientSize = New System.Drawing.Size(1078, 387)
        Me.Controls.Add(Me.LBtotal)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.LBdescuento)
        Me.Controls.Add(Me.LBpagoParcial)
        Me.Controls.Add(Me.LBrecargo)
        Me.Controls.Add(Me.LBservicio)
        Me.Controls.Add(Me.LBhonorarios)
        Me.Controls.Add(Me.LBdias)
        Me.Controls.Add(Me.LBnit)
        Me.Controls.Add(Me.LBnombre)
        Me.Controls.Add(Me.GBservicio)
        Me.Controls.Add(Me.GBservicios)
        Me.Controls.Add(Me.GBdatos)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GBdatos.ResumeLayout(False)
        Me.GBdatos.PerformLayout()
        Me.GBservicios.ResumeLayout(False)
        Me.GBservicios.PerformLayout()
        Me.GBservicio.ResumeLayout(False)
        Me.GBservicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTRADAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GBdatos As GroupBox
    Friend WithEvents TBnombre As TextBox
    Friend WithEvents Lnombre As Label
    Friend WithEvents GBservicios As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBservicio As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LBnombre As ListBox
    Friend WithEvents LBnit As ListBox
    Friend WithEvents LBdias As ListBox
    Friend WithEvents LBhonorarios As ListBox
    Friend WithEvents LBservicio As ListBox
    Friend WithEvents LBrecargo As ListBox
    Friend WithEvents LBpagoParcial As ListBox
    Friend WithEvents LBdescuento As ListBox
    Friend WithEvents ListBox9 As ListBox
    Friend WithEvents LBtotal As ListBox
    Friend WithEvents CBhabitacion As ComboBox
    Friend WithEvents Lservicio As Label
    Friend WithEvents CBservicio As ComboBox
End Class
