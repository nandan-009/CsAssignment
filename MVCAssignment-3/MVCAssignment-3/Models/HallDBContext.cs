using Microsoft.EntityFrameworkCore;

namespace MVCAssignment_3.Models
{
    public class HallDBContext : DbContext
    {
        public HallDBContext(DbContextOptions opts) : base(opts)
        {
            
        }
        public DbSet<Hall> Halls { get; set; }
    }
}
