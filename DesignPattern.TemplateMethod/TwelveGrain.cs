using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
    public class TwelveGrain : Bread
    {
        public override string MixIngredients()
        {
            return "Gathering Ingredients for 12 grain bread";
        }

        public override string Bake()
        {
            return "Baking ther 12-Grain Bread";
        }



    }
}
