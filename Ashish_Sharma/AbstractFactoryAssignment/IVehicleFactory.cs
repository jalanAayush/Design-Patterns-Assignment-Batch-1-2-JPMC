using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory
{
    internal interface IVehicleFactory
    {
        public ICarEngine CreateCarEngine();
        public ICarLight CreateCarLight();
    }
}
