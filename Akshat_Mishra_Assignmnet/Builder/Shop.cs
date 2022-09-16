
namespace Builder
{

    class Shop
    {

        public void Construct(ComputerBuilder computerBuilder)
        {
            computerBuilder.HardDisk();
            computerBuilder.MotherBoard();
            computerBuilder.Processor();
            computerBuilder.Screen();
        }
    }
}
