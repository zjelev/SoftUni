using System;
using System.Collections.Generic;

namespace _08Generics
{
    class Program5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var boxes = new BoxStore<double>();

            while (n-- > 0)
            {
                var box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.AddBox(box);
            }

            var element = double.Parse(Console.ReadLine());

            Console.WriteLine(boxes.CountGreater(element));

            Console.WriteLine((int)'A');
        }
    }
}