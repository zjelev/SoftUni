using System;

namespace CustomDataStructures
{
    public class CustomList
    {
        private const int InitCapacity = 2;
        private int[] items;
        public CustomList()
        {
            this.items = new int[InitCapacity];
        }

        public int Count { get; private set; }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count++] = item;
        }

        public int RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            int value = this.items[index];
            
            if ((this.Count <= this.items.Length / 4))
            {
                this.Shrink();
            }

            this.Shift(index);
            this.items[--this.Count] = 0;
            // this.Count--;
            return value;
        }

        public void Insert(int index, int item)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException();
            }
            
            if (this.Count == this.items.Length)
            {
                Resize();
            }

            this.ShiftRight(index);
            this.items[index] = item;
            Count++;
        }
        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i+1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = this.Count - 1; i >= index; i--)
            {
                items[i+1] = items[i] ;
            }
        }
        private void Shrink()
        {
            int newLength = this.items.Length / 2;
            int[] temp = new int[newLength];
            Array.Copy(this.items, temp, this.Count);
            this.items = temp;
        }

        private void Resize()
        {
            int newLength = this.items.Length * 2;
            int[] temp = new int[newLength];

            // for (int i = 0; i < this.items.Length; i++)
            // {
            //     temp[i] = this.items[i];
            // }
            Array.Copy(this.items, temp, this.items.Length);

            this.items = temp;
        }

        public bool Contains(int item)
        {
            bool contains = false;
            
            for (int i = 0; i < this.Count - 1; i++)
            {
                if (this.items[i] == item)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        public void Swap(int firstsIndex, int secondIndex)
        {
            if (firstsIndex >= Count || secondIndex >= Count)
            {
                throw new IndexOutOfRangeException();
            }
            
            int temp = items[firstsIndex];
            this.items[firstsIndex] = this.items[secondIndex];
            this.items[secondIndex] = temp;
        }

        public int this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.items[index];
            }
            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.items[index] = value;
            }
        }
    }
}