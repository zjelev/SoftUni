using System;

namespace _02.X_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal result = 0;
            int oper = '+';
            int symbol = 0;
            while (symbol != '=')
            {
                symbol = Console.Read();
                if (symbol == '(')
                {
                    decimal innerResult = 0;
                    int innerOper = '+';
                    while (symbol != ')')
                    {
                        symbol = Console.Read();
                        if (0 <= symbol - '0' && symbol - '0' <= '9' && symbol != '=' && symbol != ')')
                        {
                            switch (innerOper)
                            {
                                case '+':
                                    innerResult += symbol - '0';
                                    break;
                                case '-':
                                    innerResult -= symbol - '0';
                                    break;
                                case '*':
                                    innerResult *= symbol - '0';
                                    break;
                                case '/':
                                    innerResult /= symbol - '0';
                                    break;
                            }
                        }
                        else if (symbol == '+' || symbol == '-' || symbol == '/' || symbol == '*')
                        {
                            innerOper = symbol;
                        }
                    }
                    switch (oper)
                    {
                        case '+':
                            result += innerResult;
                            break;
                        case '-':
                            result -= innerResult;
                            break;
                        case '*':
                            result *= innerResult;
                            break;
                        case '/':
                            result /= innerResult;
                            break;
                    }
                }
                else if (0 <= symbol - '0' && symbol - '0' <= '9' && symbol != '=')
                {
                    switch (oper)
                    {
                        case '+':
                            result += symbol - '0';
                            break;
                        case '-':
                            result -= symbol - '0';
                            break;
                        case '*':
                            result *= symbol - '0';
                            break;
                        case '/':
                            result /= symbol - '0';
                            break;
                    }
                }
                else if (symbol == '+' || symbol == '-' || symbol == '/' || symbol == '*')
                {
                    oper = symbol;
                }
            }
            Console.Write($"{result:0.00}");
        }
    }
}