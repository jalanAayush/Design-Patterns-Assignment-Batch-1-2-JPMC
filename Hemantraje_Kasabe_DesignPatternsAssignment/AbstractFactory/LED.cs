using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class LED: ICarLight
    {
        public bool carLEDLightStatus = true;
        public void CheckCarLightStatus()
        {
            if (carLEDLightStatus)
            {
                Console.WriteLine("Car LED Light Working");
            }
            else
            {
                Console.WriteLine("Damage detected in the Car LED light");
            }
        }
        public void AddCarLight()
        {
            Console.WriteLine("Car LED light installed");
            carLEDLightStatus = true;
        }

        public void RemoveCarLight()
        {
            Console.WriteLine("Car LED Light removed");
        }

        public void ReplaceCarLight()
        {
            RemoveCarLight();
            AddCarLight();
        }

    }
}
