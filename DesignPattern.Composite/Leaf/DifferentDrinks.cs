using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite.Leaf
{
    /// <summary>
    /// Leaf class
    /// </summary>
    public class VanillaCola : SoftDrink
    {
        public VanillaCola(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class StrawberryRootBeer : SoftDrink
    {
        public StrawberryRootBeer(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class VanillaRootBeer : SoftDrink
    {
        public VanillaRootBeer(int calories) : base(calories) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories) : base(calories) { }
    }
}
