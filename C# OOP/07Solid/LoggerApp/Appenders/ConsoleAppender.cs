using System;
using LoggerApp.Common;
using LoggerApp.Layouts;

namespace LoggerApp.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
            this.ReportLevel = ReportLevel.Error;
        }

        public override void Append(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string res = string.Format(this.Layout.Template, dateTime, reportLevel, message) + Environment.NewLine;
                Console.WriteLine(res);
            }
        }
    }
}
