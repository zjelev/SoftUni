using System;

namespace _01.Oscars_ceremony
{
    class OscarsCeremony
    {
        static void Main(string[] args)
        {
            ushort rent = ushort.Parse(Console.ReadLine());
            double statues = rent * 0.7;
            double cathering = statues * 0.85;
            double sound = cathering / 2;
            string output = string.Format($"{rent + statues + cathering + sound:f2}");
            Console.WriteLine(output);
        }
    }
}