using SimpleDesignPatternImplementations.StrategyPattern.Example2.Interfaces;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example2.Services
{
    public class Quacking : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
