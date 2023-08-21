using SimpleDesignPatternImplementations.AdapterPattern.Example1.Interfaces;

namespace SimpleDesignPatternImplementations.AdapterPattern.Example1.Models
{
    public class TurkeyAdapter : IDuck
    {
        private ITurkey Turkey { get; set; }
        public TurkeyAdapter(ITurkey turkey)
        {
            Turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                Turkey.Fly();
            }
        }

        public void Quack()
        {
            Turkey.Gobble();
        }
    }
}
