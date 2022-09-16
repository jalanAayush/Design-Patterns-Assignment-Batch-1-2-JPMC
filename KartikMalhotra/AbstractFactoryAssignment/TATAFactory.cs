using AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.TATA.Products.CarEngine.EngineTypes;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.TATA.Products.Carlight.LightTypes;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.TATA
{
    internal class TATAFactory : IVehicleFactory
    {
        public ICarEngine CreateCarEngine()
        {
            return new Revtron();
        }

        public ICarLight CreateCarLight()
        {
            return new Halogen();
        }
    }
}