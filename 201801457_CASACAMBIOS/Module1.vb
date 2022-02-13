Module Module1


    Public Const dolar = 7.69
    Public Const pesos = 0.38
    Public Const euro = 8.79
    Public Const colon = 0.012

    Public Const comision_compra = (2.5 / 100)
    Public Const comision_venta = (3 / 100)
    Dim total_p = 0
    Dim total = 0



    Sub limpiar()

        Form1.TBcompra.Clear()
        Form1.TBventa.Clear()
        Form1.cbCompra.Checked = False
        Form1.cbVenta.Checked = False

    End Sub


    Function Comprar(Qtz As Double, Mcomprada As Double)
        If Qtz >= 0 Then
            total_p = Qtz / Mcomprada
            total = total_p * comision_compra + total_p
        End If
        Return Math.Round(total, 2)
    End Function

    Function Vender(Qtz As Double, Mcomprada As Double)
        If Qtz >= 0 Then
            total_p = Qtz * Mcomprada
            total = total_p * comision_venta + total_p
        End If
        Return Math.Round(total, 2)
    End Function




End Module
