Public Class Form1
    Private Sub Bcalcular_Click(sender As Object, e As EventArgs) Handles Bcalcular.Click


        If TBcantidad.Text = "" Then
            MsgBox("No se ha ingresado una cantidad")
        End If


        If RBsmall.Checked = False And RBmedium.Checked = False And RBlarge.Checked = False Then

            MsgBox("No se ha seleccionado una talla")


        End If

        If RBalgodon.Checked = False And RBseda.Checked = False And RBlona.Checked = False Then

            MsgBox("No se ha selecionado el tipo de tela")

        End If


        Dim tamaño As String
        Dim tipo As String

        If RBsmall.Checked Then

            tamaño = "Small"

        ElseIf RBmedium.Checked Then
            tamaño = "Medium"

        Else
            tamaño = "Large"

        End If

        If RBseda.Checked Then
            tipo = "Seda"
        ElseIf RBalgodon.Checked Then
            tipo = "Algodón"
        Else
            tipo = "Lona"
        End If

        calcular(tamaño, tipo, Val(TBcantidad.Text))
        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBcantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Blimpiar_Click(sender As Object, e As EventArgs) Handles Blimpiar.Click

        limpiar()

    End Sub

    Private Sub Bsalir_Click(sender As Object, e As EventArgs) Handles Bsalir.Click
        If MsgBox("Desea salir", vbQuestion + vbYesNo, "Mensaje Salida") = vbYes Then
            End
        Else
            limpiar()


        End If
    End Sub
End Class
