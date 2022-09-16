namespace Factory_Assignment
{
    internal class Program
    {
        static void Main()
        {
            VehicleFactory maruti = new MarutiFactory();
            Client marutiWorld = new Client(maruti);
            Console.WriteLine("Maruti has " + marutiWorld.DisplayDetails());

            VehicleFactory tata = new TataFactory();
            Client tataWorld = new Client(tata);
            Console.WriteLine("Tata has " + tataWorld.DisplayDetails());

        }
    }
}