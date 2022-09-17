using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal class Helogan : ICarLightModifier
    {
        public bool carHeloganLightStatus = true;
        public void checkCarLightStatus()
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
        public void addCarLight()
        {
            Console.WriteLine("Car Helogan light is added Sucessfully");
            carHeloganLightStatus = true;
        }

        public void removeCarLight()
        {
            Console.WriteLine("Car LED Helogan is removed from the Car");
        }

        public void replaceCarLight()
        {
            removeCarLight();
            addCarLight();
        }
    }
}
