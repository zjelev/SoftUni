using LoggerApp.Layouts;
using LoggerApp.Appenders;
using LoggerApp.Loggers;
using System;
using LoggerApp.Core;
using LoggerApp.Common;

namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var layout = new XmlLayout();
            var consoleAppender = new ConsoleAppender(layout);

            var file = new LogFile();
            var fileAppender = new FileAppender(layout, file);

            var logger = new Logger(consoleAppender, fileAppender);

            ICommandInterpreter command = new LoggerInterpreter();
            command.Execute(logger, "Error", DateTime.Now, "Everything seems not nice");

            // logger.Error(DateTime.Now, "Error parsing JSON.");
            // logger.Info(DateTime.Now, "User Pesho successfully registered.");
            // logger.Warning(new DateTime(2015, 3, 31, 5, 33, 7), "Warning: ping is too high - disconnect imminent");
            // logger.Critical(new DateTime(2015, 3, 31, 5, 33, 8), "No connection string found in App.config");
            // logger.Fatal(new DateTime(2015, 3, 31, 5, 33, 9), "mscorlib.dll does not respond");
        }
    }
}
