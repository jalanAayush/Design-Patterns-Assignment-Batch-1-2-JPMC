using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactory
{
    public interface IVehicleFactory
    {
        public ILight AttachLight();
        public IEngine AttachEngine();

        public ITyre AttachTyre();
    }
}