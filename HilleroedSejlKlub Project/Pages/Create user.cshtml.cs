using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HilleroedSejlKlub_Project.Service;
using HilleroedSejlKlub_Project.Models;
using System.Diagnostics;

namespace HilleroedSejlKlub_Project.Pages
{
    public class Create_userModel : PageModel
    {
        private UserService _userService;

        [BindProperty]
        public User User { get; set; }

        public Create_userModel(UserService us)
        {
            User = new User();

            _userService = us;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            Debug.WriteLine("MemberNumber test" + User.MemberNumber);
            Debug.WriteLine("Password test" + User.Password);
            Debug.WriteLine("Name test" + User.Name);
            _userService.Add(User);
            return RedirectToPage("/Log-in");
        }
    }
}
