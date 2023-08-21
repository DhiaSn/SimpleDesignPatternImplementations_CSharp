using SimpleDesignPatternImplementations.StrategyPattern.Example2.Services;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example2.Models
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quacking();
        }

        public override void Display()
        {
            Console.WriteLine("Hello guys!\n I am a Mallard Duck");
        }
    }
}
