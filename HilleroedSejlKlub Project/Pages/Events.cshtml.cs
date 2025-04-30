using HilleroedSejlKlub_Project.Models;
using HilleroedSejlKlub_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleroedSejlKlub_Project.Pages
{
    public class EventsModel : PageModel
    {
        private readonly EventService _eventService;
        public List<Event> Events { get; set; }
        public EventsModel(EventService eventService)
        {
            _eventService = eventService;
        }

        public void OnGet()
        {
            EventService service = new EventService();

            service.CreateEvent(new Event(1, "Informationsaften", new DateTime(2025, 4, 1)));
            service.CreateEvent(new Event(2, "Arbejdsdag", new DateTime(2025, 5, 1)));
            
            Events = service.GetAllEvents();
        }
    }
}
