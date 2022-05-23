using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace robodoc.frontend.Pages
{
    public class WelcomeModel : PageModel
    {
        public string? Username { get; set; }

        public void OnGet()
        {
            Username = HttpContext.Session.GetString("username");
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToPage("Index");
        }
    }
}