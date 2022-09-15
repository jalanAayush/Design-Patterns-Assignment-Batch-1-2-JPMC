using FactoryDesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factories
{
    class MarutiFactory : IVehicleFactory
    {
        public ICarLight CreateCarLight()
        {
            return new Halogen();
        }
        public ICarEngine CreateCarEngine()
        {
            return new DDis();
        }
    }
}
