using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Context
{
    public class HighJump : IJumpBehavior
    {
        public string jump()
        {
            return "High Jump";
        }

    }
}
