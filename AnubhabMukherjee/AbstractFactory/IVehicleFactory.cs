namespace AbstractFactoryAssignment
{
    interface IVehicleFactory
    {
        IVehicle CreateVehicle(IVehicleEngine engine, IVehicleLight light);
    }
}