namespace DesignPatterns
{
    class AmericanFactory:ContinentFacotry
    {
        public override Herbivores CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivores CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
