using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class TataFactory:IVehicleFactory
    {
        public IEngine AttachEngine()
        {
            return new Revotron();
        }
        public ITyre AttachTyre()
        {
            return new AlloyTyre();
        }
        public ILight AttachLight()
        {
            return new LED();
        }
    }
}
