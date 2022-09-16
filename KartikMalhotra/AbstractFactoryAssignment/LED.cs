using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.Maruti.Products.Carlight.LightParts
{
    internal class LED : ICarLight
    {
        public string Color()
        {
            return "Red";
        }
    }
}
