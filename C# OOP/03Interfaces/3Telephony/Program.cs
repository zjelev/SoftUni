using System;

namespace Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone huawei = new Smartphone();
            StationaryPhone panasonic = new StationaryPhone();
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        
            foreach (var number in numbers)
            {
                if (number.Length == 7)
                {
                    panasonic.Call(number);
                }
                else if (number.Length == 10)
                {
                    huawei.Call(number);
                }
            }

            string[] urls = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var url in urls)
            {
                huawei.Browse(url);
            }
        }
    }
}
