using Microsoft.EntityFrameworkCore;

namespace EmployeesWebAPI.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> opts) : base(opts)
        {

        }
        public DbSet<Employee> Employees
        {
            get; set;
        }
    }
}
