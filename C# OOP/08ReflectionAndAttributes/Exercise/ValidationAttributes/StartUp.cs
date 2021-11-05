using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidationAttributes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person
            (
                "Peter",
                15
            );

            bool isValid = Validator.IsValid(
                person
                );

            Console.WriteLine(isValid);

            //bool isValidEntity = Validator.IsValid(person);

            //Console.WriteLine(isValidEntity);
        }
    }
}
