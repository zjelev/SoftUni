using System;
using System.Collections.Generic;
using System.Text;

namespace _08Generics
{
    public class BoxStore<T> where T : IComparable<T>
    {
        private List<Box<T>> boxes;

        public BoxStore()
        {
            this.boxes = new List<Box<T>>();
        }

        public void AddBox(Box<T> box)
        {
            boxes.Add(box);
        }

        public void SwapBoxes(int firstIndex, int secondIndex) 
        {
            var temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Box<T> box in this.boxes)
            {
                sb.AppendLine(box.ToString());
            } 
            
            return sb.ToString().Trim();
        }

        public int CountGreater(T element)
        {
            int count = 0;

            foreach (var box in boxes)
            {
                if (box.MyCompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}