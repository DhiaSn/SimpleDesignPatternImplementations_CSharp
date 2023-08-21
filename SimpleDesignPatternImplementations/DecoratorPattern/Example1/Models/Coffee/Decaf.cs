namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Coffee
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf Coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
