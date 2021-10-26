using System;

namespace ReflectionApi
{
    [Author("Pesho")]
    public class TestClass
    {

        private string secret = "mySecret";
        private bool isCreated = false;
        
        public TestClass()
        {
            isCreated = true;
        }

        public TestClass(string name) : this()
        {
            this.Name = name;
        }

        public TestClass(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public int Age { get; set; }

        public string Name; 

        [Author("Gosho")]
        public void WhoAmI()
        {
            Console.WriteLine(Name);
        }

        private void TellMeASecret()
        {
            Console.WriteLine(secret);
        }
    }
}
