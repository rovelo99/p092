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
        Me.LresultadoCompra = New System.Windows.Forms.Label()
        Me.LresultadoVenta = New System.Windows.Forms.Label()
        Me.Lninguna = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LresultadoCompra
        '
        Me.LresultadoCompra.AutoSize = True
        Me.LresultadoCompra.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LresultadoCompra.Location = New System.Drawing.Point(22, 53)
        Me.LresultadoCompra.Name = "LresultadoCompra"
        Me.LresultadoCompra.Size = New System.Drawing.Size(152, 13)
        Me.LresultadoCompra.TabIndex = 0
        Me.LresultadoCompra.Text = "No hay transaccion de compra"
        '
        'LresultadoVenta
        '
        Me.LresultadoVenta.AutoSize = True
        Me.LresultadoVenta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LresultadoVenta.Location = New System.Drawing.Point(22, 97)
        Me.LresultadoVenta.Name = "LresultadoVenta"
        Me.LresultadoVenta.Size = New System.Drawing.Size(144, 13)
        Me.LresultadoVenta.TabIndex = 1
        Me.LresultadoVenta.Text = "No hay transaccion de venta"
        '
        'Lninguna
        '
        Me.Lninguna.AutoSize = True
        Me.Lninguna.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lninguna.Location = New System.Drawing.Point(22, 130)
        Me.Lninguna.Name = "Lninguna"
        Me.Lninguna.Size = New System.Drawing.Size(211, 52)
        Me.Lninguna.TabIndex = 2
        Me.Lninguna.Text = "No se realizo alguna" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " transaccion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECIONES E INTRODUSCA VALORES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(263, 231)
        Me.Controls.Add(Me.Lninguna)
        Me.Controls.Add(Me.LresultadoVenta)
        Me.Controls.Add(Me.LresultadoCompra)
        Me.Name = "Form2"
        Me.Text = "Resultados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LresultadoCompra As Label
    Friend WithEvents LresultadoVenta As Label
    Friend WithEvents Lninguna As Label
End Class
