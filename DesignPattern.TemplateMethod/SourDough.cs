using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.TemplateMethod
{
    public class SourDough  : Bread
    {
        public override string MixIngredients()
        {
            return " Gathering Ingredients for sour dough ";
        }

        public override string Bake()
        {
            return " Baking the sour dough ";
        }
    }
}
