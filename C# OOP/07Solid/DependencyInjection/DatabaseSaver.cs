using System;
using System.IO;

namespace DependencyInjection
{
    public class DatabaseSaver : ISaver
    {
        public void Save(Document document)
        {
            Console.WriteLine("Saving document to db...");
        }
    }
}
