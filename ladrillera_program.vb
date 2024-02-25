Imports System
Imports System.Text.RegularExpressions

Module Program

    Dim nombre_del_cliente As String
    Dim piezas As Integer
    Dim precio_unitario, total_venta As Single

    Sub Main(args As String())

        Console.WriteLine("Cálculo de la venta de ladrillos.")
        Console.WriteLine("----------------------------------------------------")
        Console.WriteLine("Captura el nombre del cliente que me está comprando.")
        nombre_del_cliente = Console.ReadLine()
        Console.WriteLine("Captura las piezas vendidas.")
        piezas = UCase(Console.ReadLine())

        If piezas < 1000 Then
            precio_unitario = 8
        ElseIf piezas >= 1000 <= 5000 Then
            precio_unitario = 7.5
        ElseIf piezas > 5000 <= 100000 Then
            precio_unitario = 6.5
        ElseIf piezas > 100000 Then
            precio_unitario = 5.9
        End If

        total_venta = piezas * precio_unitario
        Console.WriteLine("El total de la venta es de " & total_venta)
        Console.WriteLine("Presiona cualquier tecla para salir.")
        Console.ReadKey()

    End Sub

End Module
