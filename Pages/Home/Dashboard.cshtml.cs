using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Readquest.Web.Pages.Home;

public class DashboardModel : PageModel
{
    public void OnGet() { }

    // /Home/Dashboard?handler=EnterMap
    public IActionResult OnPostEnterMap()
    {
        // If Discover has @page "/Discover"
        return Redirect("/Discover");
    }

    // /Home/Dashboard?handler=StartChallenge
    public IActionResult OnPostStartChallenge()
    {
        return Redirect("/Quests");
    }
}
