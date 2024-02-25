Module Program
    Sub Main(args As String())
        Dim n As Byte
        Dim declaraciones As Integer
        Dim nombre, entidad_fed(31), entidad_fed_usuario As String
        Dim ingresos_anuales, base_gravable, salario_min, salmin365, isr_sum(31), isr, isr_total As Single

        entidad_fed(0) = "Aguascalientes"
        entidad_fed(1) = "Baja California"
        entidad_fed(2) = "Baja California Sur"
        entidad_fed(3) = "Campeche"
        entidad_fed(4) = "Chiapas"
        entidad_fed(5) = "Chihuahua"
        entidad_fed(6) = "Ciudad de México"
        entidad_fed(7) = "Coahuila"
        entidad_fed(8) = "Colima"
        entidad_fed(9) = "Durango"
        entidad_fed(10) = "Guanajuato"
        entidad_fed(11) = "Guerrero"
        entidad_fed(12) = "Hidalgo"
        entidad_fed(13) = "Jalisco"
        entidad_fed(14) = "Estado de México"
        entidad_fed(15) = "Michoacán"
        entidad_fed(16) = "Morelos"
        entidad_fed(17) = "Nayarit"
        entidad_fed(18) = "Nuevo León"
        entidad_fed(19) = "Oaxaca"
        entidad_fed(20) = "Puebla"
        entidad_fed(21) = "Querétaro"
        entidad_fed(22) = "Quintana Roo"
        entidad_fed(23) = "San Luis Potosí"
        entidad_fed(24) = "Sinaloa"
        entidad_fed(25) = "Sonora"
        entidad_fed(26) = "Tabasco"
        entidad_fed(27) = "Tamaulipas"
        entidad_fed(28) = "Tlaxcala"
        entidad_fed(29) = "Veracruz"
        entidad_fed(30) = "Yucatán"
        entidad_fed(31) = "Zacatecas"

        salario_min = 248.93
        salmin365 = salario_min * 365

        Console.WriteLine("PROGRAMA PARA CÁLCULO DE IMPUESTO A LA RENTA")
        Console.WriteLine("--------------------------------------------")

        Console.WriteLine("Inserta el número de veces que se ha de declarar.")
        declaraciones = Console.ReadLine()

        For ciclo As Integer = 1 To declaraciones
            Console.WriteLine("Inserta el nombre del contribuyente.")
            nombre = Console.ReadLine()

            Console.WriteLine("Inserta el ingreso anual.")
            ingresos_anuales = Console.ReadLine()

            Console.WriteLine("Inserte la entidad federativa (0 al 31, dependiendo del estado)")
            n = Console.ReadLine()
            If n > 31 Then
                Console.WriteLine("Inserta un número correcto.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            base_gravable = (ingresos_anuales - salmin365)

            If base_gravable > 0 Then
                isr = base_gravable * 0.3
                isr_total = isr_total + isr
                isr_sum(n) = isr_sum(n) + isr
            Else
            End If

        Next

        For ciclo1 As Byte = 0 To 31
            If isr_sum(ciclo1) > 0 Then
                Console.WriteLine("El ISR cobrado a la entidad federativa de " & entidad_fed(ciclo1) & " fue de $" & Math.Round(isr_sum(ciclo1), 1) & " MXN, siendo el " & Math.Round(((isr_sum(ciclo1) / isr_total) * 100), 1) & "% nacional.")
            Else
            End If
        Next

        Console.WriteLine("La suma total del ISR cobrado a nivel nacional es de $" & Math.Round(isr_total, 1) & " MXN, siento éste el 100%.")
        Console.WriteLine("Presiona cualquier tecla para salir.")
        Console.ReadKey()

    End Sub
End Module
