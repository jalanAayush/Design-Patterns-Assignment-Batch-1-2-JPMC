using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory.Products
{
    internal interface ICarEngine
    {
        public void AttachLight(ICarLight light);
    }
}
