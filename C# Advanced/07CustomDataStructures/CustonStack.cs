using System;

namespace CustomDataStructures
{
    public class CustomStack
    {
        private const int InitCapacity = 2;
        private int[] items;
        private int count;
        public CustomStack()
        {
            this.count = 0;
            this.items = new int[InitCapacity];
        }

        public int Count => this.count;

        public void Push(int item)
        {
            if (count == items.Length)
            {
                Resize();
            }

            items[count++] = item;
        }

        private void Resize()
        {
            int[] temp = new int[this.items.Length * 2];
            Array.Copy(items, temp, items.Length);
            items = temp;
        }

        public int Pop()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }

            if(count <= items.Length / 4)
            {
                Shrink();
            }
            int item = this.items[--count];
            items[count] = default;
            return item;
        }

        private void Shrink()
        {
            int[] temp = new int[items.Length / 2];
            Array.Copy(items, temp, count);
            items = temp;
        }

        public int Peek()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }

            int item = this.items[count--];
            return item;
        }
    }
}