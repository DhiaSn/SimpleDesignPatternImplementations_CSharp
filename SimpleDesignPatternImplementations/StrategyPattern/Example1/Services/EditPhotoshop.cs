using SimpleDesignPatternImplementations.StrategyPattern.Example1.Interfaces;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example1.Services
{
    public class EditPhotoshop : IEditBehaviour
    {
        public void Edit()
        {
            Console.WriteLine("Editing with photoshop...");
        }
    }
}
