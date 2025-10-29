using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth
{
    public class AgeSelectionModel : PageModel
    {
        // bound to the selected radio
        [BindProperty]
        public int? SelectedAge { get; set; }

        public void OnGet() {}

        public IActionResult OnPost()
        {
            if (SelectedAge is null)
            {
                ModelState.AddModelError(nameof(SelectedAge), "Please pick an age.");
                return Page();
            }

            // Go to Genres and carry the chosen age (use TempData if you prefer)
            return RedirectToPage("/Auth/Genres", new { age = SelectedAge.Value });
        }
    }
}
