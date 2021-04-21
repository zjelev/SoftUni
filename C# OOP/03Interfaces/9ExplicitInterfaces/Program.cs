using System;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] token = input.Split();
                IPerson person = new Citizen(token[0], token[1], int.Parse(token[2]));
                Console.WriteLine(person.GetName());
                IResident resident = person as IResident;
                Console.WriteLine(resident.GetName());
            }
        }
    }
}
