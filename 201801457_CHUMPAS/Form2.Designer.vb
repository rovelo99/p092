<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Lcosto = New System.Windows.Forms.Label()
        Me.TBcosto = New System.Windows.Forms.TextBox()
        Me.TBventa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lcosto
        '
        Me.Lcosto.AutoSize = True
        Me.Lcosto.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lcosto.Location = New System.Drawing.Point(40, 92)
        Me.Lcosto.Name = "Lcosto"
        Me.Lcosto.Size = New System.Drawing.Size(361, 22)
        Me.Lcosto.TabIndex = 0
        Me.Lcosto.Text = "El precio de costo de las chumpas es de (Q)"
        '
        'TBcosto
        '
        Me.TBcosto.Location = New System.Drawing.Point(417, 95)
        Me.TBcosto.Name = "TBcosto"
        Me.TBcosto.Size = New System.Drawing.Size(100, 20)
        Me.TBcosto.TabIndex = 2
        '
        'TBventa
        '
        Me.TBventa.Location = New System.Drawing.Point(417, 209)
        Me.TBventa.Name = "TBventa"
        Me.TBventa.Size = New System.Drawing.Size(100, 20)
        Me.TBventa.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "El precio de venta de las chumpas es de (Q)"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201801457_CHUMPAS.My.Resources.Resources._1366_2000__1_
        Me.ClientSize = New System.Drawing.Size(582, 321)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBventa)
        Me.Controls.Add(Me.TBcosto)
        Me.Controls.Add(Me.Lcosto)
        Me.Name = "Form2"
        Me.Text = "Resultado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lcosto As Label
    Friend WithEvents TBcosto As TextBox
    Friend WithEvents TBventa As TextBox
    Friend WithEvents Label1 As Label
End Class
