using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Builder
{
    internal class Computer
    {
        public string Screen { get; set; }
        public string HDD { get; set; }
        public string Processor { get; set; }
        public string Motherboard { get; set; }
        public Computer()
        {

        }

        public void Configuration()
        {
            Console.WriteLine("Screen: " + Screen);
            Console.WriteLine("HDD: " + HDD);
            Console.WriteLine("Processor: " + HDD);
            Console.WriteLine("Motherboard: " + HDD);

            Console.ReadKey();

        }

    }
}
