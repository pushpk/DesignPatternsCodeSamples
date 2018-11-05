using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator.Component
{
    abstract public class Pizza
    {
        public  virtual string GetDescription()
        {
            return "abstract pizza";
        }

        public virtual  double GetCost()
        {
            return 3.00;

        }

    }
}
