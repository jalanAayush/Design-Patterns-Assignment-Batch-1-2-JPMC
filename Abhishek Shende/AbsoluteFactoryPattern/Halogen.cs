using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class Halogen:ILight
    {

        public void DisplayLight()
        {
            Console.WriteLine("Lights : "+this.GetType().Name);
        }
    }
}
