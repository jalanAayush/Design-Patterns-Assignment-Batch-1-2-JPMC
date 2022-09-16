using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAssignment
{
    internal class DDis : ICarEngine
    {
        public void install()
        {
            Console.WriteLine("DDis Engine installed");
        }
    }
}
