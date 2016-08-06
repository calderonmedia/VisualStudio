Module Module1

    Sub Main()
        Dim firstname As String = "Jesus"
        Dim lastname As String = "Calderon"
        Dim age As Integer = 38

        Dim writer As System.IO.StreamWriter =
            System.IO.File.CreateText("myrecords.txt")
        writer.WriteLine(firstname & "" & lastname & "")
        writer.Close()

        Dim reader As System.IO.StreamReader =
            System.IO.File.OpenText("myrecords.txt")
        Dim myinfo As String = reader.ReadLine()
        Console.WriteLine(myinfo)
        reader.Close()

        'this causes a pause so you can see your program
        Console.Write("Press enter to continue...")
        Console.ReadLine()
    End Sub

End Module
