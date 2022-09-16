using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Assignment
{
    internal class Revetron : CarEngine
    {
        public override void TypeOfCarEngine()
        {
            Console.WriteLine("Revetron Included");
        }
    }
}
