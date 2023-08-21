namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Coffee
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
