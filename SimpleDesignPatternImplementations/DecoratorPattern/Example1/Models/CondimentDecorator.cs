namespace SimpleDesignPatternImplementations.DecoratorPattern.Example1.Models
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();
    }
}
