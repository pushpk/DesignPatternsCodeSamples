using DeisgnPattern.Command.Command;
using DeisgnPattern.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnPattern.Command.ConcreteCommands
{
    public class StereoOnWithDVDCommand : ICommand
    {
        Stereo stereo;
        public StereoOnWithDVDCommand(Stereo _stereo)
        {
            stereo = _stereo;

        }
        public string Execute()
        {
            string a = string.Empty;
            a = stereo.On();
            a += stereo.setDVD();

            return a;
        }
    }
}
