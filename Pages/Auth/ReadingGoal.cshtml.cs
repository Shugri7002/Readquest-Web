using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Auth
{
    public class ReadingGoalModel : PageModel
    {
        [BindProperty] public string? Goal { get; set; }

        public void OnGet() { }

        // POST /Auth/ReadingGoal?handler=Finish
        public IActionResult OnPostFinish()
        {
            // TODO: store Goal
            return Redirect("/Dashboard"); // because your Dashboard has @page "/Dashboard"
        }
    }
}
