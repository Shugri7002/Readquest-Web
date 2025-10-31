using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Home;

public class DashboardModel : PageModel
{
    public void OnGet() { }

    public IActionResult OnPostMap()
    {
        return Redirect("/Discover");
    }

    public IActionResult OnPostChallenge()
    {
        return Redirect("/Quests");
    }
}

