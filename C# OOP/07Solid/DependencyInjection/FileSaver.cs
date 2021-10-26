using System;
using System.IO;

namespace DependencyInjection
{
    public class FileSaver : ISaver
    {
        public void Save(Document document)
        {
            using (StreamWriter writer = new StreamWriter("database.txt", true))
            {
                writer.WriteLine(document.Text);
            }
        }
    }
}
