using System;

namespace Stealer
{
    class Program
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            Console.WriteLine(spy.StealFieldInfo("Stealer.Hacker", "username", "password")); // 1
            // Console.WriteLine(spy.AnalyzeAcessModifiers("Stealer.Hacker")); // 2
            // Console.WriteLine(spy.RevealPrivateMethods("Stealer.Hacker")); // 3
            // Console.WriteLine(spy.CollectGettersAndSetters("Stealer.Hacker")); // 4
			
			// Type classType = typeof(Student);
            // Type[] classInterfaces = classType.GetInterfaces();
            // foreach (var @interface in classInterfaces)
            // {
            //     Console.WriteLine(@interface.Name);
            // }
			
            // Hacker hacker = new Hacker();
            // hacker.Password = "1234";
			
        }
    }
}
