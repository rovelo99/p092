Module Module1
    Public matriz(7, 5)

    Public FILA As Byte = 0
    Public I As Byte


    Sub Limpiar_entradas()
        Form1.TBnit.Clear()
        Form1.TBnombre.Clear()
        Form1.TBpersonas.Clear()

        Form1.RBestadar.Checked = False
        Form1.RBaire.Checked = False
        Form1.RBjacuzzi.Checked = False
        Form1.TBnit.Focus()

    End Sub

    Sub Mostrar_matriz()
        Dim i As Byte
        Form1.DataGridView1.Rows.Clear()
        For i = 0 To 6
            If matriz(i, 0) <> Nothing Then
                Form1.DataGridView1.Rows.Add(matriz(i, 0), matriz(i, 1), matriz(i, 2), matriz(i, 3), matriz(i, 4))
            Else
                Exit For
            End If
        Next i
    End Sub

    Function Comprobar_repetido() As Boolean
        Dim encontrado As Boolean = True

        I = 0
        Comprobar_repetido = True
        While (I <= 6) And (encontrado)

            If (matriz(I, 0) <> Nothing) Then

                If (matriz(I, 0) = Val(Form1.TBnit.Text)) Then
                    Comprobar_repetido = encontrado = False
                    Return Comprobar_repetido
                Else
                    I = I + 1
                End If
            Else
                Exit While
            End If
        End While
        If (encontrado) Then
            Return Comprobar_repetido
        End If

    End Function



End Module
