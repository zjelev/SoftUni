using System;
using System.Linq;
using P03_FootballBetting.Data;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting
{
    class StartUp
    {
        static void Main(string[] args)
        {
            FootballBettingContext context = new FootballBettingContext();

            var user = new User
            {
                Username = "Gosho123",
                Email = "gosho@abv.bg",
                Password = "12345"
            };

            context.Users.Add(user);
            context.SaveChanges();
            
            var users = context
                .Users
                .Select(u =>new
                {
                    u.Username,
                    u.Email,
                    Name = u.Name == null ? "no name" : u.Name
                });
            
            foreach (var u in users)
            {
                Console.WriteLine($"{u.Username} - {u.Email}");
            }
        }
    }
}
