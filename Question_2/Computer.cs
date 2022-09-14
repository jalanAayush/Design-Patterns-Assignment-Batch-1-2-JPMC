using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
    {
    internal class Computer
        {
        private string _computerType;

        private Dictionary<string, string> _configs =
          new Dictionary<string, string>();

        public Computer(string computerType)
            {
            this._computerType = computerType;
            }
        public string this[string key]
            {
            get { return _configs[key]; }
            set { _configs[key] = value; }
            }

        public void DisplayConfiguration()
            {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Computer Type: {0}", _computerType);
            Console.WriteLine(" Hard Disk : {0}", _configs["hard Disk"]);
            Console.WriteLine(" Motherboard : {0}", _configs["motherboard"]);
            Console.WriteLine(" screen: {0}", _configs["screen"]);
            Console.WriteLine(" processor : {0}", _configs["processor"]);
            }
        }
    }
