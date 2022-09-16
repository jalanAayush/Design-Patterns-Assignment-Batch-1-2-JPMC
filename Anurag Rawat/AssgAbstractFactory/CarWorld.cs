using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssgAbstractFactory
{
    internal class CarWorld
    {
        private ICarEngine _engine;
        private ICarLight _light;

        public CarWorld(IVehicleFactory factory)
        {
            _engine = factory.CarEngine();
            _light = factory.CarLight();
        }

        public void DisplayDetails()
        {
            _engine.DisplayEngine();
            Console.WriteLine();
            _light.DisplayLight();
        }
    }
}
