Imports System

Module Program
    Sub Main(args As String())
        Dim cislo1, cislo2 As String
        Dim cisl, cisl2, vysledek As Integer
        Do
            Console.Write("Napiš èíslo: ")
            cislo1 = Console.ReadLine()
            Console.Write("Napiš 2.èíslo: ")
            cislo2 = Console.ReadLine

            If Integer.TryParse(cislo1, cisl) And
                    Integer.TryParse(cislo2, cisl2) Then
                If cisl >= 0 And cisl2 >= 0 Then
                    vysledek = cisl + cisl2
                    Console.WriteLine($"výsledek je: {vysledek}")
                Else
                    Console.WriteLine("Zadávej pouze celá èísla!!")
                End If

            End If
                Loop
    End Sub
End Module
