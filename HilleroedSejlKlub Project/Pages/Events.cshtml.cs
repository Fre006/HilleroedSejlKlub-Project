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

        [BindProperty]
        public int MemberId { get; set; }

        public EventsModel(EventService eventService)
        {
            _eventService = eventService;
        }

        public void OnGet()
        {
            Events = _eventService.GetAllEvents();
        }

        public IActionResult OnPostRegister(int eventId)
        {
            Member member = new Member(MemberId, $"Member {MemberId}");
            _eventService.RegisterMemberToEvent(eventId, member);
            return RedirectToPage();
        }

        public IActionResult OnPostUnregister(int eventId)
        {
            _eventService.UnregisterMemberFromEvent(eventId, MemberId);
            return RedirectToPage();
        }
    }
}
