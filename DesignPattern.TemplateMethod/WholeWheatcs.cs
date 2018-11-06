using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
    public class WholeWheatcs : Bread
    {
        public override string MixIngredients()
        {
            return "Gathering Ingredients for WHeat Bread";
        }

        public override string Bake()
        {
            return "Baking the Wheat Bread";
        }
    }
}
