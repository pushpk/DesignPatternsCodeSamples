using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Context
{
    public class LongJump : IJumpBehavior
    {
        public string jump()
        {
            return "Long Jump";
        }

    
    }
}
