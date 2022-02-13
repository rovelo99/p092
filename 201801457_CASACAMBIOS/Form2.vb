Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.RBdolar.Checked And Form1.cbCompra.Checked Then
            LresultadoCompra.Text = "La cantidad de tu compra es: " + Str(Comprar(Form1.TBcompra.Text, dolar))
            Lninguna.Hide()

        ElseIf Form1.RBpesos.Checked And Form1.cbCompra.Checked Then
            LresultadoCompra.Text = "La cantidad de tu compra es: " + Str(Comprar(Form1.TBcompra.Text, pesos))
            Lninguna.Hide()

        ElseIf Form1.RBeuro.Checked And Form1.cbCompra.Checked Then
            LresultadoCompra.Text = "La cantidad de tu compra es: " + Str(Comprar(Form1.TBcompra.Text, euro))
            Lninguna.Hide()

        ElseIf Form1.RBcolon.Checked And Form1.cbCompra.Checked Then
            LresultadoCompra.Text = "La cantidad de tu compra es: " + Str(Comprar(Form1.TBcompra.Text, colon))
            Lninguna.Hide()

        Else
            Lninguna.Enabled = True
        End If

        If Form1.RBdolarV.Checked And Form1.cbVenta.Checked Then
            LresultadoVenta.Text = "La cantidad de tu venta es: " + Str(Vender(Form1.TBventa.Text, dolar))
            Lninguna.Hide()

        ElseIf Form1.RBpesosV.Checked And Form1.cbVenta.Checked Then
            LresultadoVenta.Text = "La cantidad de tu venta es: " + Str(Vender(Form1.TBventa.Text, pesos))
            Lninguna.Hide()

        ElseIf Form1.RBeuroV.Checked And Form1.cbVenta.Checked Then
            LresultadoVenta.Text = "La cantidad de tu venta es: " + Str(Vender(Form1.TBventa.Text, euro))
            Lninguna.Hide()

        ElseIf Form1.RBcolonV.Checked And Form1.cbVenta.Checked Then
            LresultadoVenta.Text = "La cantidad de tu venta es: " + Str(Vender(Form1.TBventa.Text, colon))
            Lninguna.Hide()

        Else
            Lninguna.Enabled = True

        End If






    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Lninguna_Click(sender As Object, e As EventArgs) Handles Lninguna.Click

    End Sub
End Class