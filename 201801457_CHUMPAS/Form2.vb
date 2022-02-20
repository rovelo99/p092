Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TBcosto.Text = costo
        TBventa.Text = venta


    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        Form1.Show()

        Me.Close()

    End Sub

    Private Sub Lcosto_Click(sender As Object, e As EventArgs) Handles Lcosto.Click

    End Sub
End Class