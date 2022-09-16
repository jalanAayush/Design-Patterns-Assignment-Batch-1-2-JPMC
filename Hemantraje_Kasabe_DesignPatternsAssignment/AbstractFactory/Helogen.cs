using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Helogen:ICarLight
    {
        public bool carHeloganLightStatus = true;
        public void CheckCarLightStatus()
        {
            if (carHeloganLightStatus)
            {
                Console.WriteLine("Car Helogan Light working");
            }
            else
            {
                Console.WriteLine("Damage detected the Car Helogan light");
            }
        }
        public void AddCarLight()
        {
            Console.WriteLine("Car Helogan light installed");
            carHeloganLightStatus = true;
        }

        public void RemoveCarLight()
        {
            Console.WriteLine("Car Helogan light removed");
        }

        public void ReplaceCarLight()
        {
            // Replace = Remove + Add new
            RemoveCarLight();
            AddCarLight();
        }
    }
}
