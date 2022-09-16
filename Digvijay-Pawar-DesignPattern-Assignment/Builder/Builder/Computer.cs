using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Computer
    {
        private string _compType;
        private Dictionary<string, string> _compParts = new Dictionary<string, string>();

        public Computer(string compType)
        {
            this._compType = compType;
        }

        public string this[string part]
        {
            get {  return _compParts[part]; }
            set { _compParts[part] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Computer Type: {0}", this._compType);
            Console.WriteLine("HardDIsk : {0}", this._compParts["hardDisk"]);
            Console.WriteLine("MotherBoard : {0}", this._compParts["motherboard"]);
            Console.WriteLine("Processor: {0}", this._compParts["processor"]);
            Console.WriteLine("Screen : {0}", this._compParts["screen"]);
        }
    }
}
