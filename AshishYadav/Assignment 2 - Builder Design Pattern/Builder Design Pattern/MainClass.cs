using Builder_Design_Pattern.Builder;
using Builder_Design_Pattern.Builder.BuilderInterface;
using Builder_Design_Pattern.Product;

namespace Builder_Design_Pattern
{
    public class MainClass
    {
        public static void Main()
        {
            Director director = new Director();
            IComputerBuilder ComputerBuilder = new DesktopBuilder();

            director.BuildComputer(ComputerBuilder);

            Computer myComputer = ComputerBuilder.GetComputer();
            myComputer.Configuration();
        }
    }
}