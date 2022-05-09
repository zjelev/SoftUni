using System;

namespace LinkedList
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList(new int[] { 3, 5, 7, 12 });
            var node = myList.Find(5);
            myList.AddAfter(node, 8);
            myList.AddBefore(myList.First, 5);
            node = myList.Find(7);
            myList.AddBefore(node, 9);

            myList.RemoveAll(5);

            // myList.Remove(9);
            // myList.RemoveFirst();
            // myList.RemoveLast();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine(myList.Contains(7));
            Console.WriteLine(myList.Contains(134));
            Console.WriteLine(myList.Count);

        }
    }
}
