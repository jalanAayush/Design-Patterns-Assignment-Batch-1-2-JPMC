using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Client
    {
        public void createClientChoice(VehicleFactory factory)
        {
            var engine = factory.createCarEngine();
            var light = factory.createCarLight();
            engine.addEngine();
            light.addLight();
        }
    }
}
