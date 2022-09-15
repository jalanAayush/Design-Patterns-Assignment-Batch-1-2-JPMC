namespace AbstractFactoryImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory africa = new AfricanFactory();
            AnimalWorldcs animalWorldcs = new AnimalWorldcs(africa);
            animalWorldcs.RunFoodChain();

            ContinentFactory america = new AmericanFactory();
            AnimalWorldcs animalWorldcs1 = new AnimalWorldcs(america);
            animalWorldcs1.RunFoodChain();

        }
    }
}