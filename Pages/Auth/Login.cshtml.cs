using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth;

public class LoginModel : PageModel
{
    [BindProperty] public string? Email { get; set; }
    [BindProperty] public string? Password { get; set; }

    public string? Message { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        // Dummy auth for now (accept anything non-empty)
        if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
        {
            // TODO: real auth
            return RedirectToPage("/Index");
        }

        Message = "Please enter your email and password.";
        return Page();
    }
}
