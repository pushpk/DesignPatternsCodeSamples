using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Context
{
    public class LightingKick : IKickBehavior
    {
        public string kick()
        {
            return "Lighting  Kick";
        }
    }
}
