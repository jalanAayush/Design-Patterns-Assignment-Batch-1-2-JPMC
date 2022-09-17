using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Helogan : ICarsLight
    {
        public override void DisplayLight()
        {
            Console.WriteLine("Light type : {0}", this.GetType().Name);
        }
    }
}
