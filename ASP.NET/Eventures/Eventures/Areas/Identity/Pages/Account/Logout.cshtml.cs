﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Eventures.Areas.Identity.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly SignInManager<EventuresUser> _signInManager;

        public LogoutModel(SignInManager<EventuresUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> OnPost() //string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            //if (returnUrl != null)
            //    return LocalRedirect(returnUrl);
            //else
                return RedirectToPage();
        }
    }
}
