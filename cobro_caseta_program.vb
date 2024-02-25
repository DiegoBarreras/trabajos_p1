Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("PROGRAMA DE COBRO PARA CASETAS")
        Console.WriteLine("------------------------------")

        Dim tipo_vehic, tipo_pago, tipo_usuario, num_vehic, sum_motos, sum_pago_efec, sum_pago_iave, sum_tarifa_moto_normal, sum_tarifa_moto_res, sum_carros, sum_tarifa_carro_normal, sum_tarifa_carro_res, sum_camiones, sum_tarifa_camion_normal, sum_tarifa_camion_res, sum_trailers, sum_tarifa_trailer_normal, sum_tarifa_trailer_res, sum_vehiculos, sum_tarifas_normal, sum_tarifas_res, sum_efectiave As Integer

        Console.WriteLine("¿Cuántos vehículos entraron durante el turno a analizar?")
        num_vehic = Console.ReadLine()

        For ciclo As Integer = 1 To num_vehic
            Console.WriteLine("¿Qué tipo de vehículo se introdujo? Presione el número según su tipo. 1) Motocicleta, 2) Automóvil/Pick-Up, 3) Camión de 2 o 3 ejes, 4) Trailer de 3 a 5 ejes. ")
            tipo_vehic = Console.ReadLine()

            Console.WriteLine("¿Qué tipo de pago se usó? Presione el número según su tipo. 1) Efectivo, 2)IAVE-Crédito.")
            tipo_pago = Console.ReadLine()

            Console.WriteLine("¿Qué tipo de usuario es? Presione el número según su tipo. 1) Normal, 2)Residente.")
            tipo_usuario = Console.ReadLine()

            Select Case tipo_vehic
                Case 1
                    Select Case tipo_usuario
                        Case 1
                            sum_tarifa_moto_normal = sum_tarifa_moto_normal + 60
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 60
                                    sum_motos = sum_motos + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 60
                                    sum_motos = sum_motos + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End 'Este END nos ayudará a parar completamente el programa en caso de que se inserte un número que no buscamos.'
                            End Select
                        Case 2
                            sum_tarifa_moto_res = sum_tarifa_moto_res + 10
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 10
                                    sum_motos = sum_motos + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 10
                                    sum_motos = sum_motos + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End
                            End Select
                        Case Else
                            Console.WriteLine("Inserte un número válido.")
                            End
                    End Select
                Case 2
                    Select Case tipo_usuario
                        Case 1
                            sum_tarifa_carro_normal = sum_tarifa_carro_normal + 100
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 100
                                    sum_carros = sum_carros + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 100
                                    sum_carros = sum_carros + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End
                            End Select
                        Case 2
                            sum_tarifa_carro_res = sum_tarifa_carro_res + 15
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 15
                                    sum_carros = sum_carros + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 15
                                    sum_carros = sum_carros + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End
                            End Select
                        Case Else
                            Console.WriteLine("Inserte un número válido.")
                            End
                    End Select
                Case 3
                    Select Case tipo_usuario
                        Case 1
                            sum_tarifa_camion_normal = sum_tarifa_camion_normal + 150
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 150
                                    sum_camiones = sum_camiones + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 150
                                    sum_camiones = sum_camiones + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End
                            End Select
                        Case 2
                            sum_tarifa_camion_res = sum_tarifa_camion_res + 20
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 20
                                    sum_camiones = sum_camiones + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 20
                                    sum_camiones = sum_camiones + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End
                            End Select
                        Case Else
                            Console.WriteLine("Inserte un número válido.")
                            End
                    End Select
                Case 4
                    Select Case tipo_usuario
                        Case 1
                            sum_tarifa_trailer_normal = sum_tarifa_trailer_normal + 200
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 200
                                    sum_trailers = sum_trailers + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 200
                                    sum_trailers = sum_trailers + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End
                            End Select
                        Case 2
                            sum_tarifa_trailer_res = sum_tarifa_trailer_res + 30
                            Select Case tipo_pago
                                Case 1
                                    sum_pago_efec = sum_pago_efec + 30
                                    sum_trailers = sum_trailers + 1

                                Case 2
                                    sum_pago_iave = sum_pago_iave + 30
                                    sum_trailers = sum_trailers + 1
                                Case Else
                                    Console.WriteLine("Inserte un número válido.")
                                    End
                            End Select
                        Case Else
                            Console.WriteLine("Inserte un número válido.")
                            End
                    End Select
                Case Else
                    Console.WriteLine("Inserta un número válido.")
                    End
            End Select
        Next

        'Esencialmente, cada parte del Select Case es igual que la anterior, solo que se cambiaron las variables para adecuarlas al vehículo que se pedía.'

        sum_efectiave = sum_pago_efec + sum_pago_iave
        sum_vehiculos = sum_motos + sum_carros + sum_camiones + sum_trailers
        sum_tarifas_normal = sum_tarifa_camion_normal + sum_tarifa_carro_normal + sum_tarifa_moto_normal + sum_tarifa_trailer_normal
        sum_tarifas_res = sum_tarifa_camion_res + sum_tarifa_carro_res + sum_tarifa_moto_res + sum_tarifa_trailer_res

        Console.WriteLine("El total de motocicletas que pagaron fueron " & sum_motos & ", se cobraron $" & sum_tarifa_moto_normal & " MXN con pago normal, y $" & sum_tarifa_moto_res & " MXN con pago especial de residentes.")
        Console.WriteLine("El total de carros que pagaron fueron " & sum_carros & ", se cobraron $" & sum_tarifa_carro_normal & " MXN con pago normal, y $" & sum_tarifa_carro_res & " MXN con pago especial de residentes.")
        Console.WriteLine("El total de camiones que pagaron fueron " & sum_camiones & ", se cobraron $" & sum_tarifa_camion_normal & " MXN con pago normal, y $" & sum_tarifa_camion_res & " MXN con pago especial de residentes.")
        Console.WriteLine("El total de trailers que pagaron fueron " & sum_trailers & ", se cobraron $" & sum_tarifa_trailer_normal & " MXN con pago normal, y $" & sum_tarifa_trailer_res & " MXN con pago especial de residentes.")
        Console.WriteLine("El total de vehículos que pagaron fueron " & sum_vehiculos & ", se cobraron $" & sum_tarifas_normal & " MXN con pago normal, y $" & sum_tarifas_res & " MXN con pago especial de residentes.")
        Console.WriteLine("El total cobrado en efectivo fue $" & sum_pago_efec & " MXN, o " & Math.Round(((sum_pago_efec / sum_efectiave) * 100), 2) & "%")
        Console.WriteLine("El total cobrado con tarjeta IAVE fue $" & sum_pago_iave & " MXN, o " & Math.Round(((sum_pago_iave / sum_efectiave) * 100), 2) & "%")
        Console.WriteLine("El total cobrado (por efectivo y tarjeta) fue $" & sum_efectiave & " MXN, o 100%")

    End Sub
End Module
