

namespace DesignPatterns
{
    class AfricaFactory: ContinentFacotry
    {
        public override Herbivores CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivores CreateCarnivore()
        {
            return new Lion();
        }
    }
}
