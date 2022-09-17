namespace AbstractFactoryAssignment
{
    class MarutiFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(IVehicleEngine engine, IVehicleLight light)
        {
            return new Maruti(engine, light);
        }
    }
}