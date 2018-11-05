using DesignPattern.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.ConcreteComponent
{
    public class SmallPizza : Pizza
    {
        public override string GetDescription()
        {
            return "Small pizza";
        }

        public override double GetCost()
        {
            return 3.00;
        }
    }
}
