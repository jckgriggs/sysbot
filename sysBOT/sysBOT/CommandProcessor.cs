using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysBOT
{
    class CommandProcessor
    {
        private List<Command> Command = new List<Command>();

        public CommandProcessor()
        {
            this.Command.Add(new Command {command = "help",response = "no"});
        }

        public string Process(string command)
        {
            for (int i = 0; i < this.Command.Count; i++)
            {
                if(command == this.Command[i].command)
                {
                    switch (command)
                    {
                        case "help":
                            return this.Command[i].response;
                        default:
                            return "Error: Command not found";
                    }
                }
            }
            return "Error: Command list empty";
        }
    }
}
