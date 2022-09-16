using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternAssignment.Computers
{
    internal class Computer
    {
        private string _computerType;
        private Dictionary<string, string> _computerParts = new Dictionary<string, string>();

        public Computer(string computerType)
        {
            this._computerType = computerType;
        }

        public string this[string part]
        {
            get { return _computerParts[part]; }
            set { _computerParts[part] = value; }
        }

        public void ShowCase()
        {
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("Computer - Type : {0}", _computerType);
            Console.WriteLine();
            Console.WriteLine("Specification =====================");
            Console.WriteLine();
            Console.WriteLine("Storage      : {0}", _computerParts["HardDisk"]);
            Console.WriteLine("RAM          : {0}", _computerParts["RAM"]);
            Console.WriteLine("Processor    : {0}", _computerParts["Processor"]);
            Console.WriteLine("Mother-Board : {0}", _computerParts["Motherboard"]);
            Console.WriteLine("Screen-Size  : {0}", _computerParts["Screen"]);
        }
    }
}
