using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactoryPattern
{
    internal class SteelTyre:ICarTyre
    {
        public void DisplayTyre()
        {
            Console.WriteLine("Tyre type : "+this.GetType().Name);
        }
    }
}
