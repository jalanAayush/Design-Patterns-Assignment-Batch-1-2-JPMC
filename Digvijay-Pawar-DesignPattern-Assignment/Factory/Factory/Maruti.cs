using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Maruti:VehicleFactory
    {
        public CarEngine createCarEngine()
        {
            return new Revtron();
        }

        public CarLight createCarLight()
        {
            return new LED();
        }
    }
}
