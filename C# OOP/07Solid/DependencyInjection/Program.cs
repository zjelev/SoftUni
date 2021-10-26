using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentsController controller = new DocumentsController(new DatabaseSaver(), new ConsoleReader());
            string text = "";
            while (text.ToLower() != "end")
            {
                text = Console.ReadLine();
                controller.AddDocument(text);
            }

        }

        static void TestDocumentsController()
        {
            var controller = new DocumentsController(new TestingSaver(), new ConsoleReader());
        }

        class TestingSaver : ISaver
        {
            public void Save(Document document)
            {
                Console.WriteLine("Testing saver");
            }
        }
    }
}
