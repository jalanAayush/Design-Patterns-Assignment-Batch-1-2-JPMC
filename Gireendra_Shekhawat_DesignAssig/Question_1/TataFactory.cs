using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_a
    {
    class TataFactory : IVehicleFactory
        {
        public ICarEngine CreateCarEngine()
            {
            return new Revtron();
            }

        public ICarLight CreateCarLight()
            {
            return new Halogen();
            }
        }
    }
