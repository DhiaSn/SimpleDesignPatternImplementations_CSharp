﻿namespace SimpleDesignPatternImplementations.OvserverPattern.Interfaces
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObserver();
    }
}
