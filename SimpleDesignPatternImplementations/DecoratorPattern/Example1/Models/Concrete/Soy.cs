namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models.Concrete
{
    public class Soy : CondimentDecorator
    {
        public Beverage Beverage { get; set; }
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return $"{Beverage.GetDescription()}, Soy";
        }

        public override double Cost()
        {
            return Beverage.Cost() + .11;
        }
    }
}
