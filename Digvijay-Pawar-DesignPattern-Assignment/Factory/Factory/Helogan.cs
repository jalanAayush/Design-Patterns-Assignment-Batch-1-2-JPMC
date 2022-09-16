using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Helogan:CarLight
    {
        public bool carHeloganLightStatus = true;
        public void addLight()
        {
            Console.WriteLine("Car Helogan light is added Sucessfully");
            carHeloganLightStatus = true;
        }

        public void removeLight()
        {
            Console.WriteLine("Car LED Helogan is removed from the Car");
        }
        public void checkLightStatus()
        {
            if (carHeloganLightStatus)
            {
                Console.WriteLine("Car Helogan Light is Working Properly");
            }
            else
            {
                Console.WriteLine("Damage in the Car Helogan light");
            }
        }
       

        public void replaceLight()
        {
            removeLight();
            addLight();
        }
    }
}
