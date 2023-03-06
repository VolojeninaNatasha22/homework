Imports System

Module Program
    Sub Main(args As String())
        Dim seconds, hours, minutes, remainingSeconds As Integer

        Console.Write("введите время в секундах: ")
        seconds = Console.ReadLine

        hours = seconds \ 3600
        remainingSeconds = seconds Mod 3600
        minutes = remainingSeconds \ 60
        remainingSeconds = remainingSeconds Mod 60

        Console.Write("Time: " & hours & " hours, " & minutes & " minutes, " & remainingSeconds & " seconds")
    End Sub
End Module