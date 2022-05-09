using System.Collections.Generic;
using System;
//using System.Linq;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> data;
        public int Count { 
            get
                {
                    return data.Count;
                }
            }

        public Box()
        {
            data = new List<T>();
        }

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove()
        {
            //T result = data.LastOrDefault();
            if (Count == 0)
            {
                throw new InvalidOperationException("Can not remove from empty collection");
            }
            T result = data[Count - 1];
            data.Remove(result);
            return result;
        }
    }
}
