using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAssignment
{
    internal class Client
    {
        public static void Main()
        {
            Console.WriteLine("Which Vehicle Manufacturer would you like to choose:");
            Console.WriteLine("1. Maruti\n2. Tata\nEnter 1 or 2: ");
            int vehicleManufacturer = int.Parse(Console.ReadLine());

            IVehicleFactory factory;

            if(vehicleManufacturer == 1)
            {
                factory = new MarutiFactory();
            }
            else if(vehicleManufacturer == 2)
            {
                factory = new TataFactory();
            }
            else
            {
                Console.WriteLine("Invalid value!!");
                return;
            }

            Console.WriteLine("Which type of Engine to install:");
            Console.WriteLine("1. Revtron\n2. DDis\nEnter 1 or 2: ");
            int engineType = int.Parse(Console.ReadLine());
            
            if(engineType != 1 && engineType != 2)
            {
                Console.WriteLine("Invalid value!!");
                return;
            }

            Console.WriteLine("Which type of Light to install:");
            Console.WriteLine("1. Helogan\n2. LED\nEnter 1 or 2: "); ;
            int lightType = int.Parse(Console.ReadLine());
            if (lightType != 1 && lightType != 2)
            {
                Console.WriteLine("Invalid value!!");
                return;
            }

            if (engineType == 1)
            {
                if (lightType == 1)
                {
                    ICarLight light = factory.installLight("Helogen");
                    ICarEngine engine = factory.installEngine("Revtron");
                }
                else
                {
                    ICarLight light = factory.installLight("LED");
                    ICarEngine engine = factory.installEngine("Revtron");
                }
            }
            else
            {
                if (lightType == 1)
                {
                    ICarLight light = factory.installLight("Helogen");
                    ICarEngine engine = factory.installEngine("DDis");
                }
                else
                {
                    ICarLight light = factory.installLight("LED");
                    ICarEngine engine = factory.installEngine("DDis");
                }
            }
        }
    }
}
