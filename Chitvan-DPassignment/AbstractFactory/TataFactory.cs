namespace AbstractFactoryAssignment
{
    class TataFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(IVehicleEngine engine, IVehicleLight light)
        {
            return new Maruti(engine, light);
        }
    }
}