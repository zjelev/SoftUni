using System;
using System.Reflection;
using System.Linq;

namespace ReflectionApi
{
    class Program
    {
        static void Main(string[] args)
        {
            // string type = Console.ReadLine();
            // Type testType = Type.GetType(type);
            // Console.WriteLine($"Class Name: {testType.Name}, Class Full Name: {testType.FullName}");
            // Console.WriteLine($"Class Name: {typeof(TestClass).Name}");
            // Console.WriteLine($"Class Name: {Type.GetType("ReflectionApi.TestClass")?.Name}");

            try
            {
                Type myType = typeof(TestClass);
                                
                Type testType = Type.GetType(Console.ReadLine()); // Type.GetType("ReflectionApi.TestClass");
                TestClass test = (TestClass)Activator.CreateInstance(testType, new object[] { "Pesho", 12 });
                // Console.WriteLine($"Class name: {testType?.Name}");
                // Console.WriteLine($"{test.Name} - {test.Age}");
                Console.WriteLine(testType.IsAbstract);
                //var fields = testType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
                FieldInfo field = testType.GetField("secret", BindingFlags.NonPublic | BindingFlags.Instance);
                field.SetValue(test, "MyNewSecret");
                Console.WriteLine($"{field.GetValue(test)}, {field.IsPrivate}, {field.IsPublic}, {field.IsFamily}, {field.IsAssembly}");

                ConstructorInfo[] cinfo = testType.GetConstructors();
                Console.WriteLine(cinfo[1].GetParameters());

                TestClass newInstance = (TestClass)cinfo[1].Invoke(new object[] { "Gosho" });

                ConstructorInfo constructor = testType.GetConstructor(new Type[] {});

                MethodInfo[] publicMethods = testType.GetMethods();

                publicMethods[1].Invoke(newInstance, new object[] { 30 });

                //MethodInfo who = testType.GetMethods(publicMethods[2])

                MethodInfo appendMethod = testType.GetMethod("WhoAmI");
                appendMethod?.Invoke(newInstance, new object[] {});  // can be also null
                appendMethod.GetParameters();

                //appendMethod.MakeGenericMethod(typeof(string)); //when we have generic methods, TestClass doesn't have

                MethodInfo overloadMethod = testType.GetMethod("WhoAmI", new[] { typeof(string) });

                var attr = appendMethod.GetCustomAttributes().Where(a => a.GetType() == typeof(AuthorAttribute));
                System.Console.WriteLine($"Method: {appendMethod.Name}, Author: {((AuthorAttribute)attr.FirstOrDefault()).Name}");

            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                // throw;
            }
        }
    }
}
