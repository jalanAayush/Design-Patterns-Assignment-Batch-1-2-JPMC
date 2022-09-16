using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class AlloyTyre:ITyre
    {
        public void DisplayTyre()
        {
            Console.WriteLine("Tyres : "+this.GetType().Name);
        }
    }
}
