using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteFactoryPattern
{
    public interface IVehicleFactory
    {
        public ICarLight AttachLight();
        public ICarEngine AttachEngine();

        public ICarTyre AttachTyre();
    }
}