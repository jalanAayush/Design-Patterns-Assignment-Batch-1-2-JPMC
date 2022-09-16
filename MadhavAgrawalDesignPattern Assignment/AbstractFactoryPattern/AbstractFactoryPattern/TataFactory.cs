using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class TataFactory : IVehicleFactory
    {
        public ICarEngine CreateCarEngine()
        {
            return new DDis();
        }

        public ICarLight CreateCarLight()
        {
            return new Helogan();
        }
    }
}
