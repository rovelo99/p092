Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub IngresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarToolStripMenuItem.Click

        If ((comprobar_repetido())) Then
            If (fila <= 4) Then

                If (IsNumeric(TBplaca.Text)) Then
                    carro(fila, 3) = TBplaca.Text
                Else
                    MsgBox("Error de placa")
                    limpiar_fila()
                    TBplaca.Focus()
                    Exit Sub
                End If
                If (TBinicial.Text <> "") Then
                    carro(fila, 1) = TBinicial.Text
                Else
                    MsgBox("Error km inicial")
                    limpiar_fila()
                    TBinicial.Focus()
                    Exit Sub
                End If
                If (TBfinal.Text <> "") Then
                    carro(fila, 2) = TBfinal.Text
                Else
                    MsgBox("Error km final")
                    limpiar_fila()
                    TBfinal.Focus()
                    Exit Sub
                End If

                carro(fila, 0) = CBtipo.Text

                If CBtipo.Text = "tipo 1" Then

                    carro(fila, 4) = 500

                    kms = Val(TBfinal.Text) - Val(TBinicial.Text)

                    If kms < 51 Then

                        cuenta = kms * 3

                    ElseIf kms < 71 Then

                        cuenta = kms * 4
                    Else
                        cuenta = kms * 5

                    End If

                    carro(fila, 5) = carro(fila, 4) + cuenta
                End If

                If CBtipo.Text = "tipo 2" Then

                    carro(fila, 4) = 400

                    kms = Val(TBfinal.Text) - Val(TBinicial.Text)

                    If kms < 51 Then

                        cuenta = kms * 3

                    ElseIf kms < 71 Then

                        cuenta = kms * 4
                    Else
                        cuenta = kms * 5

                    End If

                    carro(fila, 5) = carro(fila, 4) + cuenta
                End If

                If CBtipo.Text = "tipo 3" Then

                    carro(fila, 4) = 300

                    kms = Val(TBfinal.Text) - Val(TBinicial.Text)

                    If kms < 51 Then

                        cuenta = kms * 3

                    ElseIf kms < 71 Then

                        cuenta = kms * 4
                    Else
                        cuenta = kms * 5

                    End If

                    carro(fila, 5) = carro(fila, 4) + cuenta
                End If

                If CBtipo.Text = "tipo 4" Then

                    carro(fila, 4) = 200

                    kms = Val(TBfinal.Text) - Val(TBinicial.Text)

                    If kms < 51 Then

                        cuenta = kms * 3

                    ElseIf kms < 71 Then

                        cuenta = kms * 4
                    Else
                        cuenta = kms * 5

                    End If

                    carro(fila, 5) = carro(fila, 4) + cuenta
                End If




            Else
                    MsgBox("placa repetida, ingrese otro numero de placa")
                TBplaca.Focus()
            End If
        End If
        If (fila = 5) Then
            MsgBox("Matriz llena")
        End If

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        Mostrar_Matriz()

    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click

        Dim existe As Boolean = True


        I = 0

        While (I <= 4) And (existe)

            If (carro(I, 3) <> Nothing) Then
                If (Val(carro(I, 3)) = Val(TBplaca.Text)) Then
                    existe = False
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While

        If (existe) Then
            MsgBox("placa no encontrada")
            TBplaca.Focus()
        Else
            MsgBox("placa encontrada")


            TBinicial.Text = carro(I, 1)
            TBfinal.Text = carro(I, 2)
            TBplaca.Text = carro(I, 3)
            CBtipo.Text = carro(I, 0)






            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(carro(I, 0), carro(I, 1), carro(I, 2), carro(I, 3), carro(I, 4), carro(I, 5))

            fila = I
        End If
    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click

        carro(fila, 0) = CBtipo.Text
        carro(fila, 1) = TBinicial.Text
        carro(fila, 2) = TBfinal.Text
        carro(fila, 3) = TBplaca.Text



        If CBtipo.Text = "tipo 1" Then

            carro(fila, 4) = 500

            kms = Val(TBfinal.Text) - Val(TBinicial.Text)

            If kms < 51 Then

                cuenta = kms * 3

            ElseIf kms < 71 Then

                cuenta = kms * 4
            Else
                cuenta = kms * 5

            End If

            carro(fila, 5) = carro(fila, 4) + cuenta

        End If

        If CBtipo.Text = "tipo 2" Then

            carro(fila, 4) = 400

            kms = Val(TBfinal.Text) - Val(TBinicial.Text)

            If kms < 51 Then

                cuenta = kms * 3

            ElseIf kms < 71 Then

                cuenta = kms * 4
            Else
                cuenta = kms * 5

            End If

            carro(fila, 5) = carro(fila, 4) + cuenta
        End If

        If CBtipo.Text = "tipo 3" Then

            carro(fila, 4) = 300

            kms = Val(TBfinal.Text) - Val(TBinicial.Text)

            If kms < 51 Then

                cuenta = kms * 3

            ElseIf kms < 71 Then

                cuenta = kms * 4
            Else
                cuenta = kms * 5

            End If

            carro(fila, 5) = carro(fila, 4) + cuenta
        End If

        If CBtipo.Text = "tipo 4" Then

            carro(fila, 4) = 200

            kms = Val(TBfinal.Text) - Val(TBinicial.Text)

            If kms < 51 Then

                cuenta = kms * 3

            ElseIf kms < 71 Then

                cuenta = kms * 4
            Else
                cuenta = kms * 5

            End If

            carro(fila, 5) = carro(fila, 4) + cuenta
        End If



        MsgBox("Registro actualizado correctamente en la matriz")
        fila = 5

        limpiar_entradas()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        I = 0

        While (I <= 5)

            carro(fila, I) = Nothing
            I = I + 1
        End While


        I = fila
        While (I <= 3)

            carro(I, 0) = carro(I + 1, 0)
            carro(I, 1) = carro(I + 1, 1)
            carro(I, 2) = carro(I + 1, 2)
            carro(I, 3) = carro(I + 1, 3)
            carro(I, 4) = carro(I + 1, 4)
            carro(I, 5) = carro(I + 1, 5)

            I = I + 1
        End While
        MsgBox("Registro Eliminado exitosamente")

        carro(I, 0) = Nothing
        carro(I, 1) = Nothing
        carro(I, 2) = Nothing
        carro(I, 3) = Nothing
        carro(I, 4) = Nothing
        carro(I, 5) = Nothing


        fila = I

        limpiar_entradas()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click

    End Sub
End Class
