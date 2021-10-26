using System;
using LoggerApp.Loggers;

namespace LoggerApp.Core
{
    public interface ICommandInterpreter
    {
        void Execute(ILogger logger, string reportLevel, DateTime date, string message);
    }
}
