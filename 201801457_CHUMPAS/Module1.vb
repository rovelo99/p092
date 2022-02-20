Module Module1

    Public Const mano_small = 65.5
    Public Const mano_medium = 85.99
    Public Const mano_large = 99.99


    Public Const costo_algodon = 15.0
    Public Const costo_seda = 23.99
    Public Const costo_lona = 30.99


    Public Const yarda_small = 2
    Public Const yarda_medium = 2.5
    Public Const yarda_large = 3

    Public costo = 0
    Public venta = 0

    Public Sub calcular(tamaño As String, tipo As String, Cantidad As Double)

        Select Case tamaño
            Case "Small"
                Select Case tipo
                    Case "Algodón"
                        costo = Cantidad * mano_small + Cantidad * costo_algodon * yarda_small

                    Case "Seda"

                        costo = Cantidad * mano_small + Cantidad * costo_seda * yarda_small

                    Case "Lona"
                        costo = Cantidad * mano_small + Cantidad * costo_lona * yarda_small

                End Select

            Case "Medium"
                Select Case tipo
                    Case "Algodón"
                        costo = Cantidad * mano_medium + Cantidad * costo_algodon * yarda_medium

                    Case "Seda"

                        costo = Cantidad * mano_medium + Cantidad * costo_seda * yarda_medium

                    Case "Lona"
                        costo = Cantidad * mano_medium + Cantidad * costo_lona * yarda_medium

                End Select

            Case "Large"
                Select Case tipo
                    Case "Algodón"
                        costo = Cantidad * mano_large + Cantidad * costo_algodon * yarda_large

                    Case "Seda"

                        costo = Cantidad * mano_large + Cantidad * costo_seda * yarda_large

                    Case "Lona"
                        costo = Cantidad * mano_large + Cantidad * costo_lona * yarda_large

                End Select


        End Select

        venta = costo + 0.65 * costo



    End Sub


    Sub limpiar()

        Form1.TBcantidad.Clear()

        Form1.RBsmall.Checked = False
        Form1.RBmedium.Checked = False
        Form1.RBlarge.Checked = False

        Form1.RBalgodon.Checked = False
        Form1.RBseda.Checked = False
        Form1.RBlona.Checked = False


    End Sub


End Module
