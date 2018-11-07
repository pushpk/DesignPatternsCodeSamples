using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    public class SoftDrink
    {
        public int Calories { get; set; }

        public List<SoftDrink> Flavors { get; set; }

        public SoftDrink()
        {

        }

        public SoftDrink(int calories)
        {
            Calories = calories;
            Flavors = new List<SoftDrink>();
        }

        public string DisplayCalories()
        {
            string a =  this.GetType().Name + ": " + this.Calories.ToString() + " calories";

            foreach(var drink in this.Flavors)
            {
                a += drink.DisplayCalories();

            }

            return a;
        }
    }
}
