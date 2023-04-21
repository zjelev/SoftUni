using Domain;
using Microsoft.AspNetCore.Identity;

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
            switch (_userManager.Users.Count())
            {
                case 0:
                    {
                        var user = new EventuresUser
                        {
                            UserName = "admin@admin.net",
                            Email = "admin@admin.net"
                        };

                        var result = await _userManager.CreateAsync(user, "123");

                        if (result.Succeeded)
                            _userManager.AddToRoleAsync(user, "Admin");
                    }
                    break;
                case 1:
                    {
                        var user = new EventuresUser
                        {
                            UserName = "user@user.net",
                            Email = "user@user.net"
                        };

                        var result = await _userManager.CreateAsync(user, "123");

                        if (result.Succeeded)
                            _userManager.AddToRoleAsync(user, "User");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
