<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT3 = New System.Windows.Forms.TextBox()
        Me.TXT2 = New System.Windows.Forms.TextBox()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        Me.AZUCAR = New System.Windows.Forms.Label()
        Me.FRIJOL = New System.Windows.Forms.Label()
        Me.ARROZ = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBtotal = New System.Windows.Forms.Label()
        Me.LBtotalIava = New System.Windows.Forms.Label()
        Me.LBantesIva = New System.Windows.Forms.Label()
        Me.LBdescuento = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BT3 = New System.Windows.Forms.Button()
        Me.BT2 = New System.Windows.Forms.Button()
        Me.BT1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT3)
        Me.GroupBox1.Controls.Add(Me.TXT2)
        Me.GroupBox1.Controls.Add(Me.TXT1)
        Me.GroupBox1.Controls.Add(Me.AZUCAR)
        Me.GroupBox1.Controls.Add(Me.FRIJOL)
        Me.GroupBox1.Controls.Add(Me.ARROZ)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS A INGRESAR"
        '
        'TXT3
        '
        Me.TXT3.Location = New System.Drawing.Point(146, 146)
        Me.TXT3.Name = "TXT3"
        Me.TXT3.Size = New System.Drawing.Size(100, 23)
        Me.TXT3.TabIndex = 5
        Me.TXT3.Text = "0"
        '
        'TXT2
        '
        Me.TXT2.Location = New System.Drawing.Point(146, 94)
        Me.TXT2.Name = "TXT2"
        Me.TXT2.Size = New System.Drawing.Size(100, 23)
        Me.TXT2.TabIndex = 4
        Me.TXT2.Text = "0"
        '
        'TXT1
        '
        Me.TXT1.Location = New System.Drawing.Point(146, 46)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(100, 23)
        Me.TXT1.TabIndex = 3
        Me.TXT1.Text = "0"
        '
        'AZUCAR
        '
        Me.AZUCAR.AutoSize = True
        Me.AZUCAR.Location = New System.Drawing.Point(23, 146)
        Me.AZUCAR.Name = "AZUCAR"
        Me.AZUCAR.Size = New System.Drawing.Size(77, 15)
        Me.AZUCAR.TabIndex = 2
        Me.AZUCAR.Text = "Libras Azucar"
        '
        'FRIJOL
        '
        Me.FRIJOL.AutoSize = True
        Me.FRIJOL.Location = New System.Drawing.Point(23, 94)
        Me.FRIJOL.Name = "FRIJOL"
        Me.FRIJOL.Size = New System.Drawing.Size(67, 15)
        Me.FRIJOL.TabIndex = 1
        Me.FRIJOL.Text = "Libras Frijol"
        '
        'ARROZ
        '
        Me.ARROZ.AutoSize = True
        Me.ARROZ.Location = New System.Drawing.Point(23, 46)
        Me.ARROZ.Name = "ARROZ"
        Me.ARROZ.Size = New System.Drawing.Size(85, 15)
        Me.ARROZ.TabIndex = 0
        Me.ARROZ.Text = "Libras de Arroz"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBtotal)
        Me.GroupBox2.Controls.Add(Me.LBtotalIava)
        Me.GroupBox2.Controls.Add(Me.LBantesIva)
        Me.GroupBox2.Controls.Add(Me.LBdescuento)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(503, 177)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'LBtotal
        '
        Me.LBtotal.AutoSize = True
        Me.LBtotal.Location = New System.Drawing.Point(424, 53)
        Me.LBtotal.Name = "LBtotal"
        Me.LBtotal.Size = New System.Drawing.Size(22, 15)
        Me.LBtotal.TabIndex = 14
        Me.LBtotal.Text = "0.0"
        '
        'LBtotalIava
        '
        Me.LBtotalIava.AutoSize = True
        Me.LBtotalIava.Location = New System.Drawing.Point(184, 130)
        Me.LBtotalIava.Name = "LBtotalIava"
        Me.LBtotalIava.Size = New System.Drawing.Size(22, 15)
        Me.LBtotalIava.TabIndex = 13
        Me.LBtotalIava.Text = "0.0"
        '
        'LBantesIva
        '
        Me.LBantesIva.AutoSize = True
        Me.LBantesIva.Location = New System.Drawing.Point(184, 53)
        Me.LBantesIva.Name = "LBantesIva"
        Me.LBantesIva.Size = New System.Drawing.Size(22, 15)
        Me.LBantesIva.TabIndex = 1
        Me.LBantesIva.Text = "0.0"
        '
        'LBdescuento
        '
        Me.LBdescuento.AutoSize = True
        Me.LBdescuento.Location = New System.Drawing.Point(184, 93)
        Me.LBdescuento.Name = "LBdescuento"
        Me.LBdescuento.Size = New System.Drawing.Size(22, 15)
        Me.LBdescuento.TabIndex = 2
        Me.LBdescuento.Text = "0.0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "DESCUENTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(324, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "PAGO TOTAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "TOTAL IVA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "PAGO ANTES DE IVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BT3)
        Me.GroupBox3.Controls.Add(Me.BT2)
        Me.GroupBox3.Controls.Add(Me.BT1)
        Me.GroupBox3.Location = New System.Drawing.Point(351, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 214)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "COMANDOS"
        '
        'BT3
        '
        Me.BT3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BT3.Location = New System.Drawing.Point(47, 146)
        Me.BT3.Name = "BT3"
        Me.BT3.Size = New System.Drawing.Size(75, 23)
        Me.BT3.TabIndex = 12
        Me.BT3.Text = "SALIR"
        Me.BT3.UseVisualStyleBackColor = False
        '
        'BT2
        '
        Me.BT2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BT2.Location = New System.Drawing.Point(47, 94)
        Me.BT2.Name = "BT2"
        Me.BT2.Size = New System.Drawing.Size(75, 23)
        Me.BT2.TabIndex = 11
        Me.BT2.Text = "LIMPIAR"
        Me.BT2.UseVisualStyleBackColor = False
        '
        'BT1
        '
        Me.BT1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BT1.Location = New System.Drawing.Point(47, 45)
        Me.BT1.Name = "BT1"
        Me.BT1.Size = New System.Drawing.Size(75, 23)
        Me.BT1.TabIndex = 10
        Me.BT1.Text = "ACEPTAR"
        Me.BT1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(647, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "201801457_Tarea2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AZUCAR As Label
    Friend WithEvents FRIJOL As Label
    Friend WithEvents ARROZ As Label
    Friend WithEvents TXT3 As TextBox
    Friend WithEvents TXT2 As TextBox
    Friend WithEvents TXT1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BT3 As Button
    Friend WithEvents BT2 As Button
    Friend WithEvents BT1 As Button
    Friend WithEvents LBantesIva As Label
    Friend WithEvents LBdescuento As Label
    Friend WithEvents LBtotal As Label
    Friend WithEvents LBtotalIava As Label
End Class
