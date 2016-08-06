Module Module1

    Sub Main()
        Dim number As Double
        Dim result As Double
        result = half(number)

        Console.WriteLine("This is the half of your number:")

        Console.WriteLine("Please enter a number to continue....")
        Console.ReadKey()

    End Sub
    Function half(ByVal number As Double)

        Console.WriteLine("Enter a number:")
        number = Console.ReadLine()
        number = number / 2

        Return number

    End Function
End Module


