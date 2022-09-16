using Dishant_Lodaliya_DesignPatterns.Problems.Abstract_Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Abstract_Factory_Pattern
{
    class Client
    {
        private ICarLight _carLight;
        private ICarEngine _carEngine;

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
