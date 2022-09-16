using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute
{
    public interface IVehicleFactory
    {
        public ICarLight AttachLight();
        public ICarEngine AttachEngine();

        public ICarTyre AttachTyre();
    }
}