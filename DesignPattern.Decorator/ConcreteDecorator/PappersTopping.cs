using DesignPattern.Decorator.Component;
using DesignPattern.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.ConcreteDecorator
{
    public class PappersTopping : ToppingBehavior
    {
        private Pizza _pizza;

        public PappersTopping(Pizza pizza) : base(pizza)
        {
            _pizza = pizza;

        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + " with pappers";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 0.50;
        }

    }
}
