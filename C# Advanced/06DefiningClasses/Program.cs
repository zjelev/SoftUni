namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            TestEnum e = TestEnum.Medium;

            switch (e)
            {
                case TestEnum.Small:
                    break;
                case TestEnum.Medium:
                    break;
                case TestEnum.Large:
                    break;
                default:
                    break;
            }
        }
    }

    class Person
    {
        private int age;
        private string name;

        public Person(int age)
        {
            this.age = age;
        }

        public Person (int age, string name)
            : this(age)
        {
            this.name = name;
        }
    }
}
