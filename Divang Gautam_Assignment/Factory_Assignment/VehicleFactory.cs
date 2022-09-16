using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Assignment
{
    abstract class VehicleFactory
    {
        public abstract CarLight CreateProduct1();
        public abstract CarEngine CreateProduct2();
    }
}
