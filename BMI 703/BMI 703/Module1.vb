Module Module1
    Dim height As Double
    Dim weight As Double
    Dim BMI As Double
    Sub Main()
        Console.Write("Please enter your height in inches:")
        height = CDbl(Console.ReadLine())

        BMI = (weight * 703) / (height * height)

        Console.WriteLine("BMI Value is " & BMI)

        If (BMI < 18.5) Then
            Console.WriteLine("You are underweight")
        ElseIf (BMI >= 18.5) And (BMI <= 25) Then
            Console.WriteLine("You have optimal weight")
        ElseIf (BMI > 25) Then
            Console.WriteLine("You are overweight")
        End If

        Console.ReadLine()
    End Sub

End Module
