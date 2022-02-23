//https://judge.softuni.bg/Contests/Practice/Index/509#2
using System;

namespace _03._Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char oper = char.Parse(Console.ReadLine());
            string output = string.Empty;
            if (oper == '/' || oper == '%')
            {
                if (n2 == 0)
                {
                    output = string.Format("Cannot divide {0} by zero", n1);
                }
                else if (oper == '/')
                    {
                        decimal result = (decimal)n1 / n2;
                        output = string.Format("{0} / {1} = {2:f2}", n1, n2, result);
                    }
                else if (oper == '%')
                    {
                        int result = n1 % n2;
                        output = string.Format("{0} % {1} = {2}", n1, n2, result);
                    }
            }
            else
            {
                int result = 0;
                if (oper == '+')
                {
                    result = n1 + n2;
                }
                else if (oper == '-')
                {
                    result = n1 - n2;
                }
                else if (oper == '*')
                {
                    result = n1 * n2;
                }
                output = string.Format("{0} {1} {2} = {3} - {4}", n1, oper, n2, result, result % 2 == 0 ? "even" : "odd");
            }
            Console.WriteLine(output);
        }
    }
}