using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;

namespace AbstractFactoryAssignment.Vehicles.VehicleFactory.Companies.Maruti.Products.CarEngine.EngineTypes
{
    internal class DDIS : ICarEngine
    {
        public void AttachLight(ICarLight light)
        {
            Console.WriteLine( "Engine Type : " +this.GetType().Name);
            Console.WriteLine( "Light Type  : " + light.GetType().Name);
            Console.WriteLine("Light Color : " + light.Color());
        }
    }
}
