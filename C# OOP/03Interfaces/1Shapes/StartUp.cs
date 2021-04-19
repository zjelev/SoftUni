using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Document doc = new Document("MyDoc", "This is my awesome content!");
            // IPrintable pDoc = doc;
            // doc.Title = "My New Title";
            // pDoc.Print();
            // (doc as IPrintable).Print();

            int radius = int.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);

            circle.Draw();
            rectangle.Draw();
        }
    }
}
