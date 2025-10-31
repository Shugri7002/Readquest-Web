using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Readquest.Web.Pages.Quests
{
    // Must be public and the name must be exactly QuestsModel
    public class QuestsModel : PageModel
    {
        public List<Quest> Quests { get; private set; } = new();

        public void OnGet()
        {
            Quests = new List<Quest>
            {
                new Quest("Read for 30 minutes today", 250),
                new Quest("Discover a new realm", 500),
                new Quest("Complete one book this week", 250),
                new Quest("Log in three days in a row", 800),
            };
        }
    }

    public record Quest(string Title, int XP);
}
