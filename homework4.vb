Imports System

Module ConsoleGraphics

    Const brush As Char = "0"c
    Sub Main(args As String())

        Dim left As Integer = 20
        Dim top As Integer = 10
        Dim width As Integer = 15
        Dim height As Integer = 50

        FilRect(20, 10, 20, 10)

    End Sub

    Sub HLine(leftX As Byte, topY As Byte, lehgth As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 0 To lehgth
            Console.Write(brush)
        Next
    End Sub

    Sub VLine(leftX As Byte, topY As Byte, lehgth As Byte)
        For i = 0 To lehgth - 1
            Console.Write(brush)
            Console.SetCursorPosition(leftX, topY + i)
        Next
    End Sub

    Sub FilRect(leftX As Byte, topY As Byte, width As Byte, heigth As Byte)
        HLine(leftX, topY, width)
        For i = 0 To heigth
            HLine(leftX, topY + i, width)

        Next
    End Sub

End Module
