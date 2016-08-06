Imports System.IO

Module Module1

    Sub Main()
        ' Declare a Streamwriter variable
        Dim myFile As StreamWriter

        'Open a file named Philosophers.txt on the disk.
        myFile = File.CreateText("Philosophers.txt")

        ' Write the names of the three philosophers to the file.
        myFile.WriteLine("John Locke")
        myFile.WriteLine("David Hume")
        myFile.WriteLine("Edmund Burke")
        myFile.WriteLine("Jesus Calderon")
        myFile.WriteLine("This is to see the effect of adding text to a file")

        ' Close the file.
        myFile.Close()
    End Sub

End Module
