using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    
    internal class MarutiFactory : IVehicleFactory
    {

        public ICarEngine createCarEngine()
        {
            return new Revtron();
        }

        public ICarLight createCarLight()
        {
            return new LED();
        }

    }
}
