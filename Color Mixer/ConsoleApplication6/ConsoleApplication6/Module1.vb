Module Module1

    Sub Main()
        Dim Minnum As Integer = 10
        Dim Maxnum As Integer = 100
        Dim NumLoopcount As Integer = 0

        Do While (NumLoopcount * 10)
            Console.Write("Please enter a number")
            Minnum = CInt(Console.ReadLine())
            Minnum = Maxnum + NumLoopcount
            NumLoopcount += 1

            Console.WriteLine("This number shall be multiplied by 10" & NumLoopcount)

        Loop

    End Sub

End Module
