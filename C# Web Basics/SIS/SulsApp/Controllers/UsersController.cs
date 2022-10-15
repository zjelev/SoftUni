using System.Net.Mail;
using SIS.Http;
using SIS.Http.Response;
using SIS.MvcFramework;
using SulsApp.Models;

namespace SulsApp.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Login()
        {
            return this.View();
        }

        [HttpPost("/Users/Login")]
        public HttpResponse DoLogin()
        {
            return this.View();
        }

        public HttpResponse Register()
        {
            return this.View();
        }

        [HttpPost("/Users/Register")]

        public HttpResponse DoRegister()
        {
            var username = this.Request.FormData["username"];
            var email = this.Request.FormData["email"];
            var password = this.Request.FormData["password"];
            var confirmPassword = this.Request.FormData["confirmPassword"];

            if (password != confirmPassword)
            {
                return this.Error("Passwords should be the same<");
            }

            if (username?.Length < 5 || username.Length > 20)
            {
                return this.Error("Username should be between 5 and 20 characters");
            }

            if (password?.Length < 6 || password.Length > 20)
            {
                return this.Error("Password should be abetween 6  and 20 characters");
            }

            if (!IsValid(email))
            {
                return this.Error("Email should be valid");
            }

            var user = new User
            {
                Email = email,
                Username = username,
                Password = this.Hash(password),
            };

            var db = new ApplicationDbContext();
            db.Users.Add(user);
            db.SaveChanges();

            // TODO: Login

            return this.Redirect("/");
        }

        private bool IsValid(string emailaddress)
        {
            try
            {
                new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}