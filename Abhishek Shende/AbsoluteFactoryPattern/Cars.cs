using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class Cars
    {
        private readonly IEngine _engine;
        private readonly ITyre _tyre;
        private readonly ILight _light;
        public Cars(IVehicleFactory carFactory)
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
