Module Module1

    Sub Main()
        'Declaring Variables
        Dim number As Integer
        Dim total As Integer
        Dim counter As Integer
        Dim input As Integer


        Do While (number <= 10)
            Console.Write("This program will enter 10 numbers and keeps a running total of the sum of the numbers.")
            counter = CInt(Console.ReadLine())
            total = CInt(Console.ReadLine())
            input = CInt(Console.ReadLine())
            counter += 1

            Console.Write("Please enter your number:")



            Console.Write("The total of the number is")

            Console.ReadLine()

        Loop
    End Sub

End Module
