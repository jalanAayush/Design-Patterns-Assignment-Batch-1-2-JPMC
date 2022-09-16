using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Computer
    {
        public string? ComputerType { get; set; }
        public string? HardDisk { get; set; }
        public string? Motherboard { get; set; }
        public string? Processor { get; set; }
        public string? Screen { get; set; }


        public void DisplayConfiguration()
        {
            Console.WriteLine("Computer Type : {0}", ComputerType);

            Console.WriteLine("Hard Disk : {0}", HardDisk);

            Console.WriteLine("Motherboard : {0}", Motherboard);

            Console.WriteLine("Processor : {0}", Processor);

            Console.WriteLine("Screen : {0}", Screen);


        }
/*        public Computer( string ComputerType)
        {
            this.ComputerType = ComputerType;
        }*/
    }
}
