﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            HashSet<string> cars = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var token = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    
                if (token[0] == "IN")
                {
                    cars.Add(token[1]);
                }
                else if (token[0] == "OUT")
                {
                    cars.Remove(token[1]);
                }
            }
            
            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            

        }
    }
}