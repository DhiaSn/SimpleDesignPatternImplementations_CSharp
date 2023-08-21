namespace SimpleDesignPatternImplementations.DecoratorPattern.Example2.PizzaType
{
    public class ThickCrustPizza : Pizza
    {
        public ThickCrustPizza()
        {
            Description = "Thick Crust Pizza";
        }

        public override double Cost()
        {
            return 17;
        }
    }
}
