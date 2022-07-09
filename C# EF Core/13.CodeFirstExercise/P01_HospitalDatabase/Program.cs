using System;
using System.Collections.Generic;
using System.Linq;
using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Data.Models;

namespace P01_HospitalDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            HospitalContext db = new HospitalContext();

            Console.WriteLine("Please enter your username: ");

            var username = Console.ReadLine();

            var users = db.Doctors
                .Select(d => new
                {
                    UserName = d.UserName,
                    Passwd = d.Passwd
                }).ToDictionary(u => u.UserName, u => u.Passwd);

            if (users.Keys.Contains(username))
            {
                Console.Write("Enter your password: ");
                var password = Console.ReadLine();
                while (password != users[username])
                {
                    Console.WriteLine("Wrong password!");
                }
                Console.WriteLine("You are logged in!");
            }
            else
            {
                Console.WriteLine("No such username. Do you want to register (y)?");
                if (Console.ReadLine().ToLower() == "y")
                {
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    string passwd = Console.ReadLine();

                    db.Doctors.Add(new Doctor
                    {
                        Name = name,
                        UserName = username,
                        Passwd = passwd
                    });
                }
            }
            
            db.SaveChanges();
        }
    }
}
