using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_a
    {
    class MarutiFactory : IVehicleFactory
        {
        public ICarEngine CreateCarEngine()
            {
            return new DDis();
            }

        public ICarLight CreateCarLight()
            {
            return new LED();
            }
        }
    }
