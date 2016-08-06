Module Module1

    Sub Main()
        Dim mass As Double
        Dim velocity As Double
        Dim KEnergy As Double


        Console.Write("Enter the mass of the object in kilograms: ")
        mass = CDbl(Console.ReadLine())

        Console.Write("Enter the speed of the object in meters per second: ")
        velocity = CDbl(Console.ReadLine())

        KEnergy = CalculateKe(mass, velocity)

        Console.WriteLine("The Kinetic Energy is  " & KEnergy & " Joules.")

        Console.ReadLine()

    End Sub

    Function CalculateKe(ByVal mass As Double, ByVal velocity As Double) As Double
        Dim result As Integer

        result = 0.5 * mass * (velocity * velocity)

        Return result

    End Function



End Module
