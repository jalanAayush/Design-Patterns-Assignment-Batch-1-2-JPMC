using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal class TataManufacturer:IVehicleFactory
    {
        public ICarEngineAction createCarEngine()
        {
            return new D3is();
        }

        public ICarLightModifier createCarLight()
        {
            return new Helogan();
        }
    }
}
