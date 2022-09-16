namespace DesignPatternAssignment.AbstractFactory
{
    public class MainProgram
    {
        public static void Main()
        {
            VehicleFactory maruti = new MarutiFactory();
            CarWorld marutiWorld = new CarWorld(maruti);
            Console.WriteLine("Maruti car has " + marutiWorld.DisplayDetails());

            VehicleFactory tata = new TataFactory();
            CarWorld tataWorld = new CarWorld(tata);
            Console.WriteLine("Tata car has " + tataWorld.DisplayDetails());
        }
    }
}
