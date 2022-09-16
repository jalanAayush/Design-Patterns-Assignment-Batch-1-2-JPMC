namespace DesignPatternAssignment.AbstractFactory
{
    abstract class VehicleFactory
    {
        public abstract CarLight CreateCarLight();
        public abstract CarEngine CreateCarEngine();
    }
}
