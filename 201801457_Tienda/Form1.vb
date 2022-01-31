Public Class Form1

    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.75
    Const iva As Double = 0.12

    Dim pagoSinVida As Double = 0
    Dim valorIva As Double = 0
    Dim descuento As Double = 0
    Dim pagoTotal As Double = 0
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles AZUCAR.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LBdescuento.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub TXT1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub TXT3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXT2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BT1_Click(sender As Object, e As EventArgs) Handles BT1.Click
        pagoSinVida = (TXT1.Text * precioArroz) + (TXT2.Text * precioAzucar
            ) + (TXT3.Text * precioFrijol)
        descuento = pagoSinVida * 0.025
        valorIva = (pagoSinVida - descuento) * 0.12
        pagoTotal = (valorIva + (pagoSinVida - descuento))
        MsgBox(pagoSinVida)
        LBantesIva.Text = pagoSinVida
        LBdescuento.Text = descuento
        LBantesIva.Text = valorIva
        LBtotal.Text = pagoTotal




    End Sub

    Private Sub BT2_Click(sender As Object, e As EventArgs) Handles BT2.Click
        LBantesIva.Text = 0
        LBdescuento.Text = 0
        LBantesIva.Text = 0
        LBtotal.Text = 0

        TXT1.Text = 0
        TXT2.Text = 0
        TXT3.Text = 0


    End Sub

    Private Sub BT3_Click(sender As Object, e As EventArgs) Handles BT3.Click

    End Sub
End Class
