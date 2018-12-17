using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}