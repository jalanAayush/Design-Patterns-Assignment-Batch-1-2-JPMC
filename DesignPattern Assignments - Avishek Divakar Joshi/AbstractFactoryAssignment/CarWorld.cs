using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    public class CarWorld
    {
        private ICarLight _light;
        private ICarEngine _engine;
        public CarWorld(CarFactory currentCar)
        {
            this._light = currentCar.createLight();
            this._engine = currentCar.createEngine();

        }

        public string showDetails()
        {
            return String.Format(this._light.showLight() + "and " + this._engine.showEngine());

        }

    }
}
