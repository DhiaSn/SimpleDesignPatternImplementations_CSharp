namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models
{
    public abstract class Beverage
    {
        protected string Description { get; set; } = "Unknown Beverage";

        public string GetDescription()
        {
            return Description;
        }

        public abstract double Cost();
    }
}
