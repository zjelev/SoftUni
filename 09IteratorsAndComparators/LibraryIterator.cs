using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private readonly List<Book> books;
        private int currIndex = -1;

        public LibraryIterator(List<Book> books)
        {
            this.books = books;
        }

        public Book Current => this.books[currIndex];

        object IEnumerator.Current => this.Current;

        public void Dispose()
        { }

        public bool MoveNext()
        {
            currIndex++;
            return currIndex < books.Count;
        }

        public void Reset()
        {
            currIndex = -1;
        }
    }
}