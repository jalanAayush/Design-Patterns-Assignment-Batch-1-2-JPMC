using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MarutiFactory : IVehicleFactory
    {
        public ICarEngine CreateCarEngine()
        {
            return new Revtron();
        }

        public ICarLight CreateCarLight()
        {
            return new LED();
        }
    }
}
