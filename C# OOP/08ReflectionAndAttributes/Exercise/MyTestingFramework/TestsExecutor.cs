using System;
using System.Linq;
using System.Reflection;
using MyTestingFramework.Attributes;

namespace MyTestingFramework
{
    public class TestsExecutor
    {
        private readonly Assembly assembly;
        public TestsExecutor(Assembly assembly)
        {
            this.assembly = assembly;
        }

        public void Run()
        {
            var asd = Assembly.GetCallingAssembly();
            var asd2 = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes()
                .Where(c => c.GetCustomAttributes<MyTestFixtureAttribute>().Any())
                .ToArray();

            foreach (var type in types)
            {
                MethodInfo[] methodInfos = type.GetMethods()
                    .Where(m => m.GetCustomAttributes<MyTestAttribute>().Any())
                    .ToArray();
                
                // run each method
                foreach (var methodInfo in methodInfos)
                {
                    
                }
            }


        }
    }

}