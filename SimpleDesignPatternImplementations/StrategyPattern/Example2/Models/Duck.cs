using SimpleDesignPatternImplementations.StrategyPattern.Example2.Interfaces;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example2.Models
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }
        public abstract void Display(); 

        public void Fly()
        {
            FlyBehavior.Fly(); 
        }
        public void Quack()
        {
            QuackBehavior.Quack(); 
        }

        public void Swim()
        {
            Console.WriteLine("I swim!");
        }
    }
}
