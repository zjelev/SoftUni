using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Create()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}