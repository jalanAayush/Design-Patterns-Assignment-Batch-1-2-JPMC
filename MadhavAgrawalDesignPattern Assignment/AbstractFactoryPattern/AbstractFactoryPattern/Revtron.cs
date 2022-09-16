using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Revtron: ICarEngine
    {
        public void AddCarEngine()
        {
            Console.WriteLine("Revtron Engine Added");

        }
    }
}
