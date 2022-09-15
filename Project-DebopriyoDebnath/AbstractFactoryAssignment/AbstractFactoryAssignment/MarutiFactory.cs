using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    class MarutiFactory : VehicleFactory
    {
        public override CarEngine CreateCarEngine()
        {
            return new Revtron();
        }

        public override CarLight CreateCarLight()
        {
            return new DDI();
        }
    }
}
