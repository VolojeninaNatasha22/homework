Imports System
Imports System.Linq.Expressions

Module Program
    Sub Main(args As String())
        Dim Numbers, veriy As String
        Dim bulls, cows As Integer
        Randomize()
        Do
            Numbers = Int((8000 * Rnd()) + 999)
            Console.WriteLine(Numbers)
        Loop Until CheckDublicates(Numbers) = False

        Do
            veriy = Console.ReadLine()
            Do
                Console.WriteLine(CheckDublicatesUSE(veriy))
                veriy = Console.ReadLine()
            Loop Until CheckDublicatesUSE(veriy) = False
            cows = 0
            bulls = 0
            For l As Byte = 0 To 3
                For r As Byte = 0 To 3
                    If (Numbers.Chars(r) = veriy.Chars(l)) Then
                        If r = l Then
                            bulls += 1
                        Else
                            cows += 1
                        End If
                    End If

                Next
            Next
            Console.WriteLine("have you found the cows = {0}", cows)
            Console.WriteLine("have you found the bulls = {0}", bulls)

        Loop Until Numbers = veriy
        Console.WriteLine("Victory")
    End Sub
    Function CheckDublicates(Num As String) As Boolean
        CheckDublicates = False
        For j = 0 To 2
            For i = j + 1 To 3
                If Num.Chars(j) = Num.Chars(i) Then
                    CheckDublicates = True
                End If
            Next
        Next

    End Function
    Function CheckDublicatesUSE(Ver As String) As Boolean
        For j = 0 To 2
            For i = j + 1 To 3
                If Ver.Chars(j) = Ver.Chars(i) Then
                    CheckDublicatesUSE = True
                    Console.WriteLine("try again")
                End If
            Next
        Next
    End Function

End Module