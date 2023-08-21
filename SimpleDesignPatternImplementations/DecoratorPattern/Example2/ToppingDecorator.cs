using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDesignPatternImplementations.DecoratorPattern.Example2
{
    public abstract class ToppingDecorator : Pizza
    {
        public abstract string GetDescription();
    }
}
