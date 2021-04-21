namespace CollectionHierarchy
{
    using System;
    using CollectionHierarchy.Models;
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int removes = int.Parse(Console.ReadLine());

            MyList myList = new MyList();
            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();

            foreach (var item in input)
            {
                Console.Write(addCollection.Add(item) + " ");
            }
            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write(addRemoveCollection.Add(item) + " ");
            }
            Console.WriteLine();

            foreach (var item in input)
            {
                Console.Write(myList.Add(item) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < removes; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < removes; i++)
            {
                Console.Write(myList.Remove() + " ");
            }
        }
    }
}
