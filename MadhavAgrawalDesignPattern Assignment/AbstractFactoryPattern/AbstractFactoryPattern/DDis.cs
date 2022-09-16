using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class DDis: ICarEngine
    {
        public void AddCarEngine()
        {
            Console.WriteLine("DDis Engine Added");


        }
    }
}
