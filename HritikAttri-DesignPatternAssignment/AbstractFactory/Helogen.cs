namespace DesignPatternAssignment.AbstractFactory
{
    class Helogen : CarEngine
    {
        public override string DisplayEngine()
        {
            return String.Format(this.GetType().Name + " engine");
        }
    }
}
