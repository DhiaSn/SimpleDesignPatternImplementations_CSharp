using SimpleDesignPatternImplementations.OvserverPattern.Interfaces;

namespace SimpleDesignPatternImplementations.OvserverPattern.Models
{
    public class SimpleSubject : ISubject
    {
        private List<IObserver> Observers { get; set; }
        private int Value { get; set; }
        public SimpleSubject()
        {
            Observers = new();

        }
        public void NotifyObserver()
        {
            foreach (var observer in Observers)
            {
                observer.Update(Value);
            }
        }
        public void SetValue(int value)
        {
            Value = value;
            NotifyObserver();
        }

        public void RegisterObserver(IObserver o)
        {
            // add observer to the list
        }

        public void RemoveObserver(IObserver o)
        {
            // remove observer to the list
        }
    }
}
