namespace DesignPatterns
{
    class Wolf : Carnivores
    {
        public override void Eat(Herbivores h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
