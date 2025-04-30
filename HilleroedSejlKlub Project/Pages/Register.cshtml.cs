using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HilleroedSejlKlub_Project.Models;
using HilleroedSejlKlub_Project.Services;
using System.Collections.Generic;

namespace HilleroedSejlKlub_Project.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly EventService _service;

        public List<Event> Events { get; private set; }

        public RegisterModel(EventService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            Events = _service.GetAllEvents();
        }

        public IActionResult OnPost(int selectedEventId, int memberId)
        {
            Member member = new Member(memberId, $"Member {memberId}");
            _service.RegisterMemberToEvent(selectedEventId, member);
            return RedirectToPage("/Register");
        }
    }
}
