using DesignPattern.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Decorator
{
    public class ToppingBehavior :Pizza
    {
        Pizza _pizza;
        

        public ToppingBehavior(Pizza pizza)
        {
             _pizza = pizza;
        }
        public override string GetDescription()
        {
            return _pizza.GetDescription();
        }

        public override double GetCost()
        {
            return _pizza.GetCost();
        }
    }
}
