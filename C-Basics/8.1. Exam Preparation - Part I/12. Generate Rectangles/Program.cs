using System;

namespace _12.Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            for (int left = -n; left < n; left++)
            {
                for (int bottom = -n; bottom < n; bottom++)
                {
                    for (int right = left + 1; right <=n; right++)
                    {
                        for (int top = bottom + 1; top <= n; top++)
                        {
                            int area = Math.Abs((right - left) * Math.Abs(top - bottom));
                            if (area>=m)
                            {
                                Console.WriteLine("(" + left + ", " + bottom + ") (" + right + ", " + top + ") -> " + area);
                                count++;
                            }
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}