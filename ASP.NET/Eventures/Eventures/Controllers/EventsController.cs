using Domain;
using Eventures.Models.BindingModels;
using Eventures.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventuresDbContext context;

        public EventsController(EventuresDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<EventsViewModel> events = context.Events
                .Select(eventFromDb => new EventsViewModel
                {
                    Name = eventFromDb.Name,
                    Place = eventFromDb.Place,
                    Start = eventFromDb.Start.ToString("dd-MMM-yyyy HH:mm", CultureInfo.InvariantCulture),
                    End = eventFromDb.End.ToString("dd-MMM-yyyy HH:mm", CultureInfo.InvariantCulture)
                })
                .ToList();

            return View(events);
        }

        public IActionResult Create(EventCreateBindingModel bindingModel)
        {
            if (this.ModelState.IsValid)
            {
                Event eventForDb = new Event
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = bindingModel.Name,
                    Place = bindingModel.Place,
                    Start = bindingModel.Start,
                    End = bindingModel.End,
                    TotalTickets = bindingModel.TotalTickets,
                    PricePerTicket = bindingModel.PricePerTicket
                };

                context.Events.Add(eventForDb);
                context.SaveChanges();

                return this.RedirectToAction("Index");
            }

            return View();

        }
    }
}
