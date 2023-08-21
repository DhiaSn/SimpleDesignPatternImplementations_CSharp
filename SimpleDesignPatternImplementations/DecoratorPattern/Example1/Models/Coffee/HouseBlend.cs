namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Coffee
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return .99;
        }
    }
}
