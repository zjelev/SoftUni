using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] tokens = args.Split();
            
            string commandName = tokens[0];

            string commandTypeName = commandName + "Command";

            Type commandType = Assembly.GetCallingAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces()
                                        .Any(i => i.Name == nameof(ICommand))
                    ).ToArray()
                .FirstOrDefault(t => t.Name == commandTypeName)
                ;

            if (commandType == null)
            {
                throw new InvalidOperationException("Command type is invelid!");
            }

            ICommand command = Activator.CreateInstance(commandType) as ICommand;         

            string[] clearData = tokens.Skip(1).ToArray();
            string res = command.Execute(clearData);

            return res;
        }

        // Without Reflection

        // public string Read(string args)
        // {
        //     string[] tokens = args.Split();
        //     string commandName = tokens[0];

        //     ICommand command = null;

        //     if (commandName == "Hello")
        //     {
        //         command = new HelloCommand();
        //     }
        //     else if (commandName == "Exit")
        //     {
        //         command = new ExitCommand();
        //     }
        //     else if (commandName == "Bye")
        //     {
        //         command = new ByeCommand();
        //     }

        //     string[] clearData = tokens.Skip(1).ToArray();

        //     string res = command.Execute(clearData);
        //     return res;
        // }
    }
}