using System.IO;
using System.Linq;
using System.Text;

namespace LoggerApp
{
    public class LogFile : ILogFile
    {
        private const string FilePath = "log.txt";
        private readonly StringBuilder reports;

        public string AllText { get; }

        // TODO check this property value
        
        public int Size 
        {
            get
            {return this.AllText
                .Where(c => char.IsLetter(c)) 
                .Sum(c => c);
            }
        }
        

        public void Write(string error)
        {
            File.AppendAllText(FilePath, error);
            //this.reports.Append(error);
        }
    }
}
