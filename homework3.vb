Module Program
    Sub Main(args As String())
        Dim s As String
        Dim spaces, wolves, i, consonants, punctuation As Integer
        Console.WriteLine("Введите строчку: ")
        s = Console.ReadLine()
        For i = 0 To s.Length - 1
            Select Case Asc(s.Chars(i))

                Case 32
                    spaces += 1

                Case 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121
                    wolves += 1

                Case 66, 67, 68, 70, 71, 72, 74, 75, 76, 77, 78, 80, 81, 82, 83, 84, 86, 87, 88, 90, 98, 99, 100, 102, 103, 104, 106, 107, 108, 109, 110, 112, 113, 114, 115, 116, 118, 119, 120, 122
                    consonants += 1

                Case 33, 34, 35, 39, 44, 45, 46, 47, 58, 59, 63, 96, 130, 173, 175, 145, 146, 147, 148, 150
                    punctuation += 1

            End Select
        Next
        Console.WriteLine("Пробелов = {0}", spaces)
        Console.WriteLine("Гласных = {0}", wolves)
        Console.WriteLine("Согласных = {0}", consonants)
        Console.WriteLine("Знаков препинания = {0}", punctuation)
    End Sub
End Module

