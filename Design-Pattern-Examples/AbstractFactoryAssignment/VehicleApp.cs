using AbstractFactoryAssignment.Vehicles;
using AbstractFactoryAssignment.Vehicles.VehicleFactory;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.Maruti;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.TATA;

namespace AbstractFactoryAssignment
{
    internal class VehicleApp
    {
        static void Main(string[] args)
        {
            IVehicleFactory vehicleFactory;

            Console.WriteLine("Welcome to The Engine ShowRoom");
            Console.WriteLine();
            Console.WriteLine("Choose Your company to see Engine");
            Console.WriteLine(" 1.Maruti");
            Console.WriteLine(" 2.TATA");
            Console.Write("Company ID : ( 1 or 2 ) = ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: vehicleFactory = new MarutiFactory();break;
                case 2: vehicleFactory = new TATAFactory();break;
                default: vehicleFactory = new TATAFactory();break;
            }

            Console.WriteLine("************ CAR ENGINE ************");
            Console.WriteLine();
            Client client = new Client(vehicleFactory);
            client.ShowCaseCarEngine();
        }
    }
}