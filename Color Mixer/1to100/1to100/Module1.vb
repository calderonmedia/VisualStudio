Module Module1

    Sub Main()
        Dim Number As Integer
        Dim OutofRange As Boolean

        Do While (OutofRange = False)

            Console.Write("Please enter a number the range of 1 to 100")
            Number = CInt(Console.ReadLine())

            If (Number < 100) Then
                Console.WriteLine("GOOD INPUT: The user has entered a number from the range of 1 to 100.")
            Else
                Console.WriteLine("BAD INPUT: The user entered a number over 100.")
            End If


        Loop

        Console.ReadLine()

    End Sub
    Function OutofRange(ByVal num As Integer) As Boolean
        Dim flag As Boolean = True

        If (num <= 0) Then
            flag = False
        End If

        Return flag
    End Function


End Module
