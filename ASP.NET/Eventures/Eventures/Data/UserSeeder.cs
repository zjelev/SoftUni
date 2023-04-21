using Domain;
using Eventures.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Eventures.Data
{
    public class UserSeeder : ISeeder
    {
        private readonly UserManager<EventuresUser> _userManager;

        public UserSeeder(UserManager<EventuresUser> userManager)
        {
            _userManager = userManager;
        }
        public async void Seed()
        {
            var admin = new EventuresUser
            {
                UserName = "admin@admin.net",
                Email = "admin@admin.net"
            };

            var result = await _userManager.CreateAsync(admin, "123");

            if (result.Succeeded && _userManager.Users.Count() == 1)
                _userManager.AddToRoleAsync(admin, "Admin");
        }
    }
}
