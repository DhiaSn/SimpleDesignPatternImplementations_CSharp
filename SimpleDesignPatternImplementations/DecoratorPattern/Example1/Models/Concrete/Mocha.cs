namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Concrete
{
    public class Mocha : CondimentDecorator
    {
        public Beverage Beverage { get; set; }
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Mocha";
        }

        public override double Cost()
        {
            return Beverage.Cost() + .11;
        }
    }
}
