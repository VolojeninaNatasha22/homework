Imports System
Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime.Intrinsics

Module Program
    Sub Main()
        Dim Massiv(9) As Integer
        Dim k As Integer

        Randomize()

        For i = 0 To Massiv.Length - 1
            Massiv(i) = Int(Rnd() * 100) + 1
        Next i
        Console.WriteLine("Массив:")
        For Each element As Integer In Massiv
            Console.Write(element & " ")
        Next
        Console.WriteLine()


        'Dim Massiv() As Integer = {1, -2, 3, 4, -5, 6, -7, 8, -9, 10}
        Console.WriteLine("Сортировка пузырьком:")
        Console.WriteLine("По возрастанию (1) или по убыванию (2)?")


        Dim o As String
        o = Console.ReadLine()
        If o = "1" Then
            For i As Integer = 0 To Massiv.Length - 1
                For j As Integer = i + 1 To Massiv.Length - 1
                    If Massiv(i) > Massiv(j) Then
                        Dim Buffer As Integer = Massiv(i)
                        Massiv(i) = Massiv(j)
                        Massiv(j) = Buffer
                    End If
                Next
            Next
            Console.WriteLine("Отсортированный по возрастанию массив:")
            For Each element As Integer In Massiv
                Console.Write(element & " ")
            Next
            Console.WriteLine()
        End If
        If o = "2" Then
            For i As Integer = 0 To Massiv.Length - 1
                For j As Integer = i + 1 To Massiv.Length - 1
                    If Massiv(i) < Massiv(j) Then
                        Dim Buffer As Integer = Massiv(i)
                        Massiv(i) = Massiv(j)
                        Massiv(j) = Buffer

                    End If
                Next
            Next
            Console.WriteLine("Отсортированный по убыванию массив:")
            For Each element As Integer In Massiv
                Console.Write(element & " ")
            Next
        End If


    End Sub
End Module
