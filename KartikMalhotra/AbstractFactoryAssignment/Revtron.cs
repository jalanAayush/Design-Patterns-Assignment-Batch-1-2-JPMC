using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.TATA.Products.CarEngine.EngineTypes
{
    internal class Revtron : ICarEngine
    {
        public void AttachLight(ICarLight light)
        {
            Console.WriteLine("Engine Type : " + this.GetType().Name);
            Console.WriteLine("Light Type  : " + light.GetType().Name);
            Console.WriteLine("Light Color : " + light.Color());
        }
    }
}
