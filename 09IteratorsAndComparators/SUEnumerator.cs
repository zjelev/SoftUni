using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class SUEnumerator : IEnumerator<string>
    {
        private readonly List<string> list;
        private int currIndex = -1;
        public SUEnumerator(List<string> list)
        {
            this.list = list;
        }
        
        public string Current => GetCurrent();

        private string GetCurrent()
        {
            return this.list[currIndex];
        }

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            currIndex++;
            return currIndex < list.Count;
        }

        public void Reset()
        {
            currIndex = -1;
        }
    }
}
