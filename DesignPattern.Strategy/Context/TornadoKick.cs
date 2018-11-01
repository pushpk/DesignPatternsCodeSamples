using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy.Context
{
    public class TornadoKick : IKickBehavior
    {
        public string kick()
        {
            return "Tornado Kick";
        }
    }
}
