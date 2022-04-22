Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GBdatos.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CALCULOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULOToolStripMenuItem.Click
        If (fila <= 6) Then
            nombre(fila) = TBnombre.Text
            nit(fila) = Val(TBnit.Text)
            dias(fila) = Val(TBdias.Text)
            impuesto(fila) = ComboBox1.Text
            pago(fila) = ComboBox2.Text
            fila = fila + 1
        End If

        If (fila = 6) Then
            MsgBox("vectores llenos")
        End If
    End Sub
End Class
