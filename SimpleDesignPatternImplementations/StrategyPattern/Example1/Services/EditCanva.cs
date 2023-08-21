using SimpleDesignPatternImplementations.StrategyPattern.Example1.Interfaces;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example1.Services
{
    public class EditCanva : IEditBehaviour
    {
        public void Edit()
        {
            Console.WriteLine("Editing with canva...");
        }
    }
}
