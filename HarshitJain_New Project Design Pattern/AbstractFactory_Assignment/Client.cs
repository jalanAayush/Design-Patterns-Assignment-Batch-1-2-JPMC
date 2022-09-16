using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal class Client
    {
        public void ClientChoice(IVehicleFactory factory)
        {
           
                var engineProuct = factory.createCarEngine();
                var lightProduct= factory.createCarLight();



            engineProuct.addCarEngine();
            lightProduct.addCarLight();

        }
    }
}
