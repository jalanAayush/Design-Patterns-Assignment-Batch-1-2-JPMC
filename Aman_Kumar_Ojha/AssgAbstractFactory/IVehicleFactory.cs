using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgAbstractFactory
{
    abstract class IVehicleFactory
    {
        public abstract ICarEngine CarEngine();
        public abstract ICarLight CarLight();
    }
}
