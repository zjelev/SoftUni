using System;
using System.Collections.Generic;
// "?" adds null value to the type
namespace _08Generics
{
    public class Box<T> where T : IComparable<T>
    {
        private T value;
        
        public Box(T value)
        {
            this.value = value;
        }

        public T Value 
        { 
            get => this.value;
            private set => this.value = value; 
        }

        public int MyCompareTo(T other)
        {
            return this.Value.CompareTo(other);
        }

        public override string ToString()
        {
            Type type = this.GetType(); // both are
            Type typeOfT = typeof(T);   // equal
            return $"{typeOfT.FullName}: {this.Value}"; //metadata, reflection
        }
    }
}
