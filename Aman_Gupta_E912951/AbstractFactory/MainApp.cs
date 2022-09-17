namespace AbstractFactory
{
    public class MainApp
    {
        public static void Main()
        {
            IVehiclesFactory Maruti = new MarutiFactory();
            CarsWorld world = new CarsWorld(Maruti);
            Console.WriteLine("Maruti has : ");
            world.DisplayDetails();

            IVehiclesFactory Tata = new TataFactory();
            world = new CarsWorld(Tata);
            Console.WriteLine("Tatat has : ");
            world.DisplayDetails();
        }
    }
}