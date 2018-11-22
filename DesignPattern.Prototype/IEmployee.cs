using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public interface IEmployee 
    {
        IEmployee Clone();
        string GetDetails();
    }
}
