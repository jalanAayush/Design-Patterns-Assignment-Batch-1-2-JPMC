using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class Revotron:IEngine
    {
        
        public void DisplayEngine()
        {
            Console.WriteLine("Engine type : "+this.GetType().Name);
        }
    }
}
