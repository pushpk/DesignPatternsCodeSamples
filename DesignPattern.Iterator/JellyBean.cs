using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Iterator
{
    //Collection Item : we'll create iterator to iterate over JellyBeans Collection
    public class JellyBean
    {
        public JellyBean(string flavor)
        {
            Flavor = flavor;
        }

        public string Flavor { get; }
    }
}
