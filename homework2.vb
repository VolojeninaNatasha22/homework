Module Module1

    Sub Main()
        Dim y As Long = 0
        Dim user_input As Long

        Console.WriteLine("������� ��������� �����: ")
        y = Console.ReadLine()

        While True
            Console.WriteLine("������� ����� ��� ������������: ")
            user_input = Int64.Parse(Console.ReadLine())

            If user_input = 1 Then
                Console.WriteLine("��������� ������������: {0}", y)
                Exit While
            End If

            If y > Int64.MaxValue / user_input Then
                Console.WriteLine("��������� ��������� �����! ��������� ��������� �� ������������: {0}", y)
                Exit While
            End If

            y *= user_input
        End While
        Console.ReadKey()
    End Sub

End Module