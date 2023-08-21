using SimpleDesignPatternImplementations.AdapterPattern.Example1.Interfaces;

namespace SimpleDesignPatternImplementations.AdapterPattern.Example1.Models
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble! Gobble!");
        }
    }
}
