Module Module1

    Sub Main()
        Console.Write("Please enter a number from 1 to 10:")
        Dim Num As Integer
        Num = CInt(Console.ReadLine())

        If ((Num < 1) Or (Num > 10)) Then
            Console.WriteLine("ERROR: You must enter an number from 1 to 10.")
        Else
            Console.WriteLine("You have entered a number within the range.")
        End If

        If (Num = 1) Then
            Console.WriteLine("The Roman Numer equivelant is I.")
        ElseIf (Num = 2) Then
            Console.WriteLine("The Roman Numer equivelant is II.")
        ElseIf (Num = 3) Then
            Console.WriteLine("The Roman Numer equivelant is III.")
        ElseIf (Num = 4) Then
            Console.WriteLine("The Roman Numer equivelant is IV.")
        ElseIf (Num = 5) Then
            Console.WriteLine("The Roman Numer equivelant is V.")
        ElseIf (Num = 6) Then
            Console.WriteLine("The Roman Numer equivelant is VI.")
        ElseIf (Num = 7) Then
            Console.WriteLine("The Roman Numer equivelant is VII.")
        ElseIf (Num = 8) Then
            Console.WriteLine("The Roman Numer equivelant is VIII.")
        ElseIf (Num = 9) Then
            Console.WriteLine("The Roman Numer equivelant is IX.")
        ElseIf (Num = 10) Then
            Console.WriteLine("The Roman Numer equivelant is X.")


            Console.ReadLine()

        End If
    End Sub

End Module
