Imports System

Module Program
    Sub Main()
        Dim pocetCisel As Object
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("Kolik ��sel chce�? ")
        pocetCisel = Console.ReadLine
        If IsNumeric(pocetCisel) = False Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba - nezadali jste ��slo!")
            Console.ReadKey()
            Main()

        End If

        Dim cistecislo As Integer = pocetCisel
        If cistecislo <= 0 Then
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("Chyba - nezadali jste kladn� ��slo!")
            Console.ReadKey()
            Main()
        End If
        Dim nahoda As Integer
        Dim pocetsudych, pocetlichych As Double
        Console.Clear()
        For x = 1 To cistecislo
            nahoda = Rnd() * 1000
            Console.WriteLine(nahoda)
            If nahoda Mod 2 = 0 Then
                pocetsudych += nahoda
            Else
                pocetlichych += nahoda
            End If
        Next
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("Sou�et sud�ch je:" & pocetsudych)
        Console.WriteLine("Sou�et lichch je:" & pocetlichych)
        Console.ReadKey()

    End Sub
End Module
