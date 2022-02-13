Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lcompra.Enabled = False
        TBcompra.Enabled = False
        Lventa.Enabled = False
        TBventa.Enabled = False
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TBcompra.TextChanged

    End Sub

    Private Sub cbCompra_CheckedChanged(sender As Object, e As EventArgs) Handles cbCompra.CheckedChanged

        If cbCompra.Checked = True Then
            Lcompra.Enabled = True
            TBcompra.Enabled = True
            GB3.Enabled = True
        Else
            Lcompra.Enabled = False
            TBcompra.Enabled = False
            GB3.Enabled = False

        End If
    End Sub

    Private Sub cbVenta_CheckedChanged(sender As Object, e As EventArgs) Handles cbVenta.CheckedChanged

        If cbVenta.Checked = True Then
            Lventa.Enabled = True
            TBventa.Enabled = True
            GB4.Enabled = True

        Else
            Lventa.Enabled = False
            TBventa.Enabled = False
            GB4.Enabled = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RBcolon.CheckedChanged

    End Sub

    Private Sub Bcalcular_Click(sender As Object, e As EventArgs) Handles Bcalcular.Click



        Form2.Show()
        Me.Hide()


    End Sub

    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles Blimpiar.Click
        limpiar()

    End Sub

    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click
        Close()
    End Sub
End Class
