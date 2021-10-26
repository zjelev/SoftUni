using System;
using LoggerApp.Appenders;
using LoggerApp.Common;

namespace LoggerApp.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Critical(DateTime dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Critical, message);
        }

        public void Error(DateTime dateTime, string message)
        {

            this.AppendError(dateTime, ReportLevel.Error, message);            

        }

        public void Fatal(DateTime dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Fatal, message);
        }

        public void Info(DateTime dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Info, message);
        }

        public void Warning(DateTime dateTime, string message)
        {
            this.AppendError(dateTime, ReportLevel.Warning, message);
        }

        private void AppendError(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            foreach (var item in this.appenders)
            {
                item.Append(dateTime, reportLevel, message);               
            }
        }
    }
}
