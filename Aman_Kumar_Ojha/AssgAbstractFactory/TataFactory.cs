using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgAbstractFactory
{
    internal class TataFactory : IVehicleFactory
    {
        public override ICarEngine CarEngine()
        {
            return new DDi();
        }

        public override ICarLight CarLight()
        {
            return new LED();
        }
    }
}
