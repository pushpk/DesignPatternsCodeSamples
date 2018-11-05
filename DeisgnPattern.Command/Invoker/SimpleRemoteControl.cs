using DeisgnPattern.Command.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeisgnPattern.Command.Invoker
{
    public class SimpleRemoteControl
    {
        ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public string ButtonWasPressed()
        {
           return this.command.Execute();

        }
    }
}
