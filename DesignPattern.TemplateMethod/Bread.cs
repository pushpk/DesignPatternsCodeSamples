
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
   public abstract class Bread
    {
        public abstract string MixIngredients();

        public abstract string Bake();

        public virtual string Slice()
        {
            return "Slicing the " + GetType().Name + " bread!";

        }
        public string Make()
        {
            string rv = MixIngredients();
            rv += Bake();
            rv += Slice();

            return rv;
        }

    }
}
