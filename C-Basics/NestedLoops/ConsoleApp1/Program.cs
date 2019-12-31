using System;

namespace _08_Secret_Doors_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLimit = int.Parse(Console.ReadLine());
            int secondLimit = int.Parse(Console.ReadLine());
            int thirdLimit = int.Parse(Console.ReadLine());

            for (int firstDigit = 2; firstDigit <= firstLimit; firstDigit+=2)
            {
                for (int secondDigit = 2; secondDigit <= secondLimit; secondDigit++)
                {
                    bool secondDigitIsPrime = true;

                    for (int i = 2; i <= secondDigit / 2 + 1; i++)
                    {
                        if (secondDigit % i == 0 && secondDigit > 2)
                        {
                            secondDigitIsPrime = false;
                            break;
                        }
                    }
                    for (int thirdDigit = 2; thirdDigit <= thirdLimit; thirdDigit+=2)
                    { 
                        if (secondDigitIsPrime)
                        {
                            Console.WriteLine(""+firstDigit+" "+secondDigit+" "+thirdDigit);
                        }
                    }
                }
            }
        }
    }
}
