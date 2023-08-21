using SimpleDesignPatternImplementations.AdapterPattern.Example1.Interfaces;

namespace SimpleDesignPatternImplementations.AdapterPattern.Example1.Models
{
    public class MillardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack!");
        }
    }
}
