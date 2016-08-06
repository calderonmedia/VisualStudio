Module Module1

    Sub Main()
        Dim PosNum As Boolean = True
        Dim TotalNum As Integer = 0
        Dim UserNum As Integer

        Do While (PosNum)
            Console.Write("Enter a postive number--NEGATIVE NUMBER TO QUIT:")
            UserNum = CInt(Console.ReadLine())

            If (UserNum >= 0) Then
                TotalNum = TotalNum + UserNum
            Else
                PosNum = False

                Console.WriteLine("The sum of the numbers that you have entered is " & TotalNum)

            End If



        Loop

        Console.WriteLine("The sum of the numbers that you have entered is " & TotalNum)

        Console.ReadLine()

    End Sub


End Module
