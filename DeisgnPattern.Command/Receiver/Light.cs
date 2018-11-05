using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnPattern.Command.Receiver
{
    public class Light
    {
        public string On()
        {
            return "Light is on";
        }

        public string Off()
        {
            return "Light is Off";
        }
    }
}
