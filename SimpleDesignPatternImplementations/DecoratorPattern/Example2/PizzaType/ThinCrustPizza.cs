namespace SimpleDesignPatternImplementations.DecoratorPattern.Example2.PizzaType
{
    public class ThinCrustPizza : Pizza
    {
        public ThinCrustPizza()
        {
            Description = "Thin Crust Pizza";
        }
        public override double Cost()
        {
            return 15;
        }
    }
}
