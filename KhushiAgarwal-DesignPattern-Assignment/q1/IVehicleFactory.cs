using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal interface IVehicleFactory
    {
        ICarEngine createCarEngine();
        ICarLight createCarLight();

    }
}
