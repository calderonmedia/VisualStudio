Module Module1

    Sub Main()
        Dim length As Double
        Dim width As Double
        Dim answer As Double

        Console.Write("Please enter the length of the rectangle:")
        length = CDbl(Console.ReadLine())

        Console.Write("Please enter the width of the rectangle:")
        width = CDbl(Console.ReadLine())


        answer = Area(length, width)

        Console.WriteLine("The area of the rectangle is " & answer & ".")

    End Sub

    Function Area(ByVal len As Double, ByVal wid As Double)
        Dim result As Double

        result = len * wid
        Return result
    End Function
End Module
