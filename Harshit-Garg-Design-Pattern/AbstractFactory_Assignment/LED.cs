using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal class LED:ICarLight
    {

        public bool carLEDLightStatus = true;
        public void checkCarLightStatus()
        {
            if (carLEDLightStatus)
            {
                Console.WriteLine("Car LED Light is Working Properly");
            }
            else
            {
                Console.WriteLine("Damage in the Car LED light");
            }
        }
        public void addCarLight()
        {
            Console.WriteLine("Car LED light is added Sucessfully");
            carLEDLightStatus = true;
        }

        public void removeCarLight()
        {
            Console.WriteLine("Car LED Light is removed from the Car");
        }

        public void replaceCarLight()
        {
            removeCarLight();
            addCarLight();
        }
    }
}
