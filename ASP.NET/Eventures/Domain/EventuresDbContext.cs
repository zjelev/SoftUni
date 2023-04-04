﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Domain;
public class EventuresDbContext : IdentityDbContext<EventuresUser, IdentityRole, string>
{
    public EventuresDbContext(DbContextOptions<EventuresDbContext> options) : base(options)
    {
    }
}