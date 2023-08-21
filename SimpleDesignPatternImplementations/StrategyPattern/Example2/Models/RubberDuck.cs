using SimpleDesignPatternImplementations.StrategyPattern.Example2.Services;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example2.Models
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("sorry guys, I couldn't make to be a real duck, at least I can squeak :p ");
        }
    }
}
