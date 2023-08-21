using SimpleDesignPatternImplementations.StrategyPattern.Example2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatternImplementations.StrategyPattern.Example2.Services
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("There's no way that I can fly!"); 
        }
    }
}
