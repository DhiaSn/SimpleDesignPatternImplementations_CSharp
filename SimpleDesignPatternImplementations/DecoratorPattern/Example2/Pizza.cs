namespace SimpleDesignPatternImplementations.DecoratorPattern.Example2
{
    public abstract class Pizza
    {
        protected string Description { get; set; }
        public string GetDescription()
        {
            return Description;
        }
        public abstract double Cost();
    }
}
