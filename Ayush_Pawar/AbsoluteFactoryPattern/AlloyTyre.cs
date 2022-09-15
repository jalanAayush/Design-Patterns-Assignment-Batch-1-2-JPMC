using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactoryPattern
{
    internal class AlloyTyre:ICarTyre
    {
        public void DisplayTyre()
        {
            Console.WriteLine("Tyres : "+this.GetType().Name);
        }
    }
}
