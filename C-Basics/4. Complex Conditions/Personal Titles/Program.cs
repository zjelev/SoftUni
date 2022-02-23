using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            char m = 'm', f = 'f'; 
            decimal age = decimal.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            if (age < 16)
            {
                if (gender.Equals(m))
                {
                    Console.WriteLine("Master");
                }
                else if (gender.Equals(f))
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (gender.Equals(m))
                {
                    Console.WriteLine("Mr.");
                }
                else if (gender.Equals(f))
                {
                    Console.WriteLine("Ms.");
                }
            }
         }
    }
}