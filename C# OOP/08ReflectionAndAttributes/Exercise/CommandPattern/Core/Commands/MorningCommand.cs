using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Commands
{
    class MorningCommand : ICommand
    {
        public string Execute(string[] args)
        {
            return $"Morning, {args[0]}";
        }
    }

}