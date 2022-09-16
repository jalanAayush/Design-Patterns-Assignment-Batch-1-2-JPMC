using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgAbstractFactory
{
    internal class LED : ICarLight
    {
        public override void DisplayLight()
        {
            Console.WriteLine("Light type : {0}", this.GetType().Name);
        }
    }
}
