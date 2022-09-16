using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class TataFactory : VehicleFactory
    {
        public override CarEngine CreateCarEngine()
        {
            return new Helogen();
        }

        public override CarLight CreateCarLight()
        {
            return new LED();
        }
    }
}
