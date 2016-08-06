Module Module1

    Sub Main()
        'Variable declaration list
        Dim Speed As Integer
        Dim Hours As Integer
        Dim Distance As Integer
        Dim DistTotal As Integer = 0
        Dim HrCount As Integer

        'User input
        Console.Write("What is the speed of the vehicle in mph? ")
        Speed = CInt(Console.ReadLine())

        Console.Write("How many hours has it traveled? ")
        Hours = CInt(Console.ReadLine())

        'Program output
        Console.WriteLine()
        Console.WriteLine("Hour            Distance Traveled")
        Console.WriteLine("_________________________________")


        'Outloop loop structure

        For HrCount = 1 To Hours
            Distance = Speed * HrCount
            Console.Write(HrCount & "           " & Distance)
            Console.WriteLine()
        Next



        Console.ReadLine()
    End Sub

End Module

