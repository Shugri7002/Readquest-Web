using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth;

public class RegisterModel : PageModel
{
    [BindProperty]
    public RegisterInput Input { get; set; } = new();

    public class RegisterInput
    {
        [Required, StringLength(80)]
        public string FullName { get; set; } = "";

        [Required, EmailAddress]
        public string Email { get; set; } = "";

        [Required, StringLength(100, MinimumLength = 6,
            ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; } = "";

        [Required, Compare(nameof(Password), ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = "";
    }

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        // TODO: later save to a database + hash password, etc.

        // Keep a friendly name for the next page (optional)
        TempData["UserName"] = Input.FullName;

        // Go to Age Selection (we’ll build this next)
        return RedirectToPage("/Onboarding/Age");
    }
}
