// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using AbstractFactoryAssignment;

public class MainClass
{
    public static void Main()
    {
        VehicleFactory maruti = new MarutiFactory();
        CarWorld marutiWorld = new CarWorld(maruti);
        Console.WriteLine("Maruti has " + marutiWorld.DisplayDetails());

        VehicleFactory tata = new TataFactory();
        CarWorld tataWorld = new CarWorld(tata);
        Console.WriteLine("Tata has " + tataWorld.DisplayDetails());
    }
}
