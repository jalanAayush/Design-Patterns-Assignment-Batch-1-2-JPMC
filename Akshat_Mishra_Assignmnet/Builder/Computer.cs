using System;
using System.Collections.Generic;

namespace Builder
{
    class Computer
    {
        private string _computerType;
        private Dictionary<string, string> _parts =  new Dictionary<string, string>();

        public Computer(string computerType)
        {
            this._computerType = computerType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n*********************************");

            Console.WriteLine("Computer Type: {0}", _computerType);

            Console.WriteLine(" HardDIsk : {0}", _parts["harddisk"]);

            Console.WriteLine(" MotherBoard : {0}", _parts["motherboard"]);

            Console.WriteLine(" Processor: {0}", _parts["processor"]);

            Console.WriteLine(" Screen : {0}", _parts["screen"]);
        }
    }
}
