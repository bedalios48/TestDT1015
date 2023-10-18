using Microsoft.EntityFrameworkCore;

namespace TestDT1015.Data
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            
        }

        public DbSet<Models.Movie> Movie { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
/*#warning To protect potentially sensitive information in your connection string, 
            you should move it out of source code.See http://go.microsoft.com/fwlink/?LinkId=723263 
     for guidance on storing connection strings.*/

         /*   optionsBuilder.UseMySQL("Server=(localdb)\\mssqllocaldb;Database=CinemaContext-55912999-2c8f-46d3-99cc-bf932c1d13fe;Trusted_Connection=True;MultipleActiveResultSets=true");
        }*/
    }
}
