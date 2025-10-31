using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth;

public class RegisterModel : PageModel
{
    [BindProperty] public string? FullName { get; set; }
    [BindProperty] public string? Email { get; set; }
    [BindProperty] public string? Password { get; set; }
    [BindProperty] public string? ConfirmPassword { get; set; }

    public string? Message { get; set; }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (string.IsNullOrWhiteSpace(FullName) ||
            string.IsNullOrWhiteSpace(Email) ||
            string.IsNullOrWhiteSpace(Password) ||
            string.IsNullOrWhiteSpace(ConfirmPassword))
        {
            Message = "Please fill in all fields.";
            return Page();
        }

        if (!string.Equals(Password, ConfirmPassword, StringComparison.Ordinal))
        {
            Message = "Passwords do not match.";
            return Page();
        }

        // TODO: save user to DB (later)
    return Redirect("/Auth/AgeSelection");
    }


}
