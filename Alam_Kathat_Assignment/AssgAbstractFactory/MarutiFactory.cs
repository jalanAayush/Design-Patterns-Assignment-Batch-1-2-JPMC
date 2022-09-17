using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgAbstractFactory
{
    internal class MarutiFactory : IVehicleFactory
    {
        public override ICarEngine CarEngine()
        {
            return new Revtron();
        }

        public override ICarLight CarLight()
        {
            return new Helogan();
        }
    }
}
