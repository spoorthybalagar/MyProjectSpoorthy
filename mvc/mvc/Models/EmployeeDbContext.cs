using Microsoft.EntityFrameworkCore;

namespace mvc.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        public DbSet<EmployeeModel> employees { get; set; }
    }
}
