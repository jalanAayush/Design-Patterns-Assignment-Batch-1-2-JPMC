using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Assignment
{
    public class Computer
    {
        private string _computerType;
        private Dictionary<object, object> _parts = new Dictionary<object, object>();

        public Computer(string computerType)
        {
            this._computerType = computerType;
        }

        public string this[string key]
        {
            get { return (string)_parts[key]; }
            set { _parts[key] = value; }
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("\n Computer Type : " + this._computerType);
            Console.WriteLine(" Hard Disk : " + this._parts["hardDisk"]);
            Console.WriteLine(" Mother Board : " + this._parts["motherBoard"]);
            Console.WriteLine(" Processor : " + this._parts["processor"]);
            Console.WriteLine(" Screen : " + this._parts["screen"]);
        }
    }
}
