using DeisgnPattern.Command.Command;
using DeisgnPattern.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnPattern.Command.ConcreteCommands
{
public  class StereoOffCommand : ICommand
    {
        Stereo stereo;

        public StereoOffCommand(Stereo  _stereo)
        {
            stereo = _stereo;

        }

        public string Execute()
        {
           return stereo.Off();
        }
    }
}
