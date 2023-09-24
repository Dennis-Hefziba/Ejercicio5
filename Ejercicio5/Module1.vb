Module Module1
    'Escriba un programa que escriba la tabla de multiplicar de x número ingresado por el
    '  usuario.
    Sub Main()

        Dim tabla As Integer
        Dim retorno As Boolean = True


        Console.WriteLine("---------------------------------------------------------------------")
            Console.WriteLine("Bienvenido al programa que muestra la tabla de multiplicar que desees")
            Console.WriteLine("---------------------------------------------------------------------")

        Do

            Console.WriteLine()
            Console.WriteLine("---------------------------------------------------------------------")
            Console.WriteLine("Que tabla de multiplicar te gustaria revisar? ")
            Console.WriteLine("Ingresa un numero del 1 al 10")
            Console.WriteLine("---------------------------------------------------------------------")
            tabla = Console.ReadLine()


            For i As Integer = 1 To 10
                Console.WriteLine(tabla.ToString() + "x" + i.ToString() + "=" + (tabla * i).ToString)
            Next

            Console.WriteLine("Si desea revisar otra tabla presione cualquier tecla," + vbCrLf +
                              "de lo contrario presione S para salir")
            Dim respuesta As ConsoleKeyInfo = Console.ReadKey()
            If respuesta.Key = ConsoleKey.S Then
                Exit Do
            End If

        Loop While retorno = True
        Console.ReadLine()
    End Sub

End Module
