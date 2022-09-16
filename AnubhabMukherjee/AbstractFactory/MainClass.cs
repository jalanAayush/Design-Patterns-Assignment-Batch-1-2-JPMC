namespace AbstractFactoryAssignment
{
    public class MainClass
    {
        static void Main()
        {
            IVehicleFactory marutiFactory = new MarutiFactory();
            IVehicleLight helogan = new Helogan();
            IVehicleEngine ddis = new Ddis();
            IVehicle marutiCar = marutiFactory.CreateVehicle(ddis, helogan);

            Console.WriteLine(marutiCar.GetType().Name);
        }
    }
}