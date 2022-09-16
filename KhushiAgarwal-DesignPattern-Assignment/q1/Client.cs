using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
   
        internal class Client
        {
            public void createClientChoice(IVehicleFactory factory)
            {

                var engineProuct = factory.createCarEngine();
                var lightProduct = factory.createCarLight();



                engineProuct.addCarEngine();
                lightProduct.addCarLight();

            }
        }
    
}
