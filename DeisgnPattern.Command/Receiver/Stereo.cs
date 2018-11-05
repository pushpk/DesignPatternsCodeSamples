using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnPattern.Command.Receiver
{
    public class Stereo
    {
        public string On()
        {
            return "Stereo is on";
        }

        public string Off()
        {
            return "Stereo is Off";
        }

        public string setCD()
        {
            return "All set to set CD";
        }

        public string setDVD()
        {
            return " All set to set DVD";
        }

        public string setVolume(string vol)
        {
            return " Stereo Volume Changed to" + vol;
        }
    }
}
