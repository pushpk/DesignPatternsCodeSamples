using DesignPattern.Strategy.Context;
using DesignPattern.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Concrete
{
    public class ChunLi : Fighter
    {
        public ChunLi(IKickBehavior _kickBehavior, IJumpBehavior _jumpBehavior) : base(_kickBehavior, _jumpBehavior)
        {
        }
    }
}
