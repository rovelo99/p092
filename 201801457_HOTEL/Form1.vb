Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click

        If (FILA <= 6) Then
            If (Not (Comprobar_repetido())) Then
                MsgBox("El numero de nit ingresedo, ya se encuentra registrado")
                TBnit.Focus()
            Else
                matriz(FILA, 0) = TBnit.Text
                matriz(FILA, 1) = TBnombre.Text
                matriz(FILA, 2) = TBpersonas.Text
                If (RBestadar.Checked) Then
                    matriz(FILA, 3) = RBestadar.Text
                ElseIf (RBaire.Checked) Then
                    matriz(FILA, 3) = RBaire.Text
                Else
                    matriz(FILA, 3) = RBjacuzzi
                End If

                If (Val(TBpersonas.Text) > 4) Then

                    Select Case True
                        Case RBestadar.Checked : matriz(FILA, 4) = Str(250 + (Val(matriz(FILA, 2)) - 4) * 60)
                        Case RBaire.Checked : matriz(FILA, 4) = Str(290 + (Val(matriz(FILA, 2)) - 4) * 60)
                        Case RBjacuzzi.Checked : matriz(FILA, 4) = Str(370 + (Val(matriz(FILA, 2)) - 4) * 60)
                    End Select

                Else

                    Select Case True
                        Case RBestadar.Checked : matriz(FILA, 4) = Str(250 + (Val(matriz(FILA, 2))))
                        Case RBaire.Checked : matriz(FILA, 4) = Str(290 + (Val(matriz(FILA, 2))))
                        Case RBjacuzzi.Checked : matriz(FILA, 4) = Str(370 + (Val(matriz(FILA, 2))))
                    End Select

                End If


                FILA += 1
            End If
        End If
        If (FILA = 7) Then
            MsgBox("MATRIZ LLENA")
        End If
        limpiar_entradas()
    End Sub

    Private Sub MostrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarToolStripMenuItem.Click

        Mostrar_matriz()

        limpiar_entradas()


    End Sub

    Private Sub OrdenarDescendenteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDescendenteToolStripMenuItem.Click


        Dim i As Byte
        Dim j As Byte
        Dim temp1 As String
        For i = 0 To 5
            For j = i + 1 To 6

                If (matriz(j, 0) <> Nothing) Then
                    If (Val(matriz(i, 0)) > Val(matriz(j, 0))) Then
                        temp1 = matriz(i, 0)
                        matriz(i, 0) = matriz(j, 0)
                        matriz(j, 0) = temp1
                        temp1 = matriz(i, 1)
                        matriz(i, 1) = matriz(j, 1)
                        matriz(j, 1) = temp1
                        temp1 = matriz(i, 2)
                        matriz(i, 2) = matriz(j, 2)
                        matriz(j, 2) = temp1
                        temp1 = matriz(i, 3)
                        matriz(i, 3) = matriz(j, 3)
                        matriz(j, 3) = temp1
                        temp1 = matriz(i, 4)
                        matriz(i, 4) = matriz(j, 4)
                        matriz(j, 4) = temp1
                    End If
                Else
                    Exit For
                End If
            Next j
        Next i
    End Sub

    Private Sub LimpiarMatrizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarMatrizToolStripMenuItem.Click

        FILA = 0

        While (FILA < 8)



            matriz(FILA, 0) = Nothing
            matriz(FILA, 1) = Nothing
            matriz(FILA, 2) = Nothing
            matriz(FILA, 3) = Nothing
            matriz(FILA, 4) = Nothing

            FILA += 1

        End While

        Limpiar_entradas()

            DataGridView1.Rows.Clear()




    End Sub

    Private Sub Bconsulta_Click(sender As Object, e As EventArgs)
        Dim I As Byte = 0
        Dim EXISTE As Boolean = True

        While (I <= 4) And (EXISTE)
            If (Val(matriz(I, 0)) = Val(TBconsulta.Text)) Then
                EXISTE = False
            Else
                I = I + 1
            End If
        End While
        If (EXISTE) Then
            MsgBox("Número de nit no se encuentra")
        Else
            TBnit.Text = matriz(I, 0)
            TBnombre.Text = matriz(I, 1)
            TBpersonas.Text = matriz(I, 2)
            '
            If (matriz(I, 3) = "Estandar") Then
                RBestadar.Checked = True
            ElseIf (matriz(I, 3) = "Aire Acondicionado") Then
                RBaire.Checked = True
            Else
                RBjacuzzi.Checked = True
            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(matriz(I, 0), matriz(I, 1), matriz(I, 2), matriz(I, 3), matriz(I, 4))

            FILA = I

            TBconsulta.Clear()
        End If
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim I As Byte = 0
        Dim EXISTE As Boolean = True

        While (I <= 4) And (EXISTE)
            If (Val(matriz(I, 0)) = Val(TBconsulta.Text)) Then
                EXISTE = False
            Else
                I = I + 1
            End If
        End While
        If (EXISTE) Then
            MsgBox("Número de nit no se encuentra")
        Else
            TBnit.Text = matriz(I, 0)
            TBnombre.Text = matriz(I, 1)
            TBpersonas.Text = matriz(I, 2)
            '
            If (matriz(I, 3) = "Estandar") Then
                RBestadar.Checked = True
            ElseIf (matriz(I, 3) = "Aire Acondicionado") Then
                RBaire.Checked = True
            Else
                RBjacuzzi.Checked = True
            End If

            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(matriz(I, 0), matriz(I, 1), matriz(I, 2), matriz(I, 3), matriz(I, 4))

            FILA = I

            TBconsulta.Clear()
        End If
    End Sub
End Class
