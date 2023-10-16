using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestDT1015.Data;
using TestDT1015.Models;

namespace TestDT1015.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly TestDT1015.Data.CinemaContext _context;

        public IndexModel(TestDT1015.Data.CinemaContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
