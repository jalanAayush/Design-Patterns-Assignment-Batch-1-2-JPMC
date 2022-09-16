using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute
{
    internal class CarShowroom
    {
        private readonly ICarEngine _engine;
        private readonly ICarTyre _tyre;
        private readonly ICarLight _light;
        public CarShowroom(IVehicleFactory carFactory)
        {
            this._engine = carFactory.AttachEngine();
            this._tyre = carFactory.AttachTyre();
            this._light = carFactory.AttachLight();
        }

        public void DisplayBrochure()
        {
            this._engine.DisplayEngine();
            this._tyre.DisplayTyre();
            this._light.DisplayLight();
        }
    }
}
