using System;


namespace _10.String_Repeater
{
    class Program
    {
        static void RepeatString(string str, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(str);
            }
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            RepeatString(str, n);
        }
    }
}
