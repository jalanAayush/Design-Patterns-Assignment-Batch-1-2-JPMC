using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Computer
    {
        private string _type;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Computer(string type)
        {
            this._type = type;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void DisplayInformation()
        {
            Console.WriteLine("\n Computer Type : " + this._type);
            Console.WriteLine(" Hard Disk : " + this._parts["HardDisk"]);
            Console.WriteLine(" Mother Board : " + this._parts["MotherBoard"]);
            Console.WriteLine(" Processor : " + this._parts["Processor"]);
            Console.WriteLine(" Screen : " + this._parts["Screen"]);
        }
    }
}
