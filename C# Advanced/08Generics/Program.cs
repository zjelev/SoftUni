using System;
using System.Collections.Generic;
using System.Linq;

namespace _08Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            // var boxes = new List<Box<string>>();
            var boxes = new BoxStore<int>();

            while (n-- > 0)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.AddBox(box);
            }


            int[] swapIndexes = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToArray();

            //SwapListItems(boxes, swapIndexes[0], swapIndexes[1]);

            // foreach (var box in boxes)
            // {
            //     Console.WriteLine(box);
            // }

            boxes.SwapBoxes(swapIndexes[0], swapIndexes[1]);
            Console.WriteLine(boxes);
        }

        public static void SwapListItems(List<Box<string>> list, int firstIndex, int secondIndex) 
        {
            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}
