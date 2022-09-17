using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern.Builder
{
    internal class Computer
    {
        public string ComputerType { get; set; }
        public string HardDisk { get; set; }

        public string Motherboard { get; set; }

        public string Processor { get; set; }

        public string Screen { get; set; }


        public void DisplayConfiguration()
        {
            Console.WriteLine("Computer type is  {0}", ComputerType);

            Console.WriteLine("Hard Disk  is  {0}", HardDisk);

            Console.WriteLine("Motherboard is {0}", Motherboard);

            Console.WriteLine("Processor is {0}", Processor);

            Console.WriteLine("Screen is {0}", Screen);

        }


    }
}
