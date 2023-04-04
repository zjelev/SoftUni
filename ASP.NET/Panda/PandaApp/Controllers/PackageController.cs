﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Panda.Domain;
using PandaApp.Models.Package;
using System.Globalization;

namespace PandaApp.Controllers;
public class PackageController : Controller
{
    private readonly PandaDbContext context;

    public PackageController(PandaDbContext context)
    {
        this.context = context;
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Create()
    {
        ViewData["Recipients"] = context.Users.ToList();
        return View(new PackageCreateBindingModel());
    }

    [HttpPost, Authorize(Roles = "Admin")]
    public IActionResult Create(PackageCreateBindingModel bindingModel)
    {
        if (!this.ModelState.IsValid)
            return this.View(bindingModel ?? new PackageCreateBindingModel());

        var recipient = this.context.Users.SingleOrDefault(user => user.UserName == bindingModel.Recipient);

        Package package = new Package
        {
            Id = Guid.NewGuid().ToString(),
            Description = bindingModel.Description,
            Recipient = this.context.Users.SingleOrDefault(user => user.UserName == bindingModel.Recipient),
            ShippingAddress = bindingModel.ShippingAddress,
            Weight = bindingModel.Weight,
            Status = this.context.PackageStatus.SingleOrDefault(status => status.Name == "Pending")
        };

        this.context.Packages.Add(package);
        this.context.SaveChanges();

        return this.Redirect("/Package/Pending");
    }

    [Authorize]
    public IActionResult Details(string id)
    {
        Package package = this.context.Packages
            .Where(packageFromDb => packageFromDb.Id == id)
            .Include(packageFromDb => packageFromDb.Recipient)
            .Include(packageFromDb => packageFromDb.Status)
            .FirstOrDefault();

        var viewModel = new PackageDetailsViewModel
        {
            Description = package.Description,
            Recipient = package.Recipient.UserName,
            ShippingAddress = package.ShippingAddress,
            Weight = package.Weight,
            Status = package.Status.Name
        };

        if (package.Status.Name == "Pending")
            viewModel.EstimatedDeliveryDate = "N/A";
        else if (package.Status.Name == "Shipped")
            viewModel.EstimatedDeliveryDate = package.EstimatedDeliveryDate?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        else
            viewModel.EstimatedDeliveryDate = "Delivered";

        return this.View(viewModel);
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Ship(string id)
    {
        Package package = this.context.Packages.Find(id);

        package.Status = this.context.PackageStatus.SingleOrDefault(status => status.Name == "Shipped");
        package.EstimatedDeliveryDate = DateTime.Now.AddDays(new Random().Next(20, 40));
        this.context.Update(package);
        this.context.SaveChanges();

        return this.Redirect("/Package/Shipped");
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Deliver(string id)
    {
        Package package = this.context.Packages.Find(id);

        package.Status = this.context.PackageStatus.SingleOrDefault(status => status.Name == "Delivered");
        this.context.Update(package);
        this.context.SaveChanges();

        return this.Redirect("/Package/Delivered");
    }

    [Authorize]
    public IActionResult Acquire(string id)
    {
        Package package = this.context.Packages.Find(id);

        package.Status = this.context.PackageStatus.SingleOrDefault(status => status.Name == "Acquired");
        this.context.Update(package);

        Receipt receipt = new Receipt
        {
            Fee = (decimal)(2.67 * package.Weight),
            IssuedOn = DateTime.Now,
            Package = package,
            Recipient = context.Users.FirstOrDefault(user => user.UserName == this.User.Identity.Name)
        };

        this.context.Receipts.Add(receipt);
        this.context.SaveChanges();

        return this.Redirect("/Home/Index");
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Pending()
    {
        return this.View(context.Packages
            .Include(package => package.Recipient)
            .Where(package => package.Status.Name == "Pending")
            .ToList().Select(package =>
        {
            return new PackagePendingViewModel
            {
                Id = package.Id,
                Description = package.Description,
                Weight = package.Weight,
                ShippingAddress = package.ShippingAddress,
                Recipient = package.Recipient.UserName
            };
        }).ToList());
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Shipped()
    {
        return this.View(context.Packages
            .Include(package => package.Recipient)
            .Where(package => package.Status.Name == "Shipped")
            .ToList().Select(package =>
            {
                return new PackageShippedViewModel
                {
                    Id = package.Id,
                    Description = package.Description,
                    Weight = package.Weight,
                    EstimatedDeliveryDate = package.EstimatedDeliveryDate?.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Recipient = package.Recipient.UserName
                };
            }).ToList());
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Delivered()
    {
        return this.View(context.Packages
            .Include(package => package.Recipient)
            .Where(package => package.Status.Name == "Delivered" || package.Status.Name == "Acquired")
            .ToList().Select(package =>
            {
                return new PackageDeliveredViewModel
                {
                    Id = package.Id,
                    Description = package.Description,
                    Weight = package.Weight,
                    ShippingAddress = package.ShippingAddress,
                    Recipient = package.Recipient.UserName
                };
            }).ToList());
    }
}