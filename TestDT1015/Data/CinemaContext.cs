using Microsoft.EntityFrameworkCore;

namespace TestDT1015.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            
        }

        public DbSet<Models.Movie> Movie { get; set; }
    }
}
