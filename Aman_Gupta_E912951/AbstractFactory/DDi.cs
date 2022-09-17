using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class DDi : ICarsEngine
    {
        public override void DisplayEngine()
        {
            Console.WriteLine("Engine type : {0}", this.GetType().Name);
        }
        
    }
}
