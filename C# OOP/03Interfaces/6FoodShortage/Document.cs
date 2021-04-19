using System;

namespace FoodShortage
{
    public abstract class Document : IPrintable
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Number { get; private set; }

        public Document(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }

        public abstract void Print();

        // void IPrintable.Print()
        // {
        //     Console.WriteLine(this.Title);
        //     Console.WriteLine(this.Content);
        // }
    }
}
