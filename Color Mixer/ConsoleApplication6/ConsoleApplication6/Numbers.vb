Module Module1

    Sub Main()
        Dim Minnum As Integer = 10
        Dim Maxnum As Integer = 100
        Dim NumLoopcount As Integer = 1

        Do While (NumLoopcount * 10)
            Console.Write("Please enter a number")
            Minnum = CInt(Console.ReadLine())
            Minnum = Maxnum
            Console.Write("This is the equivelant shall be multiplied by 10")
            Console.Read()

            Minnum = Maxnum + NumLoopcount
            NumLoopcount += 1


            Console.Write("This is the end result that was multiplied by 10")


        Loop

    End Sub

End Module
