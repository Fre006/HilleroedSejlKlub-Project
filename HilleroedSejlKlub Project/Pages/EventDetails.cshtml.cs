//using HilleroedSejlKlub_Project.Models;
//using HilleroedSejlKlub_Project.Services;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc;

//public class EventDetailsModel : PageModel
//{
//    private readonly EventService _service;

//    public Event SelectedEvent { get; set; }

//    [BindProperty]
//    public int MemberId { get; set; }

//    public EventDetailsModel(EventService service)
//    {
//        _service = service;
//    }

//    public void OnGet(int id)
//    {
//        SelectedEvent = _service.GetAllEvents().FirstOrDefault(e => e.Id == id);
//    }

//    public IActionResult OnPostRegister(int id)
//    {
//        Member member = new Member(MemberId, $"Member {MemberId}");
//        _service.RegisterMemberToEvent(id, member);
//        return RedirectToPage(new { id = id });
//    }

//    public IActionResult OnPostUnregister(int id)
//    {
//        _service.UnregisterMemberFromEvent(id, MemberId);
//        return RedirectToPage(new { id = id });
//    }
//}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HilleroedSejlKlub_Project.Models;
using HilleroedSejlKlub_Project.Services;
using System.Collections.Generic;

namespace HilleroedSejlKlub_Project.Pages
{
    public class EventDetailsModel : PageModel
    {
        private readonly EventService _service;

        public Event SelectedEvent { get; set; }

        public EventDetailsModel(EventService service)
        {
            _service = service;
        }

        public IActionResult OnGet(int id)
        {
            SelectedEvent = _service.GetEventById(id);
            if (SelectedEvent == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPostRegister(int id, int MemberId)
        {
            Member member = new Member(MemberId, $"Member {MemberId}");
            _service.RegisterMemberToEvent(id, member);

            return RedirectToPage("/EventDetails", new { id = id });
        }

        public IActionResult OnPostUnregister(int id, int MemberId)
        {
            _service.UnregisterMemberFromEvent(id, MemberId);

            return RedirectToPage("/EventDetails", new { id = id });
        }
    }
}
