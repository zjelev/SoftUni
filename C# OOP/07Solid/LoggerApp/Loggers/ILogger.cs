using System;

namespace LoggerApp.Loggers
{
    public interface ILogger
    {
        void Info(DateTime dateTime, string message);
        void Warning(DateTime dateTime, string message);
        void Error(DateTime dateTime, string message);
        void Critical(DateTime dateTime, string message);
        void Fatal(DateTime dateTime, string message);

    }
}
