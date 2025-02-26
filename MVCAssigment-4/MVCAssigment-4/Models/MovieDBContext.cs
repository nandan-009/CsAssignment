using Microsoft.EntityFrameworkCore;

namespace MVCAssigment_4.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext(DbContextOptions<MovieDBContext> opts) : base(opts)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
