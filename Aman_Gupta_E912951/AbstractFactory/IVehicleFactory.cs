using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class IVehiclesFactory
    {
        public abstract ICarsEngine CarsEngine();
        public abstract ICarsLight CarsLight();
    }
}
