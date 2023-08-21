namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Concrete
{
    public class Whip : CondimentDecorator
    {
        public Beverage Beverage { get; set; }
        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }
        public override double Cost()
        {
            return Beverage.Cost() + .10;
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Whip";
        }
    }
}
