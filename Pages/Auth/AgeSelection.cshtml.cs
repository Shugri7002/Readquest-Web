using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth
{
    public class AgeSelectionModel : PageModel
    {
        [BindProperty]
        public int? SelectedAge { get; set; }

        public void OnGet()
        {
            // Nothing yet – just loads the page
        }

        public IActionResult OnPostSelectAge(int age)
        {
            // Save the selected age temporarily in session (optional)
            HttpContext.Session.SetInt32("UserAge", age);

            // Later this will go to Genre Selection
            return RedirectToPage("/Auth/GenreSelection");
        }
    }
}
