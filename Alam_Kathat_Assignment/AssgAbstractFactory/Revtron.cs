using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgAbstractFactory
{
    internal class Revtron:ICarEngine
    {
        public override void DisplayEngine()
        {
            Console.WriteLine("Engine type : {0}", this.GetType().Name);
        }
    }
}
