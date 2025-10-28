using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth;

public class LoginModel : PageModel
{
    [BindProperty] public string? Email { get; set; }
    [BindProperty] public string? Password { get; set; }
    public string? Message { get; private set; }

    public void OnGet() { }

    public void OnPost()
    {
        Message = (Email == "test@readquest.com" && Password == "1234")
            ? "Login successful!"
            : "Invalid credentials. Try again.";
    }
}
