using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactoryPattern
{
    internal class TataFactory:IVehicleFactory
    {
        public ICarEngine AttachEngine()
        {
            return new Revotron();
        }
        public ICarTyre AttachTyre()
        {
            return new AlloyTyre();
        }
        public ICarLight AttachLight()
        {
            return new LED();
        }
    }
}
