using System;

namespace _13.Enter_Even_Number__with_Text_Input_
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = 0;
                while (true)
                {
                    try
                    {
                        Console.Write("Enter even number: ");
                        n = int.Parse(Console.ReadLine());
                        if (n % 2 == 0)
                        {
                            Console.WriteLine("Even number entered: " + n);
                            break;
                        }
                        Console.WriteLine("The number is not even.");
                    }
                
                    catch (Exception)
                    {

                        Console.WriteLine("Invalid number.");
                    }
                }
            }
        }
    }
}