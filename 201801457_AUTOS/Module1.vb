Module Module1

    Public carro(4, 5) As String

    Public fila As Byte = 0

    Public I As Byte

    Public kms As Byte

    Public cuenta As Byte

    Function comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        I = 0
        comprobar_repetido = True
        While (I <= 4) And (encontrado)

            If (carro(I, 0) <> Nothing) Then

                If (carro(I, 3) = Val(Form1.TBplaca.Text)) Then

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



    Sub Mostrar_Matriz()

        Form1.DataGridView1.Rows.Clear()

        I = 0
        While (I <= 4)

            If (carro(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(carro(I, 0), carro(I, 1), carro(I, 2), carro(I, 3), carro(I, 4), carro(I, 5))
            Else

                Exit While
            End If

            I = I + 1
        End While
    End Sub




    Sub limpiar_entradas()


        Form1.TBinicial.Clear()
        Form1.TBfinal.Clear()
        Form1.TBplaca.Clear()

    End Sub


    Sub limpiar_matriz()


        Form1.DataGridView1.Rows.Clear()

        fila = 0

        I = 0

        While (I <= 4)
            carro(I, 0) = Nothing
            carro(I, 1) = Nothing
            carro(I, 2) = Nothing
            carro(I, 3) = Nothing
            carro(I, 4) = Nothing
            carro(I, 5) = Nothing


            I = I + 1
        End While


    End Sub


    Sub limpiar_fila()
        Dim x As Byte = 0

        While (x <= 5)
            carro(fila, x) = Nothing
            x = x + 1
        End While

    End Sub
End Module
