Imports System
Imports System.Runtime.Intrinsics

Module Program
    Sub Main()
        Dim Massiv(9) As Integer
        Dim k As Integer
        Randomize()

        Dim Buffer As Integer
        Dim min_Index As Integer


        For i = 0 To Massiv.Length - 1
            Massiv(i) = Int(Rnd() * 100) + 1
        Next i
        Console.WriteLine("Массив:")
        For Each element As Integer In Massiv
            Console.Write(element & " ")
        Next

        Console.WriteLine()

        Console.WriteLine("По возрастанию (1) или по убыванию (2)?:")
        Dim o As String
        o = Console.ReadLine()

        If o = "1" Then
            For i = 0 To Massiv.Length - 2
                min_Index = i
                For j = i + 1 To Massiv.Length - 1
                    If Massiv(j) < Massiv(min_Index) Then
                        min_Index = j
                    End If
                Next j
                If min_Index <> i Then
                    Buffer = Massiv(i)
                    Massiv(i) = Massiv(min_Index)
                    Massiv(min_Index) = Buffer
                End If
            Next i
        End If

        Console.WriteLine()

        If o = "2" Then
            For i = 0 To Massiv.Length - 2
                min_Index = i
                For j = i + 1 To Massiv.Length - 1
                    If Massiv(j) > Massiv(min_Index) Then
                        min_Index = j
                    End If
                Next j
                If min_Index <> i Then
                    Buffer = Massiv(i)
                    Massiv(i) = Massiv(min_Index)
                    Massiv(min_Index) = Buffer
                End If
            Next i
        End If

        For Each element As Integer In Massiv
            Console.Write(element & " ")
        Next

    End Sub
End Module
