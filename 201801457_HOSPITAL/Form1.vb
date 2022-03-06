Public Class Form1
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox10_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBtotal.SelectedIndexChanged

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click


        If (indice <= 5) Then

            persona(indice) = TBnombre.Text
            nit(indice) = Val(InputBox("Ingrese NIT"))
            dias(indice) = Val(InputBox("Ingrese la cantidad de dias en el hospital"))
            honorarios(indice) = InputBox("Ingrese los honorarios del medico")
            habitacion(indice) = CBhabitacion.Text
            servicio(indice) = CBservicio.Text





        End If



    End Sub
End Class
