using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAssignment
{
    internal class LED : ICarLight
    {
        public void install()
        {
            Console.WriteLine("LED light installed");
        }
    }
}
