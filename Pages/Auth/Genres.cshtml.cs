using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth;

public class GenresModel : PageModel
{
    // show six tiles
    public string[] AllGenres { get; } = new[]
    {
        "Adventure", "Fantasy", "Mystery",
        "Romance", "Sci-Fi", "Horror"
    };

    // bound from checkboxes named "Selected"
    [BindProperty]
    public List<string> Selected { get; set; } = new();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        // keep it simple: stash selection for next steps
        TempData["genres"] = string.Join(",", Selected ?? new());

        // TODO: send to Reading Goal page when you build it
        return RedirectToPage("/Auth/ReadingGoal"); // change if needed
    }
    public IActionResult OnPostContinue()
{
    return Redirect("/Auth/ReadingGoal");
}

}
