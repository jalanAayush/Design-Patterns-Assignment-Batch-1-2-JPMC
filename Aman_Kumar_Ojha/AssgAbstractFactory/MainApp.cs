namespace AssgAbstractFactory
{
    public class MainApp
    {
        public static void Main()
        {
            IVehicleFactory Maruti = new MarutiFactory();
            CarWorld world = new CarWorld(Maruti);
            Console.WriteLine("Maruti has : ");
            world.DisplayDetails();

            IVehicleFactory Tata = new TataFactory();
            world = new CarWorld(Tata);
            Console.WriteLine("Tatat has : ");
            world.DisplayDetails();
        }
    }
}