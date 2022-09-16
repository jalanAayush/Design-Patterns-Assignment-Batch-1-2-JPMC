namespace AbstractFactoryAssignment
{
    class Maruti : IVehicle
    {
        public IVehicleEngine Engine { get; set; }
        public IVehicleLight Light { get; set; }
        public Maruti(IVehicleEngine engine, IVehicleLight Light)
        {
            Engine = engine;
            this.Light = Light;
        }
    }
}