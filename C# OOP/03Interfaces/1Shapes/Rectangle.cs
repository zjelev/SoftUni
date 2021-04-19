using System;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            DrawLine('*', '*');
            for (int i = 1; i < this.height ; ++i)
            {
                DrawLine('*', ' ');
            }
            DrawLine('*', '*');
        }

        private void DrawLine(char end, char mid)
        {
            Console.Write(end);
            Console.Write(new String(mid, width - 2));
            Console.WriteLine(end);
        }
    }
}
