namespace DesignPatternAssignment.AbstractFactory
{
    class MarutiFactory : VehicleFactory
    {
        public override CarEngine CreateCarEngine()
        {
            return new Revtron();
        }

        public override CarLight CreateCarLight()
        {
            return new DDI();
        }
    }
}
