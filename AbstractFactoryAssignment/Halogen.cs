using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.TATA.Products.Carlight.LightTypes
{
    internal class Halogen : ICarLight
    {
        public string Color()
        {
            return "Yellow";
        }
    }
}
