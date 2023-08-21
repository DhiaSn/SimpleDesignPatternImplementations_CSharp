namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Coffee
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso Coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
