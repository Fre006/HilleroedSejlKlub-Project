using HilleroedSejlKlub_Project.Models;
using HilleroedSejlKlub_Project.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace HilleroedSejlKlub_Project.Pages
{
    public class EventsModel : PageModel
    {
        private readonly EventService _eventService;

        public EventsModel(EventService eventService)
        {
            _eventService = eventService;
        }

        public List<Event> Events { get; set; } = new();

        public void OnGet()
        {
            Events = _eventService.GetAllEvents();
        }
    }
}
