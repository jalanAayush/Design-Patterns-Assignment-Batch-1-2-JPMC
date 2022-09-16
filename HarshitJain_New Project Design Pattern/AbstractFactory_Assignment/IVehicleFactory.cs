using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal interface IVehicleFactory
    {
         ICarEngineAction createCarEngine();
         ICarLightModifier createCarLight();

    }
}
