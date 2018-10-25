using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCodeSamples
{
    public class Customer
    {
        
        private string _name;

        public Customer(string name)
        {
            this._name = name;
        }

        public string Name { get; set; }
    }
}
