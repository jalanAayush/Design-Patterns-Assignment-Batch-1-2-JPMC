using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal class MarutiFactory:IVehicleFactory
    {
         
       public ICarEngineAction createCarEngine()
        {
            return new Revtron();
        }

        public ICarLightModifier createCarLight()
        {
            return new LED();
        }

    }
}
