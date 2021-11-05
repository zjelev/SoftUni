using System;
using System.Reflection;

namespace Demo.MyTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var asd = Assembly.GetCallingAssembly();
            var asd2 = Assembly.GetExecutingAssembly();
            
            TestsExecutor testsExecutor = new TestsExecutor(Assembly.GetExecutingAssembly());
            testsExecutor.Run();
        }
    }
}
