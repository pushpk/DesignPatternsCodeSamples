using DesignPattern.Strategy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Strategy
{
    public class Fighter
    {
        private  IKickBehavior kickBehavior;
        private  IJumpBehavior jumpBehavior;

        public Fighter(IKickBehavior _kickBehavior, IJumpBehavior _jumpBehavior)
        {
            this.kickBehavior = _kickBehavior;
            this.jumpBehavior = _jumpBehavior;
        }
        public string punch()
        {
            return "Default punch";

        }
        public string roll()
        {
            return "Default Roll";

        }

        public string jump()
        {
            return jumpBehavior.jump();

        }

        public string kick()
        {
            return kickBehavior.kick();
        }

        public void setjump(IJumpBehavior jumpBehavior)
        {
            this.jumpBehavior = jumpBehavior;
        }
        public void setkick(IKickBehavior kickBehavior)
        {
            this.kickBehavior = kickBehavior;
        }
    }
}
