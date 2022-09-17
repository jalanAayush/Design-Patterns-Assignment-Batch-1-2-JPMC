namespace AbstractFactoryAssignment
{
    public class MainClass
    {
        static void Main()
        {
            IVehicleFactory marutiFactory = new MarutiFactory();
            IVehicleLight HeadLight = new Led();
            IVehicleEngine Reva = new Revtron();
            IVehicle marutiCar = marutiFactory.CreateVehicle(Reva, HeadLight);

            Console.WriteLine(marutiCar.Light.GetType().Name);
            Console.WriteLine(marutiCar.Engine.GetType().Name);
        }
    }
}