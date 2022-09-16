using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class LED:ICarLight
    {
        public void AddCarLight()
        {
            Console.WriteLine("Led Light Added");
        }
    }
}
