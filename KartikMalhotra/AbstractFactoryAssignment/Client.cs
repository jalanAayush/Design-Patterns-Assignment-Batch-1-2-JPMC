using AbstractFactoryAssignment.Vehicles.VehicleFactory;
using AbstractFactoryAssignment.Vehicles.VehicleFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment.Vehicles
{
    internal class Client
    {
        private ICarEngine _carEngine;
        private ICarLight _carLight;

        public Client(IVehicleFactory vehicleFactory)
        {
            _carEngine = vehicleFactory.CreateCarEngine();
            _carLight = vehicleFactory.CreateCarLight();
        }

        public void ShowCaseCarEngine()
        {
            _carEngine.AttachLight(_carLight);
        }
    }
}
