Imports System

Module Program
    Sub Main(args As String())
        Dim cislo1, cislo2 As String
        Dim cisl, cisl2, vysledek As Integer
        Do
            Console.Write("Napi� ��slo: ")
            cislo1 = Console.ReadLine()
            Console.Write("Napi� 2.��slo: ")
            cislo2 = Console.ReadLine

            If Integer.TryParse(cislo1, cisl) And
                    Integer.TryParse(cislo2, cisl2) Then
                If cisl >= 0 And cisl2 >= 0 Then
                    vysledek = cisl + cisl2
                    Console.WriteLine($"v�sledek je: {vysledek}")
                Else
                    Console.WriteLine("Zad�vej pouze cel� ��sla!!")
                End If

            End If
                Loop
    End Sub
End Module
