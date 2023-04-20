Imports System
Imports System.Runtime.ConstrainedExecution

Module Program
    Sub Main(args As String())
        Dim version, b, decimetre, centimetre, residue, metre, residueM, cen As Integer
        Dim key As ConsoleKeyInfo
        Do
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("1 - Desimetr, 2 - Ruler , 3 - metr")
            b = Console.ReadLine()
            Console.WriteLine("Enter the lenght in centimeters")
            version = Console.ReadLine()
            Select Case b
                Case 1
                    decimetre = version \ 10
                    Console.WriteLine("Desimetr = {0}", decimetre)
                Case 2
                    metre = version \ 100
                    residueM = metre * 100
                    centimetre = version Mod 100
                    decimetre = centimetre \ 10
                    cen = centimetre Mod 10
                    Console.WriteLine("Metr = {0}", metre)
                    Console.WriteLine("Desimetr = {0}", decimetre)
                    Console.WriteLine("Santimetr = {0}", cen)
                Case 3
                    metre = version \ 100
                    Console.WriteLine("Metr = {0}", metre)
            End Select
            Console.ForegroundColor = ConsoleColor.Cyan
            Console.WriteLine("Do you want to repeat it ? if yes - y if no - n")
            Do
                key = Console.ReadKey(True)
            Loop Until key.KeyChar = "y"c Or key.KeyChar = "n"c
            Console.WriteLine(key.KeyChar)
            Console.Clear()
        Loop Until key.KeyChar = "n"c
    End Sub

End Module