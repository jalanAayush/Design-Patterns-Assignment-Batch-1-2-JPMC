using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class TataFactory:IVehicleFactory
    {
        public ICarEngine CreateCarEngine()
        {
            return new DDI();
        }

        public ICarLight CreateCarLight()
        {
            return new Helogen();
        }
    }
}
