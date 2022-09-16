using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.Maruti.Products.CarEngine.EngineTypes;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.Maruti.Products.Carlight.LightParts;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.Maruti
{
    internal class MarutiFactory : IVehicleFactory
    {
        public ICarEngine CreateCarEngine()
        {
            return new DDIS();
        }

        public ICarLight CreateCarLight()
        {
            return new LED();
        }

    }
}
