using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Helogan:ICarLight
    {
        public void AddCarLight()
        {
            Console.WriteLine("Halogen Light Added");
        }

    }
}
