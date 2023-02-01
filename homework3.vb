Imports System

Module Program
    Sub Main(args As String())

        Dim S As String
        Dim i, space, H_reg, l_reg, num, other As Integer

        Console.WriteLine("Введите строку")
        S = Console.ReadLine()
        For i = 0 To S.Length - 1
            Select Case Asc(S.Chars(i))
                Case 32
                    space += 1

                Case 97 To 122
                    l_reg += 1

                Case 65 To 90
                    H_reg += 1

                Case 48 To 57
                    num += 1

                Case Else
                    other += 1
            End Select
        Next
        Console.WriteLine("Пробелов = {0} ", space)
        Console.WriteLine("Цифры = {0} ", num)
        Console.WriteLine("Высокий регистр = {0} ", H_reg)
        Console.WriteLine("Низкий регистр = {0} ", l_reg)

    End Sub

End Module

