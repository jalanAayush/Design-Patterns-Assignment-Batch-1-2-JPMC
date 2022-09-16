using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    abstract class VehicleFactory
    {
        public abstract CarLight CreateCarLight();
        public abstract CarEngine CreateCarEngine();
    }
}
