﻿using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> intEqu = new EqualityScale<int>(6, 6);
            Console.WriteLine(intEqu.AreEqual());
        }
    }
}
