Module Module1
    'Declaring Variables
    Dim color1 As String
    Dim color2 As String
    Dim color3 As String
    Dim purple As String
    Dim orange As String
    Dim green As String
    Dim mixedcolor1 As String
    Dim mixedcolor2 As String
    Dim mixedcolor3 As String
    Sub Main()

        Console.WriteLine("Enter primary colors to get secondary colors")
        Console.ReadLine()

        If color1 = "red" And color2 = "blue" Then
            mixedcolor1 = purple
        ElseIf color1 = "red " And color3 = "yellow" Then
            mixedcolor2 = "orange"
        ElseIf color2 And color3 Then
            mixedcolor3 = "green"

            Console.WriteLine("if colors are not primary colors please display error message")
            Console.ReadLine()



        End If

    End Sub

End Module
