Module Module1

    Sub Main()
        Dim BugNum As Integer
        Dim BugTotal As Integer = 0
        Dim BugLoopCount As Integer = 1

        Do While (BugLoopCount <= 7)
            Console.Write("How many bugs did you collect for Day " & BugLoopCount & "?: ")
            BugNum = CInt(Console.ReadLine())
            BugTotal = BugTotal + BugNum
            BugLoopCount += 1

            Console.WriteLine("Total number of bugs collected:" & BugTotal)

        Loop



    End Sub

End Module
