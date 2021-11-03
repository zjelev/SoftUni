using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Commands
{
    public class ByeCommand : ICommand
    {
        public string Execute(string[] args)
        {
            string res = $"Bye, {args[0]} {args[1]}";
            return res;
        }
    }
}