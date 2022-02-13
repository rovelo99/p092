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
        Me.GP1 = New System.Windows.Forms.GroupBox()
        Me.cbVenta = New System.Windows.Forms.CheckBox()
        Me.cbCompra = New System.Windows.Forms.CheckBox()
        Me.GP2 = New System.Windows.Forms.GroupBox()
        Me.Lventa = New System.Windows.Forms.Label()
        Me.Lcompra = New System.Windows.Forms.Label()
        Me.TBcompra = New System.Windows.Forms.TextBox()
        Me.TBventa = New System.Windows.Forms.TextBox()
        Me.GB3 = New System.Windows.Forms.GroupBox()
        Me.RBcolon = New System.Windows.Forms.RadioButton()
        Me.RBeuro = New System.Windows.Forms.RadioButton()
        Me.RBpesos = New System.Windows.Forms.RadioButton()
        Me.RBdolar = New System.Windows.Forms.RadioButton()
        Me.GB4 = New System.Windows.Forms.GroupBox()
        Me.RBcolonV = New System.Windows.Forms.RadioButton()
        Me.RBpesosV = New System.Windows.Forms.RadioButton()
        Me.RBeuroV = New System.Windows.Forms.RadioButton()
        Me.RBdolarV = New System.Windows.Forms.RadioButton()
        Me.Bcalcular = New System.Windows.Forms.Button()
        Me.Blimpiar = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.GP1.SuspendLayout()
        Me.GP2.SuspendLayout()
        Me.GB3.SuspendLayout()
        Me.GB4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GP1
        '
        Me.GP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GP1.Controls.Add(Me.cbVenta)
        Me.GP1.Controls.Add(Me.cbCompra)
        Me.GP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP1.Location = New System.Drawing.Point(36, 22)
        Me.GP1.Name = "GP1"
        Me.GP1.Size = New System.Drawing.Size(174, 149)
        Me.GP1.TabIndex = 0
        Me.GP1.TabStop = False
        Me.GP1.Text = "Tipo de Transaccion "
        '
        'cbVenta
        '
        Me.cbVenta.AutoSize = True
        Me.cbVenta.Location = New System.Drawing.Point(23, 68)
        Me.cbVenta.Name = "cbVenta"
        Me.cbVenta.Size = New System.Drawing.Size(71, 24)
        Me.cbVenta.TabIndex = 1
        Me.cbVenta.Text = "Venta"
        Me.cbVenta.UseVisualStyleBackColor = True
        '
        'cbCompra
        '
        Me.cbCompra.AutoSize = True
        Me.cbCompra.Location = New System.Drawing.Point(23, 29)
        Me.cbCompra.Name = "cbCompra"
        Me.cbCompra.Size = New System.Drawing.Size(84, 24)
        Me.cbCompra.TabIndex = 0
        Me.cbCompra.Text = "Compra"
        Me.cbCompra.UseVisualStyleBackColor = True
        '
        'GP2
        '
        Me.GP2.BackColor = System.Drawing.Color.Fuchsia
        Me.GP2.Controls.Add(Me.Lventa)
        Me.GP2.Controls.Add(Me.Lcompra)
        Me.GP2.Controls.Add(Me.TBcompra)
        Me.GP2.Controls.Add(Me.TBventa)
        Me.GP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP2.Location = New System.Drawing.Point(234, 22)
        Me.GP2.Name = "GP2"
        Me.GP2.Size = New System.Drawing.Size(501, 167)
        Me.GP2.TabIndex = 0
        Me.GP2.TabStop = False
        Me.GP2.Text = "Quetzales a Cambiar"
        '
        'Lventa
        '
        Me.Lventa.AutoSize = True
        Me.Lventa.Location = New System.Drawing.Point(16, 94)
        Me.Lventa.Name = "Lventa"
        Me.Lventa.Size = New System.Drawing.Size(344, 24)
        Me.Lventa.TabIndex = 4
        Me.Lventa.Text = "Ingrese cantidad de monedas a vender "
        '
        'Lcompra
        '
        Me.Lcompra.AutoSize = True
        Me.Lcompra.Location = New System.Drawing.Point(16, 29)
        Me.Lcompra.Name = "Lcompra"
        Me.Lcompra.Size = New System.Drawing.Size(462, 24)
        Me.Lcompra.TabIndex = 3
        Me.Lcompra.Text = "Ingrese Quetzales a cambiar para compra de moneda"
        '
        'TBcompra
        '
        Me.TBcompra.Location = New System.Drawing.Point(19, 55)
        Me.TBcompra.Name = "TBcompra"
        Me.TBcompra.Size = New System.Drawing.Size(100, 29)
        Me.TBcompra.TabIndex = 1
        '
        'TBventa
        '
        Me.TBventa.Location = New System.Drawing.Point(19, 120)
        Me.TBventa.Name = "TBventa"
        Me.TBventa.Size = New System.Drawing.Size(100, 29)
        Me.TBventa.TabIndex = 2
        '
        'GB3
        '
        Me.GB3.Controls.Add(Me.RBcolon)
        Me.GB3.Controls.Add(Me.RBeuro)
        Me.GB3.Controls.Add(Me.RBpesos)
        Me.GB3.Controls.Add(Me.RBdolar)
        Me.GB3.Enabled = False
        Me.GB3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB3.Location = New System.Drawing.Point(36, 195)
        Me.GB3.Name = "GB3"
        Me.GB3.Size = New System.Drawing.Size(187, 184)
        Me.GB3.TabIndex = 2
        Me.GB3.TabStop = False
        Me.GB3.Text = "Moneda de compra"
        '
        'RBcolon
        '
        Me.RBcolon.AutoSize = True
        Me.RBcolon.Location = New System.Drawing.Point(23, 121)
        Me.RBcolon.Name = "RBcolon"
        Me.RBcolon.Size = New System.Drawing.Size(67, 25)
        Me.RBcolon.TabIndex = 3
        Me.RBcolon.TabStop = True
        Me.RBcolon.Text = "Colón"
        Me.RBcolon.UseVisualStyleBackColor = True
        '
        'RBeuro
        '
        Me.RBeuro.AutoSize = True
        Me.RBeuro.Location = New System.Drawing.Point(23, 90)
        Me.RBeuro.Name = "RBeuro"
        Me.RBeuro.Size = New System.Drawing.Size(69, 25)
        Me.RBeuro.TabIndex = 2
        Me.RBeuro.TabStop = True
        Me.RBeuro.Text = "Euros"
        Me.RBeuro.UseVisualStyleBackColor = True
        '
        'RBpesos
        '
        Me.RBpesos.AutoSize = True
        Me.RBpesos.Location = New System.Drawing.Point(23, 61)
        Me.RBpesos.Name = "RBpesos"
        Me.RBpesos.Size = New System.Drawing.Size(151, 25)
        Me.RBpesos.TabIndex = 1
        Me.RBpesos.TabStop = True
        Me.RBpesos.Text = "Pesos Mexicanos"
        Me.RBpesos.UseVisualStyleBackColor = True
        '
        'RBdolar
        '
        Me.RBdolar.AutoSize = True
        Me.RBdolar.Location = New System.Drawing.Point(23, 31)
        Me.RBdolar.Name = "RBdolar"
        Me.RBdolar.Size = New System.Drawing.Size(66, 25)
        Me.RBdolar.TabIndex = 0
        Me.RBdolar.TabStop = True
        Me.RBdolar.Text = "Dolar"
        Me.RBdolar.UseVisualStyleBackColor = True
        '
        'GB4
        '
        Me.GB4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GB4.Controls.Add(Me.RBcolonV)
        Me.GB4.Controls.Add(Me.RBpesosV)
        Me.GB4.Controls.Add(Me.RBeuroV)
        Me.GB4.Controls.Add(Me.RBdolarV)
        Me.GB4.Enabled = False
        Me.GB4.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB4.Location = New System.Drawing.Point(276, 195)
        Me.GB4.Name = "GB4"
        Me.GB4.Size = New System.Drawing.Size(182, 184)
        Me.GB4.TabIndex = 0
        Me.GB4.TabStop = False
        Me.GB4.Text = "Moneda de venta "
        '
        'RBcolonV
        '
        Me.RBcolonV.AutoSize = True
        Me.RBcolonV.Location = New System.Drawing.Point(24, 121)
        Me.RBcolonV.Name = "RBcolonV"
        Me.RBcolonV.Size = New System.Drawing.Size(73, 24)
        Me.RBcolonV.TabIndex = 7
        Me.RBcolonV.TabStop = True
        Me.RBcolonV.Text = "Colón"
        Me.RBcolonV.UseVisualStyleBackColor = True
        '
        'RBpesosV
        '
        Me.RBpesosV.AutoSize = True
        Me.RBpesosV.Location = New System.Drawing.Point(24, 61)
        Me.RBpesosV.Name = "RBpesosV"
        Me.RBpesosV.Size = New System.Drawing.Size(165, 24)
        Me.RBpesosV.TabIndex = 5
        Me.RBpesosV.TabStop = True
        Me.RBpesosV.Text = "Pesos Mexicanos"
        Me.RBpesosV.UseVisualStyleBackColor = True
        '
        'RBeuroV
        '
        Me.RBeuroV.AutoSize = True
        Me.RBeuroV.Location = New System.Drawing.Point(24, 90)
        Me.RBeuroV.Name = "RBeuroV"
        Me.RBeuroV.Size = New System.Drawing.Size(72, 24)
        Me.RBeuroV.TabIndex = 6
        Me.RBeuroV.TabStop = True
        Me.RBeuroV.Text = "Euros"
        Me.RBeuroV.UseVisualStyleBackColor = True
        '
        'RBdolarV
        '
        Me.RBdolarV.AutoSize = True
        Me.RBdolarV.Location = New System.Drawing.Point(24, 31)
        Me.RBdolarV.Name = "RBdolarV"
        Me.RBdolarV.Size = New System.Drawing.Size(70, 24)
        Me.RBdolarV.TabIndex = 4
        Me.RBdolarV.TabStop = True
        Me.RBdolarV.Text = "Dolar"
        Me.RBdolarV.UseVisualStyleBackColor = True
        '
        'Bcalcular
        '
        Me.Bcalcular.BackColor = System.Drawing.Color.Lime
        Me.Bcalcular.Location = New System.Drawing.Point(514, 215)
        Me.Bcalcular.Name = "Bcalcular"
        Me.Bcalcular.Size = New System.Drawing.Size(75, 23)
        Me.Bcalcular.TabIndex = 3
        Me.Bcalcular.Text = "Calcular "
        Me.Bcalcular.UseVisualStyleBackColor = False
        '
        'Blimpiar
        '
        Me.Blimpiar.Location = New System.Drawing.Point(514, 257)
        Me.Blimpiar.Name = "Blimpiar"
        Me.Blimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Blimpiar.TabIndex = 4
        Me.Blimpiar.Text = "Limpiar "
        Me.Blimpiar.UseVisualStyleBackColor = True
        '
        'Bsalir
        '
        Me.Bsalir.BackColor = System.Drawing.Color.Red
        Me.Bsalir.Location = New System.Drawing.Point(514, 299)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(75, 23)
        Me.Bsalir.TabIndex = 5
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 391)
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.Blimpiar)
        Me.Controls.Add(Me.Bcalcular)
        Me.Controls.Add(Me.GB4)
        Me.Controls.Add(Me.GB3)
        Me.Controls.Add(Me.GP2)
        Me.Controls.Add(Me.GP1)
        Me.Name = "Form1"
        Me.Text = "Compra Venta de monedas"
        Me.GP1.ResumeLayout(False)
        Me.GP1.PerformLayout()
        Me.GP2.ResumeLayout(False)
        Me.GP2.PerformLayout()
        Me.GB3.ResumeLayout(False)
        Me.GB3.PerformLayout()
        Me.GB4.ResumeLayout(False)
        Me.GB4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GP1 As GroupBox
    Friend WithEvents GP2 As GroupBox
    Friend WithEvents cbVenta As CheckBox
    Friend WithEvents cbCompra As CheckBox
    Friend WithEvents Lventa As Label
    Friend WithEvents Lcompra As Label
    Friend WithEvents TBcompra As TextBox
    Friend WithEvents TBventa As TextBox
    Friend WithEvents GB3 As GroupBox
    Friend WithEvents GB4 As GroupBox
    Friend WithEvents RBcolon As RadioButton
    Friend WithEvents RBeuro As RadioButton
    Friend WithEvents RBpesos As RadioButton
    Friend WithEvents RBdolar As RadioButton
    Friend WithEvents RBcolonV As RadioButton
    Friend WithEvents RBpesosV As RadioButton
    Friend WithEvents RBeuroV As RadioButton
    Friend WithEvents RBdolarV As RadioButton
    Friend WithEvents Bcalcular As Button
    Friend WithEvents Blimpiar As Button
    Friend WithEvents Bsalir As Button
End Class
