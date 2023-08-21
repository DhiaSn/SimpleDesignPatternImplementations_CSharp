namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Concrete
{
    public class Milk : CondimentDecorator
    {
        public Beverage Beverage { get; set; }
        public Milk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Milk";
        }

        public override double Cost()
        {
            return Beverage.Cost() + .11;
        }
    }
}
