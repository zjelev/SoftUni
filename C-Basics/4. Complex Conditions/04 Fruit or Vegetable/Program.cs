using System;

namespace _04_Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = "banana", a = "apple", k = "kiwi", c = "cherry", l = "lemon", g = "grapes", t = "tomato", u = "cucumber", p = "pepper", r = "carrot";
            string s = Console.ReadLine().ToLower();
            if (s.Equals(b) || s.Equals(a) || s.Equals(k) || s.Equals(c) || s.Equals(l) || s.Equals(g))
            {
                Console.WriteLine("fruit");
            }
            else if (s.Equals(t) || s.Equals(u) || s.Equals(p) || s.Equals(r))
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
