using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class TataFactory : IVehiclesFactory
    {
        public override ICarsEngine CarsEngine()
        {
            return new DDi();
        }

        public override ICarsLight CarsLight()
        {
            return new LED();
        }
    }
}
