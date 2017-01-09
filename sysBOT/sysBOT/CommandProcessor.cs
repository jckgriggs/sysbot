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
            AddCommand("info", "sysBOT 0.2.0 | https://www.jackgriggs.net/sysbot");
        }

        public int index(string command)
        {
            for (int i = 0; i < this.Command.Count; i++)
            {
                if (command == this.Command[i].command)
                {
                    return i;
                }
            }
            return -1;
        }

        public string Process(string command)
        {
            if (CommandExists(command))
                return this.Command[index(command)].response;
            else
                return $"Command '{command}' does not exist";
        }

        public void EnableCommand(string command)
        {
            if (CommandExists(command))
                this.Command[index(command)].enabled = true;
            else
                Console.WriteLine($"Command '{command}' does not exist");
        }

        public void DisableCommand(string command)
        {
            if(CommandExists(command))
                this.Command[index(command)].enabled = false;
            else
                Console.WriteLine($"Command '{command}' does not exist");
        }

        public bool CommandExists(string command)
        {
            for (int i = 0; i < this.Command.Count; i++)
            {
                if (command == this.Command[i].command)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddCommand(string command, string response)
        {
            this.Command.Add(new Command { command = command, response = response, enabled = true });
        }

        public void DeleteCommand(string command)
        {
            this.Command.RemoveAt(index(command));
        }
    }
}
