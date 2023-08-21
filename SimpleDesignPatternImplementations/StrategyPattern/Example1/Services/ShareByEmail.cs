using SimpleDesignPatternImplementations.StrategyPattern.Example1.Interfaces;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example1.Services
{
    public class ShareByEmail : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("Share by email...");
        }
    }
}
