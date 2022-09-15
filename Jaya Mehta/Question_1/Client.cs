namespace Assignment1_a
    {
    class Client
        {
        private ICarEngine _engine;
        private ICarLight _light;

        public Client(IVehicleFactory factory)
            {
            _engine = factory.CreateCarEngine();
            _light = factory.CreateCarLight();
            }
        public void CarAccessoriesBusiness()
            {
            _engine.carAccessories();
            _light.carAccessories();
            }
        }
    }
        
    