using DeisgnPattern.Command.Command;
using DeisgnPattern.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeisgnPattern.Command.ConcreteCommands
{
    public class LightOnCommand : ICommand
    {
        private Light light;

        public LightOnCommand(Light _light)
        {
            light = _light;  
        }

        public string Execute()
        {
           return light.On();
        }
    }
}
