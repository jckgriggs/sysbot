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
            AddCommand("info", "sysBOT 0.1.6 | https://www.jackgriggs.net/sysbot");
        }

        //This method locates the index of a specific command in the command list
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

        //This function returns a response to a specified command
        public string Process(string command)
        {
            if (CommandExists(command))
                return this.Command[index(command)].response;
            else
                return $"Command '{command}' does not exist";
        }

        //This function enables a specified command
        public void EnableCommand(string command)
        {
            if (CommandExists(command))
                this.Command[index(command)].enabled = true;
            else
                Console.WriteLine($"Command '{command}' does not exist");
        }

        //This function disables a specified command
        public void DisableCommand(string command)
        {
            if(CommandExists(command))
                this.Command[index(command)].enabled = false;
            else
                Console.WriteLine($"Command '{command}' does not exist");
        }

        //This function searches for a specified command in the command list
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

        //This function adds commands and responses to the command list
        public void AddCommand(string command, string response)
        {
            this.Command.Add(new Command { command = command, response = response, enabled = true });
        }

        //This function deletes commands and responses from the command list
        public void DeleteCommand(string command)
        {
            this.Command.RemoveAt(index(command));
        }
    }
}
