using System;
using System.Collections.Generic;

namespace GenericArrayCreator
{
    public class TestClass<T>
    {
        private T[] arr = new T[100];
        public void Add<V>(V item) where V : T
        {
            arr[0] = item;
        }
    }
}