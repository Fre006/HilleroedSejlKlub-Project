using HilleroedSejlKlub_Project.Models;
using HilleroedSejlKlub_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HilleroedSejlKlub_Project.Pages
{
    public class EventDetailsModel : PageModel
    {
        private readonly EventService _eventService;

        public EventDetailsModel(EventService eventService)
        {
            _eventService = eventService;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Event? Event { get; set; }

        public void OnGet()
        {
            Event = _eventService.GetEventById(Id);
        }

        public IActionResult OnPostRegister(int eventId, int memberId, string memberName)
        {
            var member = new Member(memberId, memberName);
            _eventService.RegisterMemberToEvent(eventId, member);
            return RedirectToPage(new { id = eventId });
        }

        public IActionResult OnPostUnregister(int eventId, int memberId)
        {
            _eventService.UnregisterMemberFromEvent(eventId, memberId);
            return RedirectToPage(new { id = eventId });
        }
    }
}
