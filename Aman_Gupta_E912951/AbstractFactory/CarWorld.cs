using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class CarsWorld
    {
        private ICarsEngine _engine;
        private ICarsLight _light;

        public CarsWorld(IVehiclesFactory factory)
        {
            _engine = factory.CarsEngine();
            _light = factory.CarsLight();
        }

        public void DisplayDetails()
        {
            _engine.DisplayEngine();
            Console.WriteLine();
            _light.DisplayLight();
        }
    }
}
