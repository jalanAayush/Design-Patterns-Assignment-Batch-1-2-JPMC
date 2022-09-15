using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    class CarWorld
    {
        private CarEngine _carEngine;
        private CarLight _carLight;

        public CarWorld(VehicleFactory factory)
        {
            this._carEngine = factory.CreateCarEngine();
            this._carLight = factory.CreateCarLight();
        }

        public string DisplayDetails()
        {
            return String.Format(_carEngine.DisplayEngine() + " and " + _carLight.DisplayLight());
        }
    }
}
