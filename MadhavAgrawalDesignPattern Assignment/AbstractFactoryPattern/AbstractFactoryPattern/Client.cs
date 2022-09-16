using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class Client
    {
        public void ClientChoice(IVehicleFactory factory)
        {

            var engineProuct = factory.CreateCarEngine();
            var lightProduct = factory.CreateCarLight();



            engineProuct.AddCarEngine();
            lightProduct.AddCarLight();

        }
    }
}
