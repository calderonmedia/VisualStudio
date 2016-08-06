Module Module1

    Sub Main()
        Dim firstname As String
        Dim lastname As String
        Dim age As Integer = 0
        Dim howMany As Integer = 0



        'code for inputing data into pertain to this loop
        Dim writer As System.IO.StreamWriter =
            System.IO.File.AppendText("myRecords.txt")

        Console.Write("Enter the first name:")
        firstname = Console.ReadLine()
        Console.Write("Enterthe lastname:")
        lastname = Console.ReadLine()
        Console.Write("Enter age:")
        age = Console.ReadLine()
        writer.WriteLine(firstname & "" & lastname & "")
        writer.Close()
            howMany = howMany + 1


        Dim lineinput As String
        Dim runAgain As String
        Dim reader As IO.StreamReader
            reader = IO.File.OpenText("myrecords.txt")
            Do Until reader.Peek() = -1
                lineinput = reader.ReadLine()
                Console.WriteLine(lineinput)
            Loop
            reader.Close()

            Console.Write("Do you want to run again yes or no:")
            runAgain = Console.ReadLine()

            'this causes a pause so you can see the program
            Console.Write("Press enter to continue...")
            Console.ReadLine()





    End Sub

End Module
