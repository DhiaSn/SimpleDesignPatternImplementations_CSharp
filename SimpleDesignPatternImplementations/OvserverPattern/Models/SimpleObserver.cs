using SimpleDesignPatternImplementations.OvserverPattern.Interfaces;

namespace SimpleDesignPatternImplementations.OvserverPattern.Models
{
    public class SimpleObserver : IObserver
    {
        private int Value { get; set; }
        private ISubject SimpleSubject { get; set; }
        public SimpleObserver(ISubject simpleSubject)
        {
            SimpleSubject = simpleSubject;
            simpleSubject.RegisterObserver(this);
        }
        public void Update(int value)
        {
            Value = value;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Value: {Value}");
        }

    }
}
