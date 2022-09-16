namespace AbstractFactoryAssignment
{
    interface IVehicle
    {
        IVehicleEngine Engine { get; set; }
        IVehicleLight Light { get; set; }
    }
}