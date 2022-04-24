Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If ((comprobar_repetido())) Then
            If (fila <= 6) Then

                If (RBnormal.Checked) Then
                    cliente(fila, 3) = RBnormal.Text
                ElseIf (RB3d.Checked) Then
                    cliente(fila, 3) = RB3d.Text
                ElseIf (RB4dx.Checked) Then
                    cliente(fila, 3) = RB4dx.Text

                Else
                    MsgBox("Error, no seleccionó tipo de sala")
                    Exit Sub
                End If

                If (IsNumeric(tbnit.Text)) Then
                    cliente(fila, 0) = tbnit.Text
                Else
                    MsgBox("Error numero de nit")
                    limpiar_fila()
                    tbnit.Focus()
                    Exit Sub
                End If
                If (tbpelicula.Text <> "") Then
                    cliente(fila, 1) = tbpelicula.Text
                Else
                    MsgBox("Error nombre pelicula")
                    limpiar_fila()
                    tbpelicula.Focus()
                    Exit Sub
                End If
                If (IsNumeric(tbboletos.Text)) Then
                    cliente(fila, 2) = tbboletos.Text
                Else
                    MsgBox("Error numero de boletos")
                    limpiar_fila()
                    tbboletos.Focus()
                    Exit Sub
                End If

                If (RBnormal.Checked) Then
                    cliente(fila, 4) = 44
                ElseIf (RB3d.Checked) Then
                    cliente(fila, 4) = 62
                ElseIf (RB4dx.Checked) Then
                    cliente(fila, 4) = 104

                Else
                    MsgBox("Error, no selecciono tipo de boleto")
                    Exit Sub
                End If
                fila = fila + 1
                    limpiar_entradas()
                End If
            Else
            MsgBox("nit repetido no se puede ingresar")
            tbnit.Focus()
        End If
        If (fila = 6) Then
            MsgBox("Matriz llena")
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click


        I = 0

        While (I <= 4)

            cliente(fila, I) = Nothing
            I = I + 1
        End While


        I = fila
        While (I <= 5)

            cliente(I, 0) = cliente(I + 1, 0)
            cliente(I, 1) = cliente(I + 1, 1)
            cliente(I, 2) = cliente(I + 1, 2)
            cliente(I, 3) = cliente(I + 1, 3)
            cliente(I, 4) = cliente(I + 1, 4)

            I = I + 1
        End While
        MsgBox("Registro Eliminado exitosamente")

        cliente(I, 0) = Nothing
        cliente(I, 1) = Nothing
        cliente(I, 2) = Nothing
        cliente(I, 3) = Nothing
        cliente(I, 4) = Nothing


        fila = I

        limpiar_entradas()
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click
        mostrar_matriz()

    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click

        Dim existe As Boolean = True


        I = 0

        While (I <= 6) And (existe)

            If (cliente(I, 0) <> Nothing) Then
                If (Val(cliente(I, 0)) = Val(TBconsulta.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("Numero de nir no contrado")
            TBconsulta.Focus()
        Else
            MsgBox("nit encontrado")

            tbnit.Text = cliente(I, 0)
            tbpelicula.Text = cliente(I, 1)
            tbboletos.Text = cliente(I, 2)


            If (cliente(I, 3) = "Normal") Then

                RBnormal.Checked = True
            ElseIf (cliente(I, 3) = "3D") Then
                RB3d.Checked = True
            ElseIf (cliente(I, 3) = "4DX") Then
                RB4dx.Checked = True

            End If


            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(cliente(I, 0), cliente(I, 1), cliente(I, 2), cliente(I, 3), cliente(I, 4))

            fila = I
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click



        cliente(fila, 0) = tbnit.Text
        cliente(fila, 1) = tbpelicula.Text
        cliente(fila, 2) = tbboletos.Text

        'se determina cual fue el curso seleccionado para guardarlo en la columna respectiva
        If (RBnormal.Checked) Then
            cliente(fila, 3) = RBnormal.Text
            cliente(fila, 4) = 44
        ElseIf (RB3d.Checked) Then
            cliente(fila, 3) = RB3d.Text
            cliente(fila, 4) = 62
        ElseIf (RB4dx.Checked) Then
            cliente(fila, 3) = RB4dx.Text
            cliente(fila, 4) = 104

        End If



        MsgBox("Registro actualizado correctamente en la matriz")
        fila = 7

        limpiar_entradas()
    End Sub

    Private Sub EliminarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarMatrizToolStripMenuItem.Click
        limpiar_matriz()

    End Sub
End Class
