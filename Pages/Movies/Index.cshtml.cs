using asp_razor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace asp_razor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly asp_razor.Data.asp_razorContext _context;

        public IndexModel(asp_razor.Data.asp_razorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
