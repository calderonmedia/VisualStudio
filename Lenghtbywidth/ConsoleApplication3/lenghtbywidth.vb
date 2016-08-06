Module Module1
    Sub lenghtbywidth()
        (ByVal rectangle As Double)
        Dim Length As Double
        Dim Width As Double
        rectangle = Length * Width
        Console.WriteLine("The conversion result is area of a rectangle")
    End Sub
    Sub Main()
        Dim lengthbywidth

        Console.Write("Please multiply lenght by width")
        Console.Write("Please enter length:")
        Console.Write("Please enter width:")

        lengthbywidth = CDbl(Console.ReadLine())

        Console.WriteLine("This equals the area of a rectangle")
        Console.ReadLine()

    End Sub

End Module
