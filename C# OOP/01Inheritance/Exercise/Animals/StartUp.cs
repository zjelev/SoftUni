using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animalType = System.Console.ReadLine();
            
            while (animalType != "Beast!")
            {
                string[] nameAgeGender = System.Console.ReadLine()
                 .Split();
                string name = nameAgeGender[0];
                
                int age = int.Parse(nameAgeGender[1]);
                
                string gender = nameAgeGender[2];

                if ((name == String.Empty) || (age <= 0) ||
                    (gender != "Male" && gender != "Female"))
                {
                    Console.WriteLine("Invalid input!");
                }

                Animal animal;

                switch (animalType)
                {
                    case "Dog":
                        animal = new Dog(name, age, gender);
                        break;                    
                    case "Cat":
                        animal = new Cat(name, age, gender);
                        break;
                    case "Frog":
                        animal = new Frog(name, age, gender);
                        break;
                    case "Kitten":
                        animal = new Kitten(name, age);
                        break;
                    default: animal = new Tomcat(name, age);
                        break;
                }

                if (gender != String.Empty && age > 0 && gender != String.Empty)
                {
                    Console.WriteLine(animalType);
                    Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                    Console.WriteLine(animal.ProduceSound());
                }

                animalType = Console.ReadLine();
            }
        }
    }
}
