using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    internal class MarutiFactory:IVehicleFactory
    {
        public IEngine AttachEngine()
        {
            return new DDIs();
        }
        public ILight AttachLight() 
        {
            return new Halogen();
        }

        public ITyre AttachTyre()
        {
            return new SteelTyre();
        }
    }
}
