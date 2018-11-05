using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnPattern.Command.Command
{
    public interface ICommand
    {
        ConcreteCommands.LightOffCommand LightOffCommand { get; set; }
        ConcreteCommands.LightOnCommand LightOnCommand { get; set; }
        ConcreteCommands.StereoOffCommand StereoOffCommand { get; set; }
        ConcreteCommands.StereoOnWithDVDCommand StereoOnWithDVDCommand { get; set; }

        string Execute();
    }
}
