using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactoryPattern
{
    internal class LED:ICarLight
    {
        public void DisplayLight()
        {
            Console.WriteLine("Lights : "+this.GetType().Name);
        }
    }
}
