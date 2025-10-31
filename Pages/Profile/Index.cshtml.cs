using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Readquest.Web.Pages.Profile
{
    public class ProfileModel : PageModel
    {
        public List<Book> CurrentReads { get; private set; } = new();
        public List<string> RecentReads { get; private set; } = new();

        public void OnGet()
        {
            CurrentReads = new List<Book>
            {
                new Book("A Game of Thrones", "/img/books/a-game-of-thrones.jpg", "480/720"),
                new Book("Six of Crows", "/img/books/six-of-crows.jpg", "380/720"),
                new Book("Legendborn", "/img/books/legendborn.jpg", "410/720"),
            };

            RecentReads = new List<string>
            {
                "/img/books/one-of-us-is-lying.jpg",
                "/img/books/they-both-die-at-the-end.jpg",
                "/img/books/legend.jpg",
                "/img/books/renegades.jpg"
            };
        }
    }

    public record Book(string Title, string Cover, string Pages);
}
