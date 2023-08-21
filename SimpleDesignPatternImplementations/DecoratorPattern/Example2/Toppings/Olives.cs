namespace SimpleDesignPatternImplementations.DecoratorPattern.Example2.Toppings
{
    public class Olives : ToppingDecorator
    {
        public Pizza Pizza { get; set; }
        public Olives(Pizza pizza)
        {
            Pizza = pizza;
        }

        public override string GetDescription()
        {
            return $"{Pizza.GetDescription}, Olives";
        }

        public override double Cost()
        {
            return Pizza.Cost() + .8;
        }
    }
}
