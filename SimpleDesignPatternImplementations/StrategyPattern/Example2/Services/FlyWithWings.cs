using SimpleDesignPatternImplementations.StrategyPattern.Example2.Interfaces;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example2.Services
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly with my wings!");
        }
    }
}
