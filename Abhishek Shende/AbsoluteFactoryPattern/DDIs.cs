using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class DDIs:IEngine
    {
        public void DisplayEngine()
        {
            Console.WriteLine("Engine Type : "+this.GetType().Name);
        }
    }
}
