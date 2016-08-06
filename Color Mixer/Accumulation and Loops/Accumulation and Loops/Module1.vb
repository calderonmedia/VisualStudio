Module Module1

    Sub Main()
        'Declare local variables
        Dim anotherDay As String = "yes"

        'Loop to run program again
        While anotherDay = "yes"
            'Declare and initialize variables
            Dim totalSpeed As Double = 0
            Dim averageSpeed As Double = 0
            Dim displayAverage As Double = 0
            'Call modules
            enterspeeds(totalSpeed)
            calcAverage(totalSpeed, averageSpeed)
            Console.WriteLine("Enter yes if you want to calculate another day:")
            anotherDay = Console.ReadLine()

        End While
        Console.WriteLine("")
        Console.WriteLine("End Transmission")
        Console.WriteLine()
    End Sub
    Sub enterspeeds(ByRef totalSpeed As Double)
        Dim counter As Integer = 1
        Dim networkSpeed As Double = 0
        For counter = 1 To 8
            Console.WriteLine("Enter network speed:")
            networkSpeed = Console.ReadLine()

            totalSpeed = totalSpeed + networkSpeed
        Next
        Console.WriteLine("")
    End Sub

    Sub calcAverage(ByVal totalSpeed As Double, ByRef averageSpeed As Double)
        averageSpeed = totalSpeed / 8
    End Sub

End Module
