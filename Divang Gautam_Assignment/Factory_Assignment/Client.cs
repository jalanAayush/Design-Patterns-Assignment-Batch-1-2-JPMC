using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Assignment
{
    class Client
    {
        private CarEngine _engine;
        private CarLight _light;

        public Client(VehicleFactory vehicleFactory)
        {
            _light = vehicleFactory.CreateProduct1();
            _engine = vehicleFactory.CreateProduct2();
        }

        public void ShowResults()
        {
            _engine.TypeOfCarEngine();
            _light.TypeOfCarLight();
        }
    }
}
