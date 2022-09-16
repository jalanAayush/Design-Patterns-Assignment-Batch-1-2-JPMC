using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAssignment
{
    internal class Helogan:ICarLight
    {
        public void install()
        {
            Console.WriteLine("Helogen Light installed");
        }
    }
}
