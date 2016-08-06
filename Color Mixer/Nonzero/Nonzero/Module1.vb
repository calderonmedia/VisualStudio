Module Module1

    Sub Main()

        Dim number As Integer
        Dim IsPositive As Boolean

        Do While (IsPositive = False)

            Console.Write("Please enter a postive non-zero number:")
            number = CInt(Console.ReadLine())

            IsPositive = PositiveCheck(number)

            If (IsPositive = True) Then
                Console.WriteLine("GOOD INPUT: The user has entered a non-zero postive number.")
            Else
                Console.WriteLine("BAD INPUT: The user entered a zero or a negative number.")
            End If

        Loop

        Console.ReadLine()

    End Sub


End Module
