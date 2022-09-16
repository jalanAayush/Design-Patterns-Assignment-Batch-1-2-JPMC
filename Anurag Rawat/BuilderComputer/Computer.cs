using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderComputer
{
    internal class Computer
    {
        private string _computerType;
        private Dictionary<string, string> _computerparts = new Dictionary<string, string>();

        public Computer(string computerType)
        {
            _computerType = computerType;
            //_computerparts = computerparts;
        }

        public string this[string key]
        {
            get { return _computerparts[key]; }
            set { _computerparts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine("Computer Type : {0}", _computerType);
            Console.WriteLine("HardDisk : {0}", _computerparts["HardDisk"]);
            Console.WriteLine("MotherBoard : {0}", _computerparts["MotherBoard"]);
            Console.WriteLine("Processor : {0}", _computerparts["Processor"]);
            Console.WriteLine("Screen : {0}", _computerparts["Screen"]);
        }
    }
}
