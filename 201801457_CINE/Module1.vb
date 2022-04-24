Module Module1

    Public cliente(6, 4) As String
    Public fila As Byte = 0
    Public I As Byte



    Sub Mostrar_Matriz()

        Form1.DataGridView1.Rows.Clear()

        While (I <= 6)

            If (cliente(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(cliente(I, 0), cliente(I, 1), cliente(I, 2), cliente(I, 3), cliente(I, 4))
            Else

                Exit While
            End If

            I = I + 1
        End While
    End Sub



    Sub limpiar_matriz()

        Form1.DataGridView1.Rows.Clear()

        fila = 0

        I = 0

        While (I <= 6)
            cliente(I, 0) = Nothing
            cliente(I, 1) = Nothing
            cliente(I, 2) = Nothing
            cliente(I, 3) = Nothing
            cliente(I, 4) = Nothing

            I = I + 1
        End While


    End Sub


    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        I = 0
        comprobar_repetido = True
        While (I <= 6) And (encontrado)

            If (cliente(I, 0) <> Nothing) Then

                If (cliente(I, 0) = Val(Form1.tbnit.Text)) Then
                    comprobar_repetido = encontrado = False
                    Return comprobar_repetido
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While

        If (encontrado) Then
            Return comprobar_repetido
        End If

    End Function


    Sub limpiar_fila()
        Dim x As Byte = 0

        While (x <= 4)
            cliente(fila, x) = Nothing
            x = x + 1
        End While

    End Sub


    Sub limpiar_entradas()
        'procedimiento que limpia los objetos de entrada
        Form1.tbnit.Clear()
        Form1.tbpelicula.Clear()
        Form1.tbboletos.Clear()

        Form1.RBnormal.Checked = False
        Form1.RB3d.Checked = False
        Form1.RB4dx.Checked = False

        Form1.tbnit.Focus()

    End Sub
End Module
