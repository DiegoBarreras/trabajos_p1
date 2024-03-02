Imports System

Module Program

    Dim vez(18) As Boolean
    Dim n_folio As Integer
    Dim salir, mun, sec As Byte
    Dim nom_municipioXsector(18, 2) As String
    Dim monto, munXsec(18, 5), sum_municipio(18), sum_total, porcentaje(18) As Single

    Sub Main(args As String())

        'Aqu� se asignan los nombres del municipio y del sector donde se invertir� el dinero.'
        nom_municipioXsector(1, 1) = "Ahome"
        nom_municipioXsector(2, 1) = "Angostura"
        nom_municipioXsector(3, 1) = "Badiraguato"
        nom_municipioXsector(4, 1) = "Concordia"
        nom_municipioXsector(5, 1) = "Cosal�"
        nom_municipioXsector(6, 1) = "Culiac�n"
        nom_municipioXsector(7, 1) = "Choix"
        nom_municipioXsector(8, 1) = "Elota"
        nom_municipioXsector(9, 1) = "Escuinapa"
        nom_municipioXsector(10, 1) = "El Fuerte"
        nom_municipioXsector(11, 1) = "Guasave"
        nom_municipioXsector(12, 1) = "Mazatl�n"
        nom_municipioXsector(13, 1) = "Mocorito"
        nom_municipioXsector(14, 1) = "Rosario"
        nom_municipioXsector(15, 1) = "Salvador Alvarado"
        nom_municipioXsector(16, 1) = "San Ignacio"
        nom_municipioXsector(17, 1) = "Sinaloa"
        nom_municipioXsector(18, 1) = "Navolato"

        nom_municipioXsector(1, 2) = "Salud"
        nom_municipioXsector(2, 2) = "Educaci�n"
        nom_municipioXsector(3, 2) = "Seguridad"
        nom_municipioXsector(4, 2) = "Cultura"
        nom_municipioXsector(5, 2) = "Turismo"

        Console.WriteLine("PROGRAMA PARA CAPTURA DE DATOS (GASTOS ESTATALES)")
        Console.WriteLine("-------------------------------------------------")

        'Decid� usar un ciclo Do-Loop porque no sabemos la cantidad de veces que el usuario usar� el programa.'
        Do
            Console.WriteLine("Inserta el n�mero de folio.")
            n_folio = Console.ReadLine()

            Console.WriteLine("Inserta el n�mero del municipio.")
            mun = Console.ReadLine()

            'Validamos el n�mero de municipio.'
            If mun > 18 Or mun < 1 Then
                Console.WriteLine("Inserta n�mero correcto.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            Console.WriteLine("Inserta el n�mero del sector beneficiado.")
            sec = Console.ReadLine()

            'Validamos el n�mero del sector.'
            If sec > 5 Or sec < 1 Then
                Console.WriteLine("Inserta numero correcto.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            Console.WriteLine("Inserta el monto invertido.")
            monto = Console.ReadLine()

            munXsec(mun, sec) = munXsec(mun, sec) + monto
            'Registramos el monto dentro de la matriz (y lo actualizamos, de ser necesario).'

            Console.WriteLine("�Deseas registrar m�s datos? (1. S�, 2. No.)")
            salir = Console.ReadLine()
            'Aqu� el usuario decide seguir registrando m�s datos (o no).'

            'Validamos la opci�n de salida.'
            If salir <> 1 And salir <> 2 Then
                Console.WriteLine("Inserta n�mero correcto.")
                Console.WriteLine("Presiona cualquier tecla para salir.")
                Console.ReadKey()
                End
            End If

            'Limpiamos la consola.'
            Console.Clear()

        Loop Until salir = 2

        'Buscamos dentro de la matriz si hay alg�n monto registrado.'
        Console.WriteLine("Concentrado de presupuesto estatal Municipio-Rubro:")
        For i As Byte = 0 To 18
            For j As Byte = 0 To 5
                If munXsec(i, j) > 0 Then
                    Console.WriteLine("Estado: " & i & ", " & nom_municipioXsector(i, 1) & "    Sector: " & nom_municipioXsector(j, 2) & "    Monto: $" & munXsec(i, j) & " MXN")
                    sum_total = sum_total + munXsec(i, j)
                    'Aqu� mismo empezamos a sumar el total y la suma por municipio.'
                    sum_municipio(i) = sum_municipio(i) + munXsec(i, j)
                End If
            Next
        Next
        Console.WriteLine("Suma: $" & sum_total & " MXN")

        'Repetimos una vez m�s el proceso.'
        Console.WriteLine(" ")
        Console.WriteLine("Concentrado de presupuesto estatal por municipio:")
        For i As Byte = 0 To 18
            For j As Byte = 0 To 5
                If munXsec(i, j) > 0 Then
                    If vez(i) = 0 Then
                        'Aqu� decid� usar un If-Then, para "bloquear" el n�mero de veces que se imprimir� el resultado (Solo debe ser una vez).'
                        porcentaje(i) = Math.Round(((sum_municipio(i) / sum_total) * 100), 2)
                        Console.WriteLine("Estado: " & i & ", " & nom_municipioXsector(i, 1) & "    Monto: $" & sum_municipio(i) & " MXN" & "    Porcentaje: " & porcentaje(i) & "%")
                        vez(i) = 1
                    End If
                End If
            Next
        Next
        Console.WriteLine("Suma: $" & sum_total & " MXN")

        Console.WriteLine(" ")
        Console.WriteLine("Presiona cualquier tecla para salir.")
        Console.ReadKey()
    End Sub
End Module