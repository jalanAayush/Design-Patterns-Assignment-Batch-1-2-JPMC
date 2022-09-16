using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class LED:ILight
    {
        public void DisplayLight()
        {
            Console.WriteLine("Lights : "+this.GetType().Name);
        }
    }
}
