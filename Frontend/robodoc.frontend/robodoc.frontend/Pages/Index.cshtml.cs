using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace robodoc.frontend.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string? Username { get; set; }
        [BindProperty]
        public string? Password { get; set; }
        public string? Msg { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username == null || Password == null)
            {
                Msg = "Invalid";
                return Page();
            }
            else if (Username.Equals("abc") && Password.Equals("123"))
            {
                HttpContext.Session.SetString("username", Username);
                return RedirectToPage("Welcome");
            }
            else
            {
                Msg = "Invalid";
                return Page();
            }
        }
    }
}