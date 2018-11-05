using DesignPattern.Decorator.Component;
using DesignPattern.Decorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.ConcreteDecorator
{
public    class HamTopping : ToppingBehavior
    {

        private Pizza _pizza;

        public HamTopping(Pizza pizza) : base(pizza)
        {
            _pizza = pizza;

        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + " with Ham";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.00;
        }

    }
}
