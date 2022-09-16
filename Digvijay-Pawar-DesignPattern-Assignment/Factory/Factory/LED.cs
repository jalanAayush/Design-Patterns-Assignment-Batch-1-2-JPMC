using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class LED:CarLight
    {
        public bool carLEDLightStatus = true;

        public void addLight()
        {
            Console.WriteLine("Car LED light is added Sucessfully");
            carLEDLightStatus = true;
        }

        public void removeLight()
        {
            Console.WriteLine("Car LED Light is removed from the Car");
        }
        public void checkLightStatus()
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
        

        public void replaceLight()
        {
            removeLight();
            addLight();
        }
    }
}
