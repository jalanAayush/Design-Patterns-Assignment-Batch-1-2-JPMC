namespace AbstractFactoryAssignment
{
    class Tata : IVehicle
    {
        public IVehicleEngine Engine { get; set; }
        public IVehicleLight Light { get; set; }
        public Tata(IVehicleEngine engine, IVehicleLight Light)
        {
            Engine = engine;
            this.Light = Light;
        }
    }
}