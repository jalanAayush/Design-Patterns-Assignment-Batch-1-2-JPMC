namespace DesignPatternAssignment.AbstractFactory
{
    class LED : CarLight
    {
        public override string DisplayLight()
        {
            return String.Format(this.GetType().Name + " light");
        }
    }
}
