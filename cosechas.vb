Imports System

Module Program
    Dim camiones As Integer
    Dim humedad, kilos_descontados, kilos_pagados, subtotal, impuestos, total, precio_kg, suma_kilos_descontados, kilos_entregados, suma_kilos_entregados, total_kilos_pagados, subtotal_global, total_impuestos, impuesto_ind, total_suma, total_kilos_descontados, total_kilos_entregados As Single

    Sub Main(args As String())

        precio_kg = 5.9
        impuestos = 0.0045

        Console.WriteLine("PROGRAMA PARA CÁLCULO DE PAGO A COSECHA")
        Console.WriteLine("---------------------------------------")

        Console.WriteLine("Inserte el número de camiones a analizar.")
        camiones = Console.ReadLine()

        For ciclo As Integer = 1 To camiones
            Console.WriteLine("Inserte la cantidad entregada en kilogramos.")
            kilos_entregados = Console.ReadLine()
            suma_kilos_entregados = (suma_kilos_entregados + kilos_entregados)

            Console.WriteLine("Inserte el porcentaje de humedad.")
            humedad = Console.ReadLine()

            If humedad > 100 Then
                Console.WriteLine("Inserta un número correcto.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            ElseIf humedad <= 14.0 Then
                kilos_descontados = (kilos_entregados * 0)
                suma_kilos_descontados = (suma_kilos_descontados + (kilos_descontados))
            ElseIf humedad > 18.0 Then
                kilos_descontados = (kilos_entregados * 0.07)
                suma_kilos_descontados = (suma_kilos_descontados + (kilos_descontados))
            ElseIf humedad > 16.0 And humedad <= 18.0 Then
                kilos_descontados = (kilos_entregados * 0.05)
                suma_kilos_descontados = (suma_kilos_descontados + (kilos_descontados))
            ElseIf humedad > 14.0 And humedad <= 16.0 Then
                kilos_descontados = (kilos_entregados * 0.03)
                suma_kilos_descontados = (suma_kilos_descontados + (kilos_descontados))
            End If

            total_kilos_entregados = Math.Round((suma_kilos_entregados), 2)

            total_kilos_descontados = Math.Round((suma_kilos_descontados), 2)

            kilos_pagados = (kilos_entregados - kilos_descontados)

            total_kilos_pagados = Math.Round((total_kilos_pagados + kilos_pagados), 2)

            subtotal = (kilos_pagados * precio_kg)
            Console.WriteLine(subtotal)
            Console.ReadKey()

            subtotal_global = Math.Round((subtotal_global + subtotal), 2)

            impuesto_ind = (subtotal * impuestos)
            total_impuestos = Math.Round((total_impuestos + impuesto_ind), 2)

            total = (subtotal - impuesto_ind)
            total_suma = Math.Round((total_suma + total), 2)

            Console.Clear()

        Next

        Console.WriteLine("El total de kilos entregados es de: " & total_kilos_entregados)
        Console.WriteLine("El total de kilos descontados es de: " & total_kilos_descontados)
        Console.WriteLine("El total de kilos pagados es de: " & total_kilos_pagados)
        Console.WriteLine("El subtotal global es de: " & subtotal_global)
        Console.WriteLine("La cantidad total pagada como impuestos es de: $" & total_impuestos & " MXN")
        Console.WriteLine("La cantidad neta (sumada) a pagar es de: " & total_suma)

        Console.WriteLine("Presiona cualquier tecla para salir.")
        Console.ReadKey()

    End Sub
End Module
