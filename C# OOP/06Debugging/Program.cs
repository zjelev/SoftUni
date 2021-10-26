using System;
using System.IO;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";
            string res = Task.Run(() => GetFileDataAsync(path)).GetAwaiter().GetResult();
            Console.WriteLine(res);

            A();
        }

        private static void A()
        {
            B();
        }

        private static void B()
        {
            C();
        }

        private static void C()
        {
            Console.WriteLine("Method C");
        }

        private static async Task<string> GetFileDataAsync(string path)
        {
            string res = await File.ReadAllTextAsync(path);
            return res;
        }
    }
}
