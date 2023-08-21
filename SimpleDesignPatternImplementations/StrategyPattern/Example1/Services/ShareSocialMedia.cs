using SimpleDesignPatternImplementations.StrategyPattern.Example1.Interfaces;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example1.Services
{
    public class ShareSocialMedia : IShareBehavior
    {
        public void Share()
        {
            Console.WriteLine("Share to social Media...");
        }
    }
}
