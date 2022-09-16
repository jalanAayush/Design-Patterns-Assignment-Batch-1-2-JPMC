using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Assignment
{
    internal class LED : CarLight
    {
        public override void TypeOfCarLight()
        {
            Console.WriteLine("LED Included");
        }
    }
}
