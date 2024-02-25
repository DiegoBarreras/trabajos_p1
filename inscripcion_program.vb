Imports System

Module Program

    Dim carrera, año_proximo, bloqueo As Integer
    Dim nombre As String
    Dim ultimo_promedio, pago_anual As Single

    Sub Main(args As String())
        'La variable bloqueo nos ayudará a "parar" el programa sin el uso de un ciclo FOR. '
        bloqueo = 0

        Console.WriteLine("Cálculo del cobro de inscripción UAS.")
        Console.WriteLine("-------------------------------------")
        Console.WriteLine("Introducir nombre del estudiante.")
        nombre = Console.ReadLine()
        Console.WriteLine("¿Qué año estará cursando? (Escriba del 1 al 5 respectivamente dependiendo del año próximo a cursar.)")
        año_proximo = Console.ReadLine()

        If año_proximo < 1 Or año_proximo > 5 Then
            Console.WriteLine("Introducir un número válido.")
            bloqueo = 1
        ElseIf año_proximo = 1 Then
            Console.WriteLine("Introducir la carrera por cursar. (Escriba 1 para ing. civil, 2 para ing. geodésica, 3 para ing. de software y 4 para ing. en procesos industriales.)")
            carrera = Console.ReadLine()
        ElseIf año_proximo > 1 Then
            Console.WriteLine("Introducir la carrera cursada. (Escriba 1 para ing. civil, 2 para ing. geodésica, 3 para ing. de software y 4 para ing. en procesos industriales.)")
            carrera = Console.ReadLine()
        End If

        If bloqueo = 1 Then
        Else

            If carrera = 0 Or carrera > 4 Then
                Console.WriteLine("Introducir un número válido.")
                bloqueo = 1
            End If

            Console.WriteLine("Inserte su promedio del año anterior")
            ultimo_promedio = Console.ReadLine()

            If bloqueo = 1 Then
            Else
                If ultimo_promedio > 10.0 Or ultimo_promedio < 0.00 Then
                    Console.WriteLine("Introducir un número válido.")
                    bloqueo = 1
                End If
            End If

            If bloqueo = 1 Then
            Else
                Console.WriteLine("Inserte el importe a pagar.")
                    pago_anual = Console.ReadLine()

                    If pago_anual < 0 Then
                        Console.WriteLine("Introducir un número válido.")
                        bloqueo = 1
                    Else
                    If año_proximo > 1 Then
                        If ultimo_promedio > 9 Then
                            Console.WriteLine("Su descuento es del 30%. ($" & pago_anual * 0.3 & " MXN)")
                            Console.WriteLine("Importe total a pagar: $" & pago_anual - (pago_anual * 0.3) & " MXN")
                        ElseIf ultimo_promedio >= 8 Then
                            Console.WriteLine("Su descuento es del 20%. ($" & pago_anual * 0.2 & " MXN)")
                            Console.WriteLine("Importe total a pagar: $" & pago_anual - (pago_anual * 0.2) & " MXN")
                        Else
                            Console.WriteLine("Su descuento es del 0%. ($0.00 MXN)")
                            Console.WriteLine("Importe total a pagar: $" & pago_anual & " MXN")
                        End If
                    Else
                        Console.WriteLine("Su descuento es del 0%. ($0.00 MXN)")
                            Console.WriteLine("Importe total a pagar: $" & pago_anual & " MXN")
                        End If
                    End If

                End If

            End If

    End Sub
End Module
