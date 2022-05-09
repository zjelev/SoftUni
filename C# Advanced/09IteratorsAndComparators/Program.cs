using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            // Library books = new Library(bookOne, bookTwo, bookThree);
            var list = MergeList(bookOne, bookTwo, bookThree);
            list.Sort(new BookComparator());
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // foreach (var book in libraryOne)
            // {
            //     Console.WriteLine(book.Title);
            // }

            // Console.WriteLine(bookOne.CompareTo(bookTwo));       


        }

        static List<T> MergeList<T>(params T[] books)
        {
            return books.ToList();
        }
    }
}