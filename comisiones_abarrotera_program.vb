Module Module1

    Sub Main()
        Dim nota_venta As String
        Dim tipo_pago, clave, salir As Byte
        Dim importe, contado(30), credito(30), sum_cont, sum_cred As Single

        Console.WriteLine("PROGRAMA PARA CÁLCULO DE COMISIONES A VENDEDORES")
        Console.WriteLine("------------------------------------------------")

        Do
            Console.WriteLine("Inserte la nota de venta.")
            nota_venta = Console.ReadLine()

            Console.WriteLine("¿Cuál es la clave del vendedor? Recuerde que solo son 30 vendedores.")
            clave = Console.ReadLine()

            If clave > 30 Or clave = 0 Then
                Console.WriteLine("Inserte un número válido.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            Console.WriteLine("¿Cuál fue el tipo de pago? (Escriba 1 si fue contado, 2 si fue crédito).")
            tipo_pago = Console.ReadLine()

            If tipo_pago > 2 Or tipo_pago = 0 Then
                Console.WriteLine("Inserte un número válido.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            Console.WriteLine("¿Cuál fue el importe final?")
            importe = Console.ReadLine()

            If importe <= 0 Then
                Console.WriteLine("Inserte un número válido.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            If tipo_pago = 1 Then
                contado(clave) = contado(clave) + importe
                sum_cont = sum_cont + importe
            ElseIf tipo_pago = 2 Then
                credito(clave) = credito(clave) + importe
                sum_cred = sum_cred + importe
            End If

            Console.WriteLine("¿Desea procesar otra venta? Presionar 1 para seguir, 2 para salir.")
            salir = Console.ReadLine()

            If salir > 2 Or salir = 0 Then
                Console.WriteLine("Inserte un número válido.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            Console.Clear()

        Loop Until salir = 2

        Console.WriteLine("      CLAVE       VENTAS DE CONTADO      VENTAS A CRÉDITO      COMISIÓN A PAGAR")

        For resultados As Byte = 1 To 30
            If contado(resultados) > 0 Or credito(resultados) > 0 Then
                Console.WriteLine("     VEND-" & resultados & "              " & contado(resultados) & "                   " & credito(resultados) & "                   " & Math.Round(((contado(resultados) * 0.02) + (credito(resultados) * 0.015))), 2)
            End If
        Next

        Console.WriteLine("     SUMAS: " & "             " & sum_cont & "                 " & sum_cred & "                 " & Math.Round(((sum_cont * 0.02) + (sum_cred * 0.015))), 2)

        Console.WriteLine("Presiona cualquier tecla para salir.")
        Console.ReadKey()
    End Sub

End Module
