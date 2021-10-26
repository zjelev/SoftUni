using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    public class DocumentsController
    {
        private ISaver Saver;
        private IReader Reader;

        //Constructor injection
        public DocumentsController(ISaver saver, IReader reader)
        {
            this.Saver = saver;
            this.Reader = reader;
        }

        public void AddDocument(string text)
        {
            Document doc = new Document()
            {
                Text = text
            };
            Saver.Save(doc);
        }

        public List<Document> ReadDocuments()
        {
            return Reader.Read();
        }
    }
}
