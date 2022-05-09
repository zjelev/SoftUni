using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Book //: IComparable<Book>, IComparable<int?>
    {
        
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }
        public string Title { get; private set; }
        public int Year { get; private set; }
        public List<string> Authors { get; private set; }

        // public int CompareTo(Book other)
        // {
        //     if (other.Year < this.Year)
        //     {
        //         return 1;
        //     }
        //     else if (other.Year > this.Year)
        //     {
        //         return -1;
        //     }
        //     else
        //     {
        //         return 0;
        //     }
        // }

        // public int CompareTo(int? other)
        // {
        //     return this.Year.CompareTo(other);
        // }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}