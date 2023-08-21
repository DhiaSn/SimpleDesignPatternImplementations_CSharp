namespace SimpleDesignPatternImplementations.DecoratorPattern.Example2.Toppings
{
    public class Cheese : ToppingDecorator
    {
        public Pizza Pizza { get; set; }
        public Cheese(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription}, Cheese";
        }

        public override double Cost()
        {
            return Pizza.Cost() + 3;
        }
    }
}
