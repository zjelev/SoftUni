using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Peter");
            Console.WriteLine(person.Name);

            person.Name = "";

            Console.WriteLine(person.Name);
        }
    }
}
