using System;
using LoggerApp.Common;
using LoggerApp.Layouts;

namespace LoggerApp.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevel.Info;
        }

        public ILayout Layout { get; set; }
        public ReportLevel ReportLevel { get; set; }

        public virtual void Append(DateTime dateTime, ReportLevel reportLevel, string message)
        {
            if (reportLevel >= this.ReportLevel)
            {
                string res = string.Format(this.Layout.Template, dateTime, reportLevel, message);
            }
        }
    }
}
