﻿using Microsoft.AspNetCore.Identity;

namespace Panda.Domain;

public class PandaUser : IdentityUser
{
    public PandaUser()
    {
        this.Packages = new List<Package>();
        this.Receipts = new List<Receipt>();
    }

    public ICollection<Package> Packages { get; set; }

    public ICollection<Receipt> Receipts { get; set; }

}
