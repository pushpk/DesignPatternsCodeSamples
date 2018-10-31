using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class Adapter : ITarget
    {
        public List<string> request()
        {
            Adaptee adaptee = new Adaptee();
            return adaptee.GetEmployeeList();
        }
    }
}
