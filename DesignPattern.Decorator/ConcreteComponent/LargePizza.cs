using DesignPattern.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.ConcreteComponent
{
    public   class LargePizza : Pizza
    {
        public override string GetDescription()
        {
            return "Large pizza";
        }

        public override double GetCost()
        {
            return 7.00;
        }
    }
}
