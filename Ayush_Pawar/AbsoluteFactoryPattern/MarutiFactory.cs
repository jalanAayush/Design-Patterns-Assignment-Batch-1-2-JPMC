using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactoryPattern
{
    internal class MarutiFactory:IVehicleFactory
    {
        public ICarEngine AttachEngine()
        {
            return new DDIs();
        }
        public ICarLight AttachLight() 
        {
            return new Halogen();
        }

        public ICarTyre AttachTyre()
        {
            return new SteelTyre();
        }
    }
}
