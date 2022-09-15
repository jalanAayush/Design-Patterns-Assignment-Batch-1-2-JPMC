using FactoryDesignPattern.Factories;
using FactoryDesignPattern.FactoryInterface;
using FactoryDesignPattern.ProductInterface;
using FactoryDesignPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Client
    {
        private ICarLight _carLight;
        private ICarEngine _carEngine;

        // Constructor

        public Client(IVehicleFactory factory)
        {
            _carLight = factory.CreateCarLight();
            _carEngine = factory.CreateCarEngine();
        }

        public void RunFactory()
        {
            _carEngine.Start(_carLight);
        }
    }
}
