namespace DesignPatternAssignment.AbstractFactory
{
    class DDI : CarLight
    {
        public override string DisplayLight()
        {
            return String.Format(this.GetType().Name + " light");
        }
    }
}
