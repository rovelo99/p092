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
        Me.Bcalcular = New System.Windows.Forms.Button()
        Me.Blimpiar = New System.Windows.Forms.Button()
        Me.Bsalir = New System.Windows.Forms.Button()
        Me.GBtalla = New System.Windows.Forms.GroupBox()
        Me.RBlarge = New System.Windows.Forms.RadioButton()
        Me.RBmedium = New System.Windows.Forms.RadioButton()
        Me.RBsmall = New System.Windows.Forms.RadioButton()
        Me.GBtela = New System.Windows.Forms.GroupBox()
        Me.RBlona = New System.Windows.Forms.RadioButton()
        Me.RBseda = New System.Windows.Forms.RadioButton()
        Me.RBalgodon = New System.Windows.Forms.RadioButton()
        Me.Lingreso = New System.Windows.Forms.Label()
        Me.TBcantidad = New System.Windows.Forms.TextBox()
        Me.GBtalla.SuspendLayout()
        Me.GBtela.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bcalcular
        '
        Me.Bcalcular.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bcalcular.Location = New System.Drawing.Point(449, 142)
        Me.Bcalcular.Name = "Bcalcular"
        Me.Bcalcular.Size = New System.Drawing.Size(75, 23)
        Me.Bcalcular.TabIndex = 0
        Me.Bcalcular.Text = "Calcular"
        Me.Bcalcular.UseVisualStyleBackColor = False
        '
        'Blimpiar
        '
        Me.Blimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Blimpiar.Location = New System.Drawing.Point(449, 185)
        Me.Blimpiar.Name = "Blimpiar"
        Me.Blimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Blimpiar.TabIndex = 1
        Me.Blimpiar.Text = "Limpiar"
        Me.Blimpiar.UseVisualStyleBackColor = False
        '
        'Bsalir
        '
        Me.Bsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Bsalir.Location = New System.Drawing.Point(449, 240)
        Me.Bsalir.Name = "Bsalir"
        Me.Bsalir.Size = New System.Drawing.Size(75, 23)
        Me.Bsalir.TabIndex = 2
        Me.Bsalir.Text = "Salir"
        Me.Bsalir.UseVisualStyleBackColor = False
        '
        'GBtalla
        '
        Me.GBtalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBtalla.Controls.Add(Me.RBlarge)
        Me.GBtalla.Controls.Add(Me.RBmedium)
        Me.GBtalla.Controls.Add(Me.RBsmall)
        Me.GBtalla.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBtalla.Location = New System.Drawing.Point(38, 115)
        Me.GBtalla.Name = "GBtalla"
        Me.GBtalla.Size = New System.Drawing.Size(150, 185)
        Me.GBtalla.TabIndex = 3
        Me.GBtalla.TabStop = False
        Me.GBtalla.Text = "Talla"
        '
        'RBlarge
        '
        Me.RBlarge.AutoSize = True
        Me.RBlarge.Location = New System.Drawing.Point(51, 131)
        Me.RBlarge.Name = "RBlarge"
        Me.RBlarge.Size = New System.Drawing.Size(68, 24)
        Me.RBlarge.TabIndex = 2
        Me.RBlarge.TabStop = True
        Me.RBlarge.Text = "Large"
        Me.RBlarge.UseVisualStyleBackColor = True
        '
        'RBmedium
        '
        Me.RBmedium.AutoSize = True
        Me.RBmedium.Location = New System.Drawing.Point(51, 89)
        Me.RBmedium.Name = "RBmedium"
        Me.RBmedium.Size = New System.Drawing.Size(88, 24)
        Me.RBmedium.TabIndex = 1
        Me.RBmedium.TabStop = True
        Me.RBmedium.Text = "Medium"
        Me.RBmedium.UseVisualStyleBackColor = True
        '
        'RBsmall
        '
        Me.RBsmall.AutoSize = True
        Me.RBsmall.Location = New System.Drawing.Point(51, 45)
        Me.RBsmall.Name = "RBsmall"
        Me.RBsmall.Size = New System.Drawing.Size(66, 24)
        Me.RBsmall.TabIndex = 0
        Me.RBsmall.TabStop = True
        Me.RBsmall.Text = "Small"
        Me.RBsmall.UseVisualStyleBackColor = True
        '
        'GBtela
        '
        Me.GBtela.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GBtela.Controls.Add(Me.RBlona)
        Me.GBtela.Controls.Add(Me.RBseda)
        Me.GBtela.Controls.Add(Me.RBalgodon)
        Me.GBtela.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBtela.Location = New System.Drawing.Point(230, 115)
        Me.GBtela.Name = "GBtela"
        Me.GBtela.Size = New System.Drawing.Size(150, 185)
        Me.GBtela.TabIndex = 4
        Me.GBtela.TabStop = False
        Me.GBtela.Text = "Tela"
        '
        'RBlona
        '
        Me.RBlona.AutoSize = True
        Me.RBlona.Location = New System.Drawing.Point(51, 131)
        Me.RBlona.Name = "RBlona"
        Me.RBlona.Size = New System.Drawing.Size(62, 24)
        Me.RBlona.TabIndex = 2
        Me.RBlona.TabStop = True
        Me.RBlona.Text = "Lona"
        Me.RBlona.UseVisualStyleBackColor = True
        '
        'RBseda
        '
        Me.RBseda.AutoSize = True
        Me.RBseda.Location = New System.Drawing.Point(51, 89)
        Me.RBseda.Name = "RBseda"
        Me.RBseda.Size = New System.Drawing.Size(63, 24)
        Me.RBseda.TabIndex = 1
        Me.RBseda.TabStop = True
        Me.RBseda.Text = "Seda"
        Me.RBseda.UseVisualStyleBackColor = True
        '
        'RBalgodon
        '
        Me.RBalgodon.AutoSize = True
        Me.RBalgodon.Location = New System.Drawing.Point(51, 45)
        Me.RBalgodon.Name = "RBalgodon"
        Me.RBalgodon.Size = New System.Drawing.Size(95, 24)
        Me.RBalgodon.TabIndex = 0
        Me.RBalgodon.TabStop = True
        Me.RBalgodon.Text = "Algodón "
        Me.RBalgodon.UseVisualStyleBackColor = True
        '
        'Lingreso
        '
        Me.Lingreso.AutoSize = True
        Me.Lingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lingreso.Location = New System.Drawing.Point(47, 23)
        Me.Lingreso.Name = "Lingreso"
        Me.Lingreso.Size = New System.Drawing.Size(344, 20)
        Me.Lingreso.TabIndex = 3
        Me.Lingreso.Text = "Ingrese la cantidad de chumpas a realizar"
        '
        'TBcantidad
        '
        Me.TBcantidad.Location = New System.Drawing.Point(51, 68)
        Me.TBcantidad.Name = "TBcantidad"
        Me.TBcantidad.Size = New System.Drawing.Size(100, 20)
        Me.TBcantidad.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201801457_CHUMPAS.My.Resources.Resources.ropa_listado_belleza_848x477x80xX
        Me.ClientSize = New System.Drawing.Size(623, 324)
        Me.Controls.Add(Me.Lingreso)
        Me.Controls.Add(Me.TBcantidad)
        Me.Controls.Add(Me.GBtela)
        Me.Controls.Add(Me.Bcalcular)
        Me.Controls.Add(Me.Bsalir)
        Me.Controls.Add(Me.GBtalla)
        Me.Controls.Add(Me.Blimpiar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBtalla.ResumeLayout(False)
        Me.GBtalla.PerformLayout()
        Me.GBtela.ResumeLayout(False)
        Me.GBtela.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bcalcular As Button
    Friend WithEvents Blimpiar As Button
    Friend WithEvents Bsalir As Button
    Friend WithEvents GBtalla As GroupBox
    Friend WithEvents RBlarge As RadioButton
    Friend WithEvents RBmedium As RadioButton
    Friend WithEvents RBsmall As RadioButton
    Friend WithEvents GBtela As GroupBox
    Friend WithEvents RBlona As RadioButton
    Friend WithEvents RBseda As RadioButton
    Friend WithEvents RBalgodon As RadioButton
    Friend WithEvents Lingreso As Label
    Friend WithEvents TBcantidad As TextBox
End Class
