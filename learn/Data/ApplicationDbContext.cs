using learn.Model;
using Microsoft.EntityFrameworkCore;

namespace learn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext) 
        {
            
        }

        public DbSet<Company> Companies { get; set; }
    }
}
