namespace SimpleDesignPatternImplementations.DecoratorPattern.Example2.Toppings
{
    public class Peppers : ToppingDecorator
    {
        public Pizza Pizza { get; set; }
        public Peppers(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription}, Peppers";
        }

        public override double Cost()
        {
            return Pizza.Cost() + 2.2;
        }
    }
}
