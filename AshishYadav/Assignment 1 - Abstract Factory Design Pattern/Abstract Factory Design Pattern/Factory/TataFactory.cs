using FactoryDesignPattern.FactoryInterface;
using FactoryDesignPattern.ProductInterface;
using FactoryDesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factories
{
    class TataFactory : IVehicleFactory
    {
        public  ICarLight CreateCarLight()
        {
            return new LED();
        }
        public  ICarEngine CreateCarEngine()
        {
            return new Revtron();
        }
    }
}
